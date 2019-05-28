using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades._28._05
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>(this._capacidadMaxima);
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;
            int i = 0;
            foreach(Auto b in this._lista)
            {
                if(b == a)
                {
                    retorno = i;
                    break;
                }
                i++;
            }
            return retorno;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            { 
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Capacidad Maxima: " + this._capacidadMaxima + "\nDeposito De Autos: \n\n";
            foreach(Auto a in this._lista)
            {
                retorno += a.ToString() + " \n"; 
            }
            return retorno;
        }
    }
}
