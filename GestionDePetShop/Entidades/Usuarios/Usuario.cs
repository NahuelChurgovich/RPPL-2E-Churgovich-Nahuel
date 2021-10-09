using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Estaticas;

namespace Entidades.Usuarios
{
    public abstract class Usuario
    {

        #region Atributos

        private string alias;
        private string nombre;
        private long cuil;
        private string contrasenia;

        #endregion

        #region Constructores

        protected Usuario(string alias, string nombre, long cuil, string contrasenia)
        {
            this.alias = alias;
            this.nombre = nombre;
            this.cuil = cuil;
            this.contrasenia = contrasenia;
        }

        #endregion

        #region Propiedades

        public string Alias
        {
            get
            {
                return alias;
            }
            set
            {
                alias = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (Validaciones.ValidarNombre(value))
                {
                    nombre = value;
                }
            }
        }
        public long Cuil
        {
            get
            {
                return cuil;
            }
            set
            {
                if (Validaciones.ValidarCuil(value))
                {
                    cuil = value;
                }

            }
        }
        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }
            set
            {
                contrasenia = value;
            }
        }
        protected abstract EUsuarios Tipo { get; }


        #endregion

        #region Enumerado

        public enum EUsuarios
        {
            Administrador,
            Empleado,
            SuperUsuario
        }

        #endregion


        #region Métodos

        public virtual string Mostrar()
        {
            return (string)this;
        }
        public virtual string TipoUsuario()
        {
            return this.GetType().ToString();
        }
        #endregion




        #region Operadores
        public static explicit operator string(Usuario usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CUIL: {0} - ", usuario.cuil.ToString());
            sb.AppendFormat("Nombre: {0} - ", usuario.nombre);
            sb.AppendFormat("Alias: {0} - ", usuario.alias);
            sb.AppendFormat("Contraseña: {0}", usuario.contrasenia);
            sb.AppendLine("\n");

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas



        #endregion
    }
}
