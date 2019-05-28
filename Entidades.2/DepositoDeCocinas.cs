using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades._2
{
    public class DepositoDeCocinas
    {
        private int _capacidad;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidad = capacidad;
            this._lista = new List<Cocina>(this._capacidad);
        }

        private int GetIndice(Cocina c)
        {
            int retorno = -1;
            int i = 0;
            foreach(Cocina a in this._lista)
            {
                if(a == c)
                {
                    retorno = i;
                }
                i++;
            }
            return retorno;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidad)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
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

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno = "Capacidad de Cocinas: " + this._capacidad + "\n";
            retorno += "Deposito De Cocinas\n";
            foreach(Cocina c in this._lista)
            {
                retorno += c + "\n";
            }
            return retorno;
        }
    }
}
