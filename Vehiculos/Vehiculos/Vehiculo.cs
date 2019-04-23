using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected Byte _cantRuedas;
        protected string _patente;
        //protected double _precio;
        public string Patente
        {
            get { return this._patente; }
        }

        /******/
        public abstract double Precio
        {
            get;
            set;
        }

        protected EMarca _marca;
        public EMarca Marca
        {
            get { return this._marca; }
        }

        public override string ToString()
        {
            return this.Patente + " - " + this.Marca.ToString() + " - " + this._cantRuedas.ToString();
        }

        //protected string Mostrar()
        //{
        //    return this.Patente + " - " + this.Marca.ToString() + " - " + this._cantRuedas.ToString();
        //}


        /*Dentro de las clases abstract no se definen los metodos, solo poseen */
        public abstract double CalcularPrecioConIVA();

        public Vehiculo(string cadena, Byte cant, EMarca marca)
        {
            this._patente = cadena;
            this._cantRuedas = cant;
            this._marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool a = false;
            if(v1.Patente == v2.Patente && v1.Marca == v2.Marca)
            {
                a = true;
            }
            return a;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
