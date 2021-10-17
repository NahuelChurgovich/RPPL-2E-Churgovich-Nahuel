using System.Collections.Generic;
using System.Text;

using Entidades.Estaticas;
using Entidades.Usuarios;

namespace Entidades
{
    public static class PetShop
    {
        #region Atributos

        private static string razonSocial;  //
        private static long cuit;           //ESTOS ATRIBUTOS LOS VOY A USAR PARA EL TICKET
        private static string direccion;    //
        public static List<Cliente> clientes;
        public static List<Usuario> usuarios;
        //private static Queue<Ventas> ventas;
        
        #endregion

        #region Constructor

        static PetShop()
        {
            razonSocial = "Petite Shop";
            cuit = 30748694528;
            direccion = "Alvarez Jonte 744";
            clientes = new List<Cliente>();
            usuarios = new List<Usuario>();
                    }

        #endregion


        #region Propiedades

        public static string RazonSocial
        {
            get
            {
                return razonSocial;
            }
            set
            {
                PetShop.razonSocial = value;
            }
        }
        public static long Cuit
        {
            get
            {
                return cuit;
            }
            set
            {
                if (Validaciones.ValidarCuil(value))
                {
                    PetShop.cuit = value;
                }
            }
        }
        public static string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                PetShop.direccion = value;
            }
        }
        private static List<Cliente> Clientes
        {
            set
            {
                PetShop.clientes = value;
            }
        }

        public static int CantidadUsuarios
        {
            get
            {
                return usuarios.Count;
            }
        }

        public static int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }


        #endregion

        #region Métodos

        public static bool BuscarUsuario(Usuario usuario)
        {
            foreach (Usuario u in PetShop.usuarios)
            {
                if (usuario.Cuil == u.Cuil)
                {
                    return true;
                }
            }
            return false;
        }

        public static int BuscarUsuario(string dato)
        {
            int auxIndex = -1;
            foreach (Usuario u in PetShop.usuarios)
            {
                auxIndex++;
                if (u.Cuil.ToString() == dato || u.Nombre.ToUpper() == dato.ToUpper() || u.Alias.ToUpper() == dato.ToUpper())
                {
                    return auxIndex;
                }
            }
            return -1;
        }

        public static int BuscarUsuario(string txtCuil, string txtNombre, string txtAlias)
        {
            int auxIndex = -1;
            int auxIndexCuil = BuscarUsuario(txtCuil);
            int auxIndexNombre = BuscarUsuario(txtNombre);
            int auxIndexALias = BuscarUsuario(txtAlias);

            if (auxIndexCuil != -1)
            {
                return auxIndexCuil;
            }
            else if (auxIndexNombre != -1)
            {
                return auxIndexNombre;
            }
            else if (auxIndexALias != -1)
            {
                return auxIndexALias;
            }
            return auxIndex;
        }


        public static bool BorrarUsuario(int indice)
        {
            if (usuarios.Remove(usuarios[indice]))
            {
                return true;
            }
            return false;
        }

        public static bool BuscarCliente(Cliente cliente)
        {
            foreach (Cliente c in PetShop.clientes)
            {
                if (cliente.Dni == c.Dni)
                {
                    return true;
                }
            }
            return false;
        }

        public static int BuscarCliente(string dato)
        {
            int auxIndex = -1;
            foreach (Cliente c in PetShop.clientes)
            {
                auxIndex++;
                if (c.Nombre.ToUpper() == dato.ToUpper() || c.Dni.ToString() == dato || c.Telefono.ToString() == dato
                    || c.Direccion.ToString() == dato)
                {
                    return auxIndex;
                }
            }
            return -1;
        }

        public static int BuscarCliente(string txtNombre, string txtDni)
        {
            int auxIndex = -1;
            int auxIndexNombre = BuscarCliente(txtNombre);
            int auxIndexDni = BuscarCliente(txtDni);

            if (auxIndexNombre != -1)
            {
                return auxIndexNombre;
            }
            else if (auxIndexDni != -1)
            {
                return auxIndexDni;
            }
            return auxIndex;
        }

        public static bool BorrarCliente(int indice)
        {
            if (clientes.Remove(clientes[indice]))
            {
                return true;
            }
            return false;
        }

        //public static bool BorrarCliente(Usuario ingresante, Cliente clienteABorrar)
        //{
        //    if (BuscarCliente(clienteABorrar) && (ingresante.Tipo is EUsuarios.Administrador || ingresante.Tipo is EUsuarios.Empleado))
        //    {
        //        clientes.Remove(clienteABorrar);
        //        return true;
        //    }
        //    return false;
        //}



        public static string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razón Social: {0} - CUIT: {1} - Domicilio: {2}", razonSocial, cuit, direccion);

            return sb.ToString();
        }

        #endregion

    }
}
