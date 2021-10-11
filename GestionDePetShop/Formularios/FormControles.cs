using System;
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
                BotonOscuro(btnAgregarAdmin, btnModificarAdmin, btnBorrarAdmin);
                BotonOscuro(btnAgregarEmpleado, btnModificarEmpleado, btnBorrarEmpleado);
                BotonOscuro(btnAgregarCliente, btnModificarCliente, btnBorrarCliente);
                BotonOscuro(btnAgregarProducto, btnModificarProducto, btnBorrarProducto);
            }
            else
            {
                BotonClaro(btnModificarPetShop, btnInformeVentas, btnVender);
                BotonClaro(btnAgregarAdmin, btnModificarAdmin, btnBorrarAdmin);
                BotonClaro(btnAgregarEmpleado, btnModificarEmpleado, btnBorrarEmpleado);
                BotonClaro(btnAgregarCliente, btnModificarCliente, btnBorrarCliente);
                BotonClaro(btnAgregarProducto, btnModificarProducto, btnBorrarProducto);
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
            btnAgregarAdmin.Enabled = true;
            btnModificarAdmin.Enabled = true;
            btnBorrarAdmin.Enabled = true;
            btnAgregarEmpleado.Enabled = false;
            btnModificarEmpleado.Enabled = false;
            btnBorrarEmpleado.Enabled = false;
            btnAgregarCliente.Enabled = false;
            btnModificarCliente.Enabled = false;
            btnBorrarCliente.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnBorrarProducto.Enabled = false;
        }
        private void BotonesAdministrador()
        {
            btnModificarPetShop.Enabled = false;
            btnInformeVentas.Enabled = true;
            btnVender.Enabled = true;
            btnAgregarAdmin.Enabled = false;
            btnModificarAdmin.Enabled = false;
            btnBorrarAdmin.Enabled = false;
            btnAgregarEmpleado.Enabled = true;
            btnModificarEmpleado.Enabled = true;
            btnBorrarEmpleado.Enabled = true;
            btnAgregarCliente.Enabled = true;
            btnModificarCliente.Enabled = true;
            btnBorrarCliente.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            btnBorrarProducto.Enabled = true;
        }
        private void BotonesEmpleado()
        {
            btnModificarPetShop.Enabled = false;
            btnInformeVentas.Enabled = false;
            btnVender.Enabled = true;
            btnAgregarAdmin.Enabled = false;
            btnModificarAdmin.Enabled = false;
            btnBorrarAdmin.Enabled = false;
            btnAgregarEmpleado.Enabled = false;
            btnModificarEmpleado.Enabled = false;
            btnBorrarEmpleado.Enabled = false;
            btnAgregarCliente.Enabled = false;
            btnModificarCliente.Enabled = false;
            btnBorrarCliente.Enabled = false;
            btnAgregarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            btnBorrarProducto.Enabled = true;
        }
    }
}
