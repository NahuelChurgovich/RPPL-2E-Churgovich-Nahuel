using System;

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
        public FormControles(Usuario usuario) : this()
        {
            usuarioForm = usuario;
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
    }
}
