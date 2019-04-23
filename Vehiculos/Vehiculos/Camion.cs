using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected double _tara;

        public override double Precio
        {
            get ;
            set ;
        }

        public Camion(string a,Byte b,EMarca c, double d,double precio) : base(a,b,c)
        {
            this._tara = d;
            this.Precio = precio;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this._tara.ToString();
        }

        public override double CalcularPrecioConIVA()
        {
            double retorno;
            retorno =this.Precio + ((this.Precio * 21) / 100);
            return retorno;
        }

        ////public string MostrarCamion()
        ////{
        ////    string retorno = Mostrar() + " - " + this._tara.ToString();
        ////    return retorno;
        ////}
    }
}
