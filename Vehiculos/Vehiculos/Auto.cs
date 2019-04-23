using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public override double Precio
        {
            get ;
            set ;
        }


        public Auto(string a, Byte b, EMarca c, int d, double precio) : base(a, b, c)
        {
            this._cantidadAsientos = d;
            this.Precio = precio;
            
    }

        public override double CalcularPrecioConIVA()
        {
            double retorno;
            retorno =this.Precio + ((this.Precio * 21) / 100); 
            return retorno;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this._cantidadAsientos.ToString();
        }
        //public string MostrarAuto()
        //{
        //    string retorno = base.Mostrar() + " - " + this._cantidadAsientos.ToString();
        //    return retorno;
        //}
    }
}
