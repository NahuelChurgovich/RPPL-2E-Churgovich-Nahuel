using System;

namespace Entidades
{
    public sealed class Cliente
    {

        #region Atributos

        private string nombre;
        private double dni;
        private double telefono;
        private string direccion;
        private float saldo;

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

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public double Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public double Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        public float Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }


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
            float saldo = random.Next(-200, 1501);
            return saldo;
        }


        #endregion

    }
}
