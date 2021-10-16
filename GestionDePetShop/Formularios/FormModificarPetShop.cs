using System.Windows.Forms;

using Entidades;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormModificarPetShop : FrmBase
    {
        public FormModificarPetShop()
        {
            InitializeComponent();
        }

        public FormModificarPetShop(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void chkNocturno_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtRazonSocial, txtCuit, txtDireccion);
                BotonOscuro(btnModificar);
            }
            else
            {
                CajaTextoClaro(txtRazonSocial, txtCuit, txtDireccion);
                BotonClaro(btnModificar);
            }
        }

        private void FormModificarPetShop_Load(object sender, System.EventArgs e)
        {
            txtRazonSocial.Text = PetShop.RazonSocial;
            txtDireccion.Text = PetShop.Direccion;
            txtCuit.Text = PetShop.Cuit.ToString();
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            Modificar();
        }

        /// <summary>
        /// Hace efectiva la modificación de los datos del pet shop.
        /// </summary>
        private void Modificar()
        {
            if (PetShop.RazonSocial != txtRazonSocial.Text || PetShop.Direccion != txtDireccion.Text ||
               PetShop.Cuit.ToString() != txtCuit.Text)
            {
                PetShop.RazonSocial = txtRazonSocial.Text;
                PetShop.Direccion = txtDireccion.Text;
                if (long.TryParse(txtCuit.Text, out long cuitCorrecto))
                {
                    PetShop.Cuit = cuitCorrecto;
                }
                MessageBox.Show("Datos modificados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha modificado nada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
