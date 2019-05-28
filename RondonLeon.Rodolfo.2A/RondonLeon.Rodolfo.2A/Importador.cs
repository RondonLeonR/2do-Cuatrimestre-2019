using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondonLeon.Rodolfo._2A
{
    public class Importador : Comercio
    {
        public EPaises paisOrigen;


        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen ) : base(nombreComercio,comerciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }

        public string Mostrar()
        {
            return ((Comercio)this) + "\nPais: " + this.paisOrigen.ToString() + "\n";
        }


        public static bool operator ==(Importador a, Importador b)
        {
            bool retorno = false;
            if((Comercio)a == (Comercio)b && a.paisOrigen == b.paisOrigen)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }

        public static implicit operator double(Importador m)
        {
            return m._precioAlquiler;
        }
    }
}
