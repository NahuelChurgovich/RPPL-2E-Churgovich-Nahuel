using System;
using System.Drawing;
using System.Windows.Forms;

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

        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarCliente,txtSaldo)                    ;
                CajaTextoOscuro(txtNombre, txtDni, txtTelefono, txtDireccion);
                BotonOscuro(btnBuscarUsuario, btnAgregar, btnModificar);
                BotonOscuro(btnBorrar);
                dgvDatos.BackgroundColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                CajaTextoClaro(txtBuscarCliente, txtSaldo);
                CajaTextoClaro(txtNombre, txtDni, txtTelefono, txtDireccion);
                BotonClaro(btnBuscarUsuario, btnAgregar, btnModificar);
                BotonClaro(btnBorrar);
                dgvDatos.BackgroundColor = Color.RoyalBlue;

            }
        }
    }
}
