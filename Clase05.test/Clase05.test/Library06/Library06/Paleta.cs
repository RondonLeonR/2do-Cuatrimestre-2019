using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library06
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantidadMaxima;

        private Paleta() : this(5)
        {
          
        }

        private Paleta(int a) 
        {
            this._temperas = new Tempera[a];
            this._cantidadMaxima = a;
        }

        public static implicit operator Paleta(int cant)
        {
            Paleta paletas = new Paleta(cant);
            return paletas;
        }

        public string Mostrar()
        {
            string texto = "";

            foreach(Tempera t in this._temperas)
            {
                texto += Tempera.Mostrar(t);
                return texto; 
            }

            return "Cant" + this._cantidadMaxima.ToString() + "Temperas" + texto.ToString();
        }

        public static explicit operator string(Paleta p1)
        {
            return p1._temperas.ToString();
        }

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            Boolean retorno = false;
            foreach(Tempera t in p1._temperas)
            {
                if(t == t1)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        public int ObtenerIndice()
        {
            int ret = -1;
            foreach(Tempera t in this._temperas)
            { 
                if (t==null)
                {
                    ret = t;
                }
            }
            return ret;
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            int indice;
            if (!(p1 == t1))
            {
                indice = ObtenerIndice();
                p1._temperas[indice] = t1;
            }
            return p1;
        }
    }
}
