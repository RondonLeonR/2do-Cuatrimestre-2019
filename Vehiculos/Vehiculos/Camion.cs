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

        public Camion(string a,Byte b,EMarca c, double d) : base(a,b,c)
        {
            this._tara = d;
        }

        public string MostrarCamion()
        {
            string retorno = Mostrar() + " - " + this._tara.ToString();
            return retorno;
        }
    }
}
