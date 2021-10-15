﻿using System;
using System.Drawing;
using System.Windows.Forms;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormABMProducto : FrmBase
    {
        public FormABMProducto()
        {
            InitializeComponent();
        }

        public FormABMProducto(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void FormABMProducto_Load(object sender, EventArgs e)
        {

        }



        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarProducto, txtNombre, txtCodigo, txtMarca);
                CajaTextoOscuro(txtCosto, txtMargen, txtPrecio, txtDescripcion);
                                BotonOscuro(btnBuscarProducto, btnAgregar, btnModificar);
                BotonOscuro(btnBorrar);
                                cmbTipo.BackColor = Color.FromArgb(64, 64, 64);
                nudCant.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                CajaTextoClaro(txtBuscarProducto, txtNombre, txtCodigo, txtMarca);
                CajaTextoClaro(txtCosto, txtMargen, txtPrecio, txtDescripcion);
                BotonClaro(btnBuscarProducto, btnAgregar, btnModificar);
                BotonClaro(btnBorrar);
                cmbTipo.BackColor = Color.RoyalBlue;
                nudCant.BackColor = Color.RoyalBlue;
                            }
        }
    }
}
