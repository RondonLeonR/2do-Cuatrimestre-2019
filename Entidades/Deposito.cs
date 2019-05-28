using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        private int GetIndice(T c)
        {
            int retorno = -1;
            int i = 0;
            foreach (T a in this._lista)
            {
                if (a.Equals(c))
                {
                    retorno = i;
                }
                i++;
            }
            return retorno;
        }

        public static bool operator +(Deposito<T> d, T c)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Deposito<T> d, T c)
        {
            bool retorno = false;
            int indice = d.GetIndice(c);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Capacidad Maxima: " + this._capacidadMaxima + "\n";
            retorno += "Deposito \n";
            foreach (T c in this._lista)
            {
                retorno += c + "\n";
            }
            return retorno;
        }
    }
}
