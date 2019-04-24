using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondon.Rodolfo._2A
{
    public class Gato : Mascota
    {
        public Gato(string nombre,string raza) : base(nombre,raza)
        {

        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if(string.Compare(g1.Nombre,g2.Nombre) == 0)
            {
                if(string.Compare(g1.Raza,g2.Raza) == 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Gato g1,Gato g2)
        {
            return !(g1 == g2);
        }


        public override string ToString()
        {
            return this.Ficha();
        }

        /**TERMINADO**/
        public override bool Equals(object obj)
        {
            bool retorno;
            if(obj is Gato)
            {
                retorno = (Gato)obj == this;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
