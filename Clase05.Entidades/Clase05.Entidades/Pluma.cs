using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta = new Tinta();
        private int _Cantidad;

        public Pluma() : this("Sin marca",null,0)
        {
        }

        public Pluma(string a) : this(a,null,0)
        {
        }

        public Pluma(string a, Tinta b) : this(a,b,0)
        {
        }

        public Pluma(string a, Tinta b, int c)
        {
            _marca = a;
            _tinta = b;
            _Cantidad = c;
        }

        private string Mostrar()
        {
            return this._marca + " - " + Tinta.Mostrar(this._tinta) + " - " + this._Cantidad.ToString();
        }

        //puede usarse explicit o implicit
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }


        //static public string Mostrar(Pluma tipoPluma)
        //{
        //    return tipoPluma.Mostrar();
        //}

        /*Sobrecarga de operadores*/

        public static bool operator ==(Pluma p1, Tinta t2)
        {
            return p1._tinta == t2;
        }

        public static bool operator != (Pluma p1, Tinta t2)
        {
            return !(p1 == t2);
        }

        public static Pluma operator +(Pluma p1, Tinta t1)
        {
            if(p1._tinta == t1 && p1._Cantidad < 100)
            {
                p1._Cantidad += 10;
            }
            return p1;
        }


    }
}
