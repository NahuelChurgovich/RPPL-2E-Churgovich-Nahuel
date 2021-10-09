using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class SuperUsuario : Administrador
    {
        #region Atributos
        private static EUsuarios tipo;
        #endregion

        #region Constructor
        public SuperUsuario(string alias, string nombre, long cuil, string contrasenia)
            : base(alias, nombre, cuil, contrasenia)
        {
            tipo = EUsuarios.SuperUsuario;
        }

        #endregion

        #region Propiedades

        #endregion


        protected override EUsuarios Tipo
        {
            get
            {
                return tipo;
            }
        }

        public override string TipoUsuario()
        {
            return this.GetType().ToString();
        }
    }
}
