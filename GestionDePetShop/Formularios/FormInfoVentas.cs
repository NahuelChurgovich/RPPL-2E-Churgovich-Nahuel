using System;
using System.Windows.Forms;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormInfoVentas : FrmBase
    {
        public FormInfoVentas()
        {
            InitializeComponent();
        }

        public FormInfoVentas(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarVenta, txtCarrito);
                BotonOscuro(btnBuscarVenta, btnBorrarVenta);
            }
            else
            {
                CajaTextoClaro(txtBuscarVenta, txtCarrito);
                BotonClaro(btnBuscarVenta, btnBorrarVenta);
            }
        }
    }
}
