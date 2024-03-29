﻿using System;
using System.Windows.Forms;

using Entidades.Usuarios;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormControles : FrmBase
    {
        private Usuario usuarioForm;
        public FormControles()
        {
            InitializeComponent();
        }
        public FormControles(Usuario usuario, CheckState estado) : this()
        {
            usuarioForm = usuario;
            chkNocturno.CheckState = estado;
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                BotonOscuro(btnModificarPetShop, btnInformeVentas, btnVender);
                BotonOscuro(btnAdministrarAdmin, btnAdministrarEmpleado, btnAdministrarCliente);
                BotonOscuro(btnAdministrarProducto);
            }
            else
            {
                BotonClaro(btnModificarPetShop, btnInformeVentas, btnVender);
                BotonClaro(btnAdministrarAdmin, btnAdministrarEmpleado, btnAdministrarCliente);
                BotonClaro(btnAdministrarProducto);
            }
        }

        private void FormControles_Load(object sender, EventArgs e)
        {

            if (usuarioForm is SuperUsuario)
            {
                BotonesSuperUsuario();
            }
            else if (usuarioForm is Administrador)
            {
                BotonesAdministrador();
            }
            else
            {
                BotonesEmpleado();
            }
        }

        private void BotonesSuperUsuario()
        {
            btnModificarPetShop.Enabled = true;
            btnInformeVentas.Enabled = false;
            btnVender.Enabled = false;
            btnAdministrarAdmin.Enabled = true;
            btnAdministrarEmpleado.Enabled = false;
            btnAdministrarProducto.Enabled = false;
            btnAdministrarCliente.Enabled = false;
        }
        private void BotonesAdministrador()
        {
            btnModificarPetShop.Enabled = false;
            btnInformeVentas.Enabled = true;
            btnVender.Enabled = true;
            btnAdministrarAdmin.Enabled = false;
            btnAdministrarEmpleado.Enabled = true;
            btnAdministrarProducto.Enabled = true;
            btnAdministrarCliente.Enabled = true;
        }
        private void BotonesEmpleado()
        {
            btnModificarPetShop.Enabled = false;
            btnInformeVentas.Enabled = false;
            btnVender.Enabled = true;
            btnAdministrarAdmin.Enabled = false;
            btnAdministrarEmpleado.Enabled = false;
            btnAdministrarProducto.Enabled = true;
            btnAdministrarCliente.Enabled = false;
        }

        private void btnModificarPetShop_Click(object sender, EventArgs e)
        {
            FormModificarPetShop frmModifPetShop = new FormModificarPetShop(chkNocturno.CheckState);
            frmModifPetShop.ShowDialog();
        }

        private void btnInformeVentas_Click(object sender, EventArgs e)
        {
            FormInfoVentas frmInfoVentas = new FormInfoVentas(chkNocturno.CheckState);
            frmInfoVentas.ShowDialog();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta= new FormVenta(chkNocturno.CheckState);
            frmVenta.ShowDialog();
        }

        private void btnAdministrarAdmin_Click(object sender, EventArgs e)
        {
            FormABMUsuario frmAdmin = new FormABMUsuario(usuarioForm,chkNocturno.CheckState);
            frmAdmin.ShowDialog();
        }

        private void btnAdministrarEmpleado_Click(object sender, EventArgs e)
        {
            FormABMUsuario frmEmpleado = new FormABMUsuario(usuarioForm, chkNocturno.CheckState);
            frmEmpleado.ShowDialog();
        }

        private void btnAdministrarProducto_Click(object sender, EventArgs e)
        {
            FormABMProducto frmABMProducto = new FormABMProducto(chkNocturno.CheckState);
            frmABMProducto.ShowDialog();
        }

        private void btnAdministrarCliente_Click(object sender, EventArgs e)
        {
            FormABMCliente frmCliente = new FormABMCliente(chkNocturno.CheckState);
            frmCliente.ShowDialog();
        }
    }
}
