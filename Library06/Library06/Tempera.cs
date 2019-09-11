using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        public sbyte _cantidad;

        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }
        public string Marca { get { return this._marca; } set { this._marca = value; } }

        public Tempera(ConsoleColor color,string marca,sbyte cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._color.ToString() + " - " + this._marca + " - " + this._cantidad.ToString() ;
        }

        static public string Mostrar(Tempera tipoTempera)
        {
            string ret = "";
            if(tipoTempera != null)
            {
                ret = tipoTempera.Mostrar();
            }
            return ret;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            Boolean rta = false;
            if(object.Equals(t1,null) && object.Equals(t2,null))
            {
                rta = true;
                if(t1 != null && t2 != null)
                {
                    if (t1._marca == t2._marca && t1._color == t2._color)
                    {
                        rta = true;
                    }
                }
                
            }
            
            return rta;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t1,sbyte b1)
        {
            if(t1._cantidad <= 100 )
            {
                t1._cantidad += b1;
            }
            return t1;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if(t1==t2)
            {
                t1 = t1 + t2._cantidad;
            }
            return t1;
        }

        public static implicit operator sbyte(Tempera t1)
        {
            return t1._cantidad;
        }


    }
}
