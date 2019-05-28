using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades._28._05
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Auto && ((Auto)obj) == this)
            {
                retorno = (Auto)obj == this;
            }
            return retorno;
        }

        public static bool operator ==(Auto a,Auto b)
        {
            bool retorno = false;
            if(a._color == b._color && a._marca == b._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Auto a,Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Color: " + this._color + " - Marca: " + this._marca + "\n";
        }

    }
}
