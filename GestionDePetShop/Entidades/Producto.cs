namespace Entidades.Estaticas
{
    public class Producto
    {
        #region Atributos

        private string nombre;
        private string codigo;
        private string marca;
        private double costo;
        private double margen;
        private double precio;
        private int cantidad;
        private string descripcion;
        private EProducto tipo;



        #endregion

        #region Constructor

        public Producto(string nombre, string codigo, string marca, double costo, double margen, int cantidad, string descripcion, EProducto tipo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.margen = margen;
            this.precio = Precio;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.tipo = tipo;
        }
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { this.marca = value; }
        }
        public double Costo
        {
            get { return costo; }
            set { this.costo = value; }
        }
        public double Margen
        {
            get { return margen; }
            set { this.margen = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { this.precio = this.costo * this.margen; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }

        }
        public EProducto Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }

        }
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
