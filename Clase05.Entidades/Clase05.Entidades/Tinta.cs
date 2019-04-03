using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Tinta
    {
       
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor a) : this(a,ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor a, ETipoTinta b) 
        {
            this._color = a;
            this._tipoTinta = b;
        }


        private string Mostrar()
        {
            return this._color.ToString() + " - " + this._tipoTinta.ToString();
        }

        static public string Mostrar(Tinta tipoTinta)
        {
            return tipoTinta.Mostrar();
        }

   
        /*Sobrecarga de OPERADORES*/

        /*Sobrecarga del operador ==*/
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            Boolean rta = false;
            if(t1._color == t2._color && t1._tipoTinta == t2._tipoTinta)
            {
                rta = true;
            }

            return rta;
        }
        /*Sobrecarga del opuesto al ==*/
        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1==t2);
        }
    }

    
    
}
