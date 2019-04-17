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

        public Auto(string a, Byte b, EMarca c, int d) : base(a, b, c)
        {
            this._cantidadAsientos = d;
        }

        public string MostrarAuto()
        {
            string retorno = base.Mostrar() + " - " + this._cantidadAsientos.ToString();
            return retorno;
        }
    }
}
