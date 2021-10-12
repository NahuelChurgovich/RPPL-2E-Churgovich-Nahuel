using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormABMUsuario : FrmBase
    {
        public FormABMUsuario()
        {
            InitializeComponent();
        }

        public FormABMUsuario(CheckState estado) : this()
        {
          chkNocturno.CheckState = estado;
        }

        private void FormABMUsuario_Load(object sender, EventArgs e)
        {

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
    }
}
