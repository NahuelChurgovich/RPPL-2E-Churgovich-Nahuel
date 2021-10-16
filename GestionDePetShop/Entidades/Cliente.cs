using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cliente
    {

        #region Atributos

        private string nombre;
        private double dni;
        private double telefono;
        private string direccion;
        private  float saldo;

        #endregion


        #region Constructores

        public Cliente(string nombre, double dni, double telefono, string direccion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.saldo = SaldoRandom();
        }


        #endregion


        #region Propiedades

        //public string Nombre { get; set; }
        //public double Dni { get; set; }
        //public double Telefono { get; set; }
        //public string Direccion { get; set; }
        //public float Saldo
        //{
        //    get
        //    {
        //        return saldo;
        //    }
        //    set
        //    {
        //        saldo = value;
        //    }
        //}

        #endregion


        #region Métodos
        public string Mostrar()
        {
            //HACER ESTE METODO
            return "devolver datos del cliente";
        }

        private float SaldoRandom()
        {
            Random random = new Random();
            float saldo = random.Next(-200,1501) ;
            return saldo;
        }


        #endregion

    }
}
