namespace Entidades.Estaticas
{
    public sealed class Productos
    {
        #region Atributos

        private string nombre;
        private string codigo;
        private string marca;
        private double costo;
        private float margen;
        private double precio;
        private int cantidad;
        private string descripcion;
        private EProducto tipo;

        #endregion




        #region Enumerado
        public enum EProducto
        {
            Alimentos,
            Camas,
            Farmacia,
            Higiene,
            Juguetes
        }
        #endregion


    }
}
