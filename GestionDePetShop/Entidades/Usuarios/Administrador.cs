using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Entidades.Usuarios.Usuario;

namespace Entidades.Usuarios
{
    public class Administrador : Usuario
    {
        #region Atributos
        private static EUsuarios tipo;
    #endregion

    #region Constructor
    public Administrador(string alias, string nombre, long cuil, string contrasenia)
        : base(alias, nombre, cuil, contrasenia)
    {
        tipo = EUsuarios.Administrador;
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
