using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios.Generales
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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
            //SoundPlayer cancion = new SoundPlayer(Application.StartupPath + @"\sonidos\DuranDuran-WhatHappensTomorrow.wav");
            //cancion.Play();
            //PONER EL MEGAFONO Y AVERIGUAR COMO MANEJAR EL VOLUMEN DE REPRODUCCION
        }

        protected virtual void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                this.BackColor = Color.FromArgb(64,64,64);
                lblTema.Text = "Claro";
                lblTema.ForeColor = Color.White;
                btnSalir.BackgroundImage = Properties.Resources.boton2dark;
                btnSalir.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.RoyalBlue;
                lblTema.Text = "Oscuro";
                lblTema.ForeColor = Color.Black;
                btnSalir.BackgroundImage = Properties.Resources.boton2;
                btnSalir.ForeColor = Color.Black;
            }
        }
    }
}
