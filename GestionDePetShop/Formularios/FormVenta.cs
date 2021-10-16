using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormVenta : FrmBase
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        public FormVenta(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarCliente, txtBuscarProducto, txtCarrito);
                BotonOscuro(btnBuscarCliente, btnBuscarProducto, btnFinalizarCompra);
                btnAgregar.BackgroundImage = Properties.Resources.CarritoDark;
                btnAgregar.ForeColor = Color.White;
                btnAgregar.FlatStyle = FlatStyle.Flat;
                btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                btnAgregar.FlatAppearance.BorderSize = 1;
                btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                btnQuitar.BackgroundImage = Properties.Resources.TachoDark2;
                btnQuitar.ForeColor = Color.White;
                btnQuitar.FlatStyle = FlatStyle.Flat;
                btnQuitar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                btnQuitar.FlatAppearance.BorderSize = 1;
                btnQuitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                btnQuitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                btnTicket.BackgroundImage = Properties.Resources.TXTDark;
                btnTicket.ForeColor = Color.White;
                btnTicket.FlatStyle = FlatStyle.Flat;
                btnTicket.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                btnTicket.FlatAppearance.BorderSize = 1;
                btnTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                btnTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                cmbProducto.BackColor = Color.FromArgb(64, 64, 64);
                cmbProducto.ForeColor = Color.White;
                nudCant.BackColor = Color.FromArgb(64, 64, 64);
                nudCant.ForeColor = Color.White;
            }
            else
            {
                CajaTextoClaro(txtBuscarCliente, txtBuscarProducto, txtCarrito);
                BotonClaro(btnBuscarCliente, btnBuscarProducto, btnFinalizarCompra);
                btnAgregar.BackgroundImage = Properties.Resources.Carrito;
                btnAgregar.ForeColor = Color.Black;
                btnAgregar.FlatAppearance.BorderColor = Color.RoyalBlue;
                btnAgregar.FlatAppearance.BorderSize = 1;
                btnAgregar.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
                btnAgregar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                btnQuitar.BackgroundImage = Properties.Resources.Tacho;
                btnQuitar.ForeColor = Color.Black;
                btnQuitar.FlatAppearance.BorderColor = Color.RoyalBlue;
                btnQuitar.FlatAppearance.BorderSize = 1;
                btnQuitar.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
                btnQuitar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                btnTicket.BackgroundImage = Properties.Resources.TXT;
                btnTicket.ForeColor = Color.Black;
                btnTicket.FlatAppearance.BorderColor = Color.RoyalBlue;
                btnTicket.FlatAppearance.BorderSize = 1;
                btnTicket.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
                btnTicket.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                cmbProducto.BackColor = Color.RoyalBlue;
                cmbProducto.ForeColor = Color.Black;
                nudCant.BackColor = Color.RoyalBlue;
                nudCant.ForeColor = Color.Black;
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            SoundPlayer cancion = new SoundPlayer(Application.StartupPath + @"\sonidos\Aplausos.wav");
            cancion.Play();
        }
    }
}
