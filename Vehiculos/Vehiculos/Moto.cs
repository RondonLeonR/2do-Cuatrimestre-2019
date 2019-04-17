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

        public Moto(string a, Byte b, EMarca c, float d) : base(a, b, c)
        {
            this._cilindrada = d;
        }
    
        public string MostrarMoto()
        {
            string retorno = base.Mostrar() + " - " + this._cilindrada.ToString();
            return retorno;
        }
    }
}
