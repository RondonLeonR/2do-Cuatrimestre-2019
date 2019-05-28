using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondonLeon.Rodolfo._2A
{
    public class Comerciante
    {
        private string apellido;
        private string nombre;

        public Comerciante(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        public static implicit operator string(Comerciante a)
        {
            return a.nombre + " " + a.apellido;
        }

        public static bool operator ==(Comerciante a, Comerciante b)
        {
            bool retorno = false;
            if(a.nombre == b.nombre && a.apellido == b.apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a == b);
        }
    }
}
