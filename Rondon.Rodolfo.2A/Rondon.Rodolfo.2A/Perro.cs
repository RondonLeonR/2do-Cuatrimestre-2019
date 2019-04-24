using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondon.Rodolfo._2A
{
    class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : base(nombre,raza)
        {
            this._edad = 0;
            this._esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool alfa) : this(nombre,raza)
        {
            this._edad = edad;
            this._esAlfa = alfa;
        }

        protected override string Ficha()
        {
            string retorno = "";

            if(this._esAlfa is true)
            {
                retorno = base.DatosCompletos() + ", alfa de la manada, edad " + this._edad;   
            }
            else if(this._esAlfa is false)
            {
                retorno = base.DatosCompletos() + ", edad " + this._edad;
            }

            return retorno;
        }

        #region SobreCarga De Operadores

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;

            if(string.Compare(p1.Nombre,p2.Nombre) == 0)
            {
                if(string.Compare(p1.Raza,p2.Raza) == 0)
                {
                    if(p1._edad == p2._edad)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro P)
        {
            return P._edad;
        }

        #endregion

        #region SobreEscribir

        public override string ToString()
        {
            return this.Ficha();
        }

        /***/
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                retorno = (Perro)obj == this;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        #endregion

    }
}
