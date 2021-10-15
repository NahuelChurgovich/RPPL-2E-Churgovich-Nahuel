using System.Windows.Forms;

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
    }
}
