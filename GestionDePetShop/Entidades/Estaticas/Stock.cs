using System.Collections.Generic;

namespace Entidades.Estaticas
{
    public static class Stock
    {

        public static Dictionary<string, Producto> stockExistente;

        static Stock()
        {
            stockExistente = new Dictionary<string, Producto>();
        }


        public static int CantidadProductosComercializados 
        {
            get
            {
                return stockExistente.Count;
            }
        }
        public static string ObtenerKey(string dato)
        {
            string auxKey = string.Empty;

            foreach (Producto p in Stock.stockExistente.Values)
            {
                if (p.Nombre.ToUpper() == dato.ToUpper() || p.Codigo.ToUpper() == dato.ToUpper() || p.Marca.ToUpper() == dato.ToUpper())
                {
                    return p.Codigo;
                }
            }
            return auxKey;
        }

        public static Producto BuscarProductoPorKey(string key)
        {
            Producto auxProducto = null;

            foreach (string k in Stock.stockExistente.Keys)
            {
                if (k == key)
                {
                    return Stock.stockExistente[key];
                }
            }
            return auxProducto;

        }

        public static bool BorrarProducto(string key)
        {

            foreach (string k in Stock.stockExistente.Keys)
            {
                if (k == key)
                {
                    stockExistente.Remove(key);
                    return true;
                }
            }
            return false;

        }
    }
}
