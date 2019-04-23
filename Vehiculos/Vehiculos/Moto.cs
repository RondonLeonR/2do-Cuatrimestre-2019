using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public override double Precio
        {
            get ;
            set ;
        }

        public Moto(string a, Byte b, EMarca c, float d, double precio) : base(a, b, c)
        {
            this._cilindrada = d;
            this.Precio = precio;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this._cilindrada.ToString();
        }

        public override double CalcularPrecioConIVA()
        {
            double retorno;
            retorno = this.Precio + ((this.Precio * 21) / 100);
            return retorno;
        }

        //public string MostrarMoto()
        //{
        //    string retorno = base.Mostrar() + " - " + this._cilindrada.ToString();
        //    return retorno;
        //}
    }
}
