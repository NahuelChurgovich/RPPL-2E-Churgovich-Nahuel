using System;
using System.Drawing;
using System.Windows.Forms;

using Entidades;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormABMCliente : FrmBase
    {
        public FormABMCliente()
        {
            InitializeComponent();
        }

        public FormABMCliente(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void FormABMCliente_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = PetShop.clientes;
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarCliente, txtSaldo);
                CajaTextoOscuro(txtNombre, txtDni, txtTelefono, txtDireccion);
                BotonOscuro(btnBuscarCliente, btnAgregar, btnModificar);
                BotonOscuro(btnBorrar);
                dgvDatos.BackgroundColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                CajaTextoClaro(txtBuscarCliente, txtSaldo);
                CajaTextoClaro(txtNombre, txtDni, txtTelefono, txtDireccion);
                BotonClaro(btnBuscarCliente, btnAgregar, btnModificar);
                BotonClaro(btnBorrar);
                dgvDatos.BackgroundColor = Color.RoyalBlue;

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (PetShop.BuscarCliente(txtBuscarCliente.Text) != -1)
            {
                int auxIndice = PetShop.BuscarCliente(txtBuscarCliente.Text);

                txtNombre.Text = PetShop.clientes[auxIndice].Nombre;
                txtDni.Text = PetShop.clientes[auxIndice].Dni.ToString();
                txtTelefono.Text = PetShop.clientes[auxIndice].Telefono.ToString();
                txtDireccion.Text = PetShop.clientes[auxIndice].Direccion;
            }
            else
            {
                VaciarTextBox();
                MessageBox.Show("El cliente no se encontró", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int auxIndice = PetShop.BuscarCliente(txtBuscarCliente.Text);

            if (MessageBox.Show("¿Seguro que desea borrar este cliente?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                if (PetShop.BorrarCliente(auxIndice))
                {
                    VaciarTextBox();
                    MessageBox.Show("El cliente se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int auxIndice = PetShop.BuscarCliente(txtBuscarCliente.Text);

            if (txtNombre.Text != PetShop.clientes[auxIndice].Nombre
             || txtDni.Text != PetShop.clientes[auxIndice].Dni.ToString()
             || txtTelefono.Text != PetShop.clientes[auxIndice].Telefono.ToString()
             || txtDireccion.Text != PetShop.clientes[auxIndice].Direccion)
            {
                PetShop.clientes[auxIndice].Nombre = txtNombre.Text;
                if (long.TryParse(txtDni.Text, out long dniCorrecto))
                {
                    PetShop.clientes[auxIndice].Dni = dniCorrecto;
                }
                if (long.TryParse(txtTelefono.Text, out long telefonoCorrecto))
                {
                    PetShop.clientes[auxIndice].Telefono = telefonoCorrecto;
                }
                PetShop.clientes[auxIndice].Direccion = txtDireccion.Text;

                MessageBox.Show("Datos modificados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarTextBox();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha modificado ningún dato", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int auxIndice = PetShop.BuscarCliente(txtNombre.Text, txtDni.Text);
            if (auxIndice == -1)
            {
                if (PetShop.clientes[auxIndice].Dni.ToString() == txtDni.Text)
                {
                    txtDni.Text = $"{txtDni.Text}... Ya existe";
                    txtDni.ForeColor = Color.Red;
                }
                else if (PetShop.clientes[auxIndice].Nombre == txtNombre.Text)
                {
                    txtNombre.Text = $"{txtNombre.Text}... Ya existe";
                    txtNombre.ForeColor = Color.Red;
                }
            }
            else
            {
                int contador = PetShop.CantidadClientes;
                if (long.TryParse(txtDni.Text, out long auxDni) && double.TryParse(txtDni.Text, out double auxTel))
                {
                    Cliente nuevoCliente = new Cliente(txtNombre.Text, auxDni, auxTel, txtDireccion.Text);
                    PetShop.clientes.Add(nuevoCliente);
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema el cliente no se creó", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                }
                if (contador < PetShop.CantidadClientes)
                {

                    MessageBox.Show("El usuario se agrego con éxito", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    VaciarTextBox();
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
            this.txtDni.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtBuscarCliente.Text = string.Empty;
            this.txtSaldo.Text = string.Empty;
        }


    }
}
