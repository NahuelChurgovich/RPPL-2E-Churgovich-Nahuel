using System;
using System.Drawing;
using System.Windows.Forms;

using Entidades;
using Entidades.Usuarios;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormABMUsuario : FrmBase
    {
        private Usuario usuarioForm;
        public FormABMUsuario()
        {
            InitializeComponent();
        }

        public FormABMUsuario(Usuario usuario, CheckState estado) : this()
        {
            usuarioForm = usuario;
            chkNocturno.CheckState = estado;
        }

        private void FormABMUsuario_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = PetShop.usuarios;
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarUsuario);
                CajaTextoOscuro(txtNombre, txtCuil, txtAlias, txtContrasenia);
                BotonOscuro(btnBuscarUsuario, btnAgregar, btnModificar);
                BotonOscuro(btnBorrar);
                dgvDatos.BackgroundColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                CajaTextoClaro(txtBuscarUsuario);
                CajaTextoClaro(txtNombre, txtCuil, txtAlias, txtContrasenia);
                BotonClaro(btnBuscarUsuario, btnAgregar, btnModificar);
                BotonClaro(btnBorrar);
                dgvDatos.BackgroundColor = Color.RoyalBlue;

            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (PetShop.BuscarUsuario(txtBuscarUsuario.Text) != -1)
            {
                int auxIndice = PetShop.BuscarUsuario(txtBuscarUsuario.Text);

                txtNombre.Text = PetShop.usuarios[auxIndice].Nombre;
                txtCuil.Text = PetShop.usuarios[auxIndice].Cuil.ToString();
                txtAlias.Text = PetShop.usuarios[auxIndice].Alias;
                txtContrasenia.Text = PetShop.usuarios[auxIndice].Contrasenia;
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtCuil.Text = string.Empty;
                txtAlias.Text = string.Empty;
                txtContrasenia.Text = string.Empty;
                MessageBox.Show("El usuario no se encontró", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int auxIndice = PetShop.BuscarUsuario(txtBuscarUsuario.Text);
            BorrarUsuario(usuarioForm, auxIndice);
        }


        /// <summary>
        /// Borra un administrador o empleado determinado siempre y cuando el usuario de acceso tenga el nivel de acceso correcto. Caso contrario 
        /// no se borra y se advierte al usuario la falta de acceso.
        /// </summary>
        /// <param name="usuarioForm"></param>
        /// <param name="auxIndice"></param>
        private void BorrarUsuario(Usuario usuarioForm, int auxIndice)
        {
            if (ValidarAccesoModificacion(usuarioForm, auxIndice))
            {
                if (MessageBox.Show("¿Seguro que desea borrar este usuario?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (PetShop.BorrarUsuario(auxIndice))
                    {
                        VaciarTextBox();
                        MessageBox.Show("El usuario se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No tiene permisos para borra este usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            int auxIndice = PetShop.BuscarUsuario(txtBuscarUsuario.Text);
            if (ValidarAccesoModificacion(usuarioForm, auxIndice))
            {
                if (txtNombre.Text != PetShop.usuarios[auxIndice].Nombre || txtCuil.Text != PetShop.usuarios[auxIndice].Cuil.ToString() ||
                    txtAlias.Text != PetShop.usuarios[auxIndice].Alias || txtContrasenia.Text != PetShop.usuarios[auxIndice].Contrasenia)
                {
                    PetShop.usuarios[auxIndice].Nombre = txtNombre.Text;
                    PetShop.usuarios[auxIndice].Alias = txtAlias.Text;
                    PetShop.usuarios[auxIndice].Contrasenia = txtContrasenia.Text;
                    if (long.TryParse(txtCuil.Text, out long cuitCorrecto))
                    {
                        PetShop.usuarios[auxIndice].Cuil = cuitCorrecto;
                    }
                    MessageBox.Show("Datos modificados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarTextBox();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha modificado ningún dato", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No tiene permisos para modificar este usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int auxIndice = PetShop.BuscarUsuario(txtAlias.Text, txtNombre.Text, txtCuil.Text);
            if (ValidarAccesoModificacion(usuarioForm, auxIndice))
            {
                if (PetShop.usuarios[auxIndice].Alias == txtAlias.Text)
                {
                    txtAlias.Text = $"{txtAlias.Text}... Ya existe";
                    txtAlias.ForeColor = Color.Red;
                }
                else if (PetShop.usuarios[auxIndice].Nombre == txtNombre.Text)
                {
                    txtNombre.Text = $"{txtNombre.Text}... Ya existe";
                    txtNombre.ForeColor = Color.Red;
                }
                else if (PetShop.usuarios[auxIndice].Cuil.ToString() == txtCuil.Text)
                {
                    txtCuil.Text = $"{txtCuil.Text}... Ya existe";
                    txtCuil.ForeColor = Color.Red;
                }

            }
            else
            {
                int contador = PetShop.CantidadUsuarios;
                if (long.TryParse(txtCuil.Text, out long auxCuil))
                {
                    if (usuarioForm.GetType() == typeof(SuperUsuario))
                    {
                        Administrador nuevoUsuario = new Administrador(txtAlias.Text, txtNombre.Text, auxCuil, txtContrasenia.Text);
                        PetShop.usuarios.Add(nuevoUsuario);
                    }
                    else if (usuarioForm.GetType() == typeof(Administrador))
                    {
                        Empleado nuevoUsuario = new Empleado(txtAlias.Text, txtNombre.Text, auxCuil, txtContrasenia.Text);
                        PetShop.usuarios.Add(nuevoUsuario);
                    }

                }
                else
                {
                    MessageBox.Show("Ocurrió un problema con el CUIL, el administrador no se creó", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                }
                if (contador < PetShop.CantidadUsuarios)
                {

                    MessageBox.Show("El usuario se agrego con éxito", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    this.txtCuil.Text = string.Empty;
                    this.txtNombre.Text = string.Empty;
                    this.txtContrasenia.Text = string.Empty;
                    this.txtAlias.Text = string.Empty;
                    dgvDatos.DataSource = PetShop.usuarios;
                    this.Close();
                }
            }

        }

        /// <summary>
        /// Limpia los textbox del formulario
        /// </summary>
        private void VaciarTextBox()
        {
            this.txtNombre.Text = string.Empty;
            this.txtCuil.Text = string.Empty;
            this.txtAlias.Text = string.Empty;
            this.txtContrasenia.Text = string.Empty;
            this.txtBuscarUsuario.Text = string.Empty;
        }


        /// <summary>
        /// Valida si el nivel de acceso del usuario puede generar la modificación solicitada
        /// </summary>
        /// <param name="usuarioForm"></param>
        /// <param name="auxIndice"></param>
        /// <returns></returns>
        private bool ValidarAccesoModificacion(Usuario usuarioForm, int auxIndice)
        {
            if ((auxIndice != -1 && PetShop.usuarios[auxIndice].GetType() == typeof(Administrador) && usuarioForm.GetType() == typeof(SuperUsuario))
                || (auxIndice != -1 && PetShop.usuarios[auxIndice].GetType() == typeof(Empleado) && usuarioForm.GetType() == typeof(Administrador)))
            {
                return true;
            }
            return false;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                txtNombre.ForeColor = Color.White;
            }
            else
            {
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtCuil_Click(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                txtCuil.ForeColor = Color.White;
            }
            else
            {
                txtCuil.ForeColor = Color.Black;
            }
        }

        private void txtAlias_Click(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                txtAlias.ForeColor = Color.White;
            }
            else
            {
                txtAlias.ForeColor = Color.Black;
            }
        }
    }
}
