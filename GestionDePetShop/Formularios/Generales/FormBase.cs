using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Formularios.Generales
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            SoundPlayer cancion = new SoundPlayer(Application.StartupPath + @"\sonidos\Abucheo.wav");
            cancion.Play();
            this.Close();
                      
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                lblTema.Text = "Claro";
                BotonOscuro(btnSalir);
            }
            else
            {
                this.BackColor = Color.RoyalBlue;
                lblTema.Text = "Oscuro";
                BotonClaro(btnSalir);
            }
        }

        protected virtual void BotonClaro(Button boton)
        {
            boton.BackgroundImage = Properties.Resources.boton2;
            boton.ForeColor = Color.Black;
            boton.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
        }
        protected virtual void BotonOscuro(Button boton)
        {
            boton.BackgroundImage = Properties.Resources.boton2dark;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        }

        protected virtual void BotonClaro(Button boton, Button boton2, Button boton3)
        {
            boton.BackgroundImage = Properties.Resources.boton2;
            boton.ForeColor = Color.Black;
            boton.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            boton2.BackgroundImage = Properties.Resources.boton2;
            boton2.ForeColor = Color.Black;
            boton2.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton2.FlatAppearance.BorderSize = 1;
            boton2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            boton3.BackgroundImage = Properties.Resources.boton2;
            boton3.ForeColor = Color.Black;
            boton3.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton3.FlatAppearance.BorderSize = 1;
            boton3.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton3.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
        }
        protected virtual void BotonOscuro(Button boton, Button boton2, Button boton3)
        {
            boton.BackgroundImage = Properties.Resources.boton2dark;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            boton2.BackgroundImage = Properties.Resources.boton2dark;
            boton2.ForeColor = Color.White;
            boton2.FlatStyle = FlatStyle.Flat;
            boton2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton2.FlatAppearance.BorderSize = 1;
            boton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            boton3.BackgroundImage = Properties.Resources.boton2dark;
            boton3.ForeColor = Color.White;
            boton3.FlatStyle = FlatStyle.Flat;
            boton3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton3.FlatAppearance.BorderSize = 1;
            boton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        }

        protected virtual void BotonClaro(Button boton, Button boton2)
        {
            boton.BackgroundImage = Properties.Resources.boton2;
            boton.ForeColor = Color.Black;
            boton.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            boton2.BackgroundImage = Properties.Resources.boton2;
            boton2.ForeColor = Color.Black;
            boton2.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton2.FlatAppearance.BorderSize = 1;
            boton2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            boton2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
        }
        protected virtual void BotonOscuro(Button boton, Button boton2)
        {
            boton.BackgroundImage = Properties.Resources.boton2dark;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            boton2.BackgroundImage = Properties.Resources.boton2dark;
            boton2.ForeColor = Color.White;
            boton2.FlatStyle = FlatStyle.Flat;
            boton2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            boton2.FlatAppearance.BorderSize = 1;
            boton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            boton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        }
        protected virtual void CajaTextoClaro(TextBox caja)
        {
            caja.BackColor = Color.CornflowerBlue;
            caja.ForeColor = Color.Black;
        }
        protected virtual void CajaTextoClaro(TextBox caja, TextBox caja2)
        {
            caja.BackColor = Color.CornflowerBlue;
            caja2.BackColor = Color.CornflowerBlue;
            caja.ForeColor = Color.Black;
            caja2.ForeColor = Color.Black;
        }
        protected virtual void CajaTextoClaro(TextBox caja, TextBox caja2, TextBox caja3)
        {
            caja.BackColor = Color.CornflowerBlue;
            caja2.BackColor = Color.CornflowerBlue;
            caja3.BackColor = Color.CornflowerBlue;
            caja.ForeColor = Color.Black;
            caja2.ForeColor = Color.Black;
            caja3.ForeColor = Color.Black;
        }
        protected virtual void CajaTextoClaro(TextBox caja, TextBox caja2, TextBox caja3, TextBox caja4)
        {
            caja.BackColor = Color.CornflowerBlue;
            caja2.BackColor = Color.CornflowerBlue;
            caja3.BackColor = Color.CornflowerBlue;
            caja4.BackColor = Color.CornflowerBlue;
            caja.ForeColor = Color.Black;
            caja2.ForeColor = Color.Black;
            caja3.ForeColor = Color.Black;
            caja4.ForeColor = Color.Black;
        }
        protected virtual void CajaTextoOscuro(TextBox caja)
        {
            caja.BackColor = Color.DarkGray;
            caja.ForeColor = Color.WhiteSmoke;
        }
        protected virtual void CajaTextoOscuro(TextBox caja, TextBox caja2)
        {
            caja.BackColor = Color.DarkGray;
            caja2.BackColor = Color.DarkGray;
            caja.ForeColor = Color.WhiteSmoke;
            caja2.ForeColor = Color.WhiteSmoke;
        }
        protected virtual void CajaTextoOscuro(TextBox caja, TextBox caja2, TextBox caja3)
        {
            caja.BackColor = Color.DarkGray;
            caja2.BackColor = Color.DarkGray;
            caja3.BackColor = Color.DarkGray;
            caja.ForeColor = Color.WhiteSmoke;
            caja2.ForeColor = Color.WhiteSmoke;
            caja3.ForeColor = Color.WhiteSmoke;
        }
        protected virtual void CajaTextoOscuro(TextBox caja, TextBox caja2, TextBox caja3, TextBox caja4)
        {
            caja.BackColor = Color.DarkGray;
            caja2.BackColor = Color.DarkGray;
            caja3.BackColor = Color.DarkGray;
            caja4.BackColor = Color.DarkGray;
            caja.ForeColor = Color.WhiteSmoke;
            caja2.ForeColor = Color.WhiteSmoke;
            caja3.ForeColor = Color.WhiteSmoke;
            caja4.ForeColor = Color.WhiteSmoke;
        }


    }
}
