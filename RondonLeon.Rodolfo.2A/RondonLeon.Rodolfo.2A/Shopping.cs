using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondonLeon.Rodolfo._2A
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        public double PrecioDeExportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Exportador);
            }
        }

        public double PrecioDeImportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Importador);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Ambos);
            }
        }


        //Constructor
        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Shopping s)
        {
            string ret = "Capacidad del Shopping: " + s._capacidad.ToString() + "\n";
            ret += "Total por impor: $" + s.PrecioDeImportadores.ToString() + "\n";
            ret += "Total por expor: $" + s.PrecioDeExportadores.ToString() + "\n";
            ret += "Total de Ambos: $" + s.PrecioTotal.ToString() + "\n";

            ret += "\nListado de Comercios \n";

            foreach (Comercio c in s._comercios)
            {
                if(c is Exportador)
                {
                    ret += ((Exportador)c).Mostrar() + "\n";
                }
                else if(c is Importador)
                {
                    ret += ((Importador)c).Mostrar() + "\n";
                }
            }
            return ret;
        }

        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;
            foreach(Comercio co in s._comercios)
            {
                if(co == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }

        public static Shopping operator +(Shopping s, Comercio c)
        {
            if(s._capacidad > s._comercios.Count)
            {
                if(s != c)
                {
                    s._comercios.Add(c);
                }
                else
                {
                    Console.WriteLine("El Comercio existe en el Shopping\n");
                }
                
            }
            else
            {
                Console.WriteLine("No hay mas lugar");
            }
            return s;
        }

        public static implicit operator Shopping(int capacidad)
        {
            return new Shopping(capacidad);
        }

        private double ObtenerPrecio(EComercio tipo)
        {
            double precioExp = 0;
            double precioImp = 0;
            if(tipo == EComercio.Exportador || tipo == EComercio.Ambos)
            {
                foreach(Comercio c in this._comercios)
                {
                    if(c is Exportador)
                    {
                        precioExp += (Exportador)c;
                    }
                }
            }
            else if(tipo == EComercio.Importador || tipo == EComercio.Ambos)
            {
                foreach(Comercio c in this._comercios)
                {
                    if(c is Importador)
                    {
                        precioImp += (Importador)c;
                    }
                }
            }

            if(tipo == EComercio.Exportador)
            {
                return precioExp;

            }
            else if(tipo == EComercio.Importador)
            {
                return precioImp;
            }
            else
            {
                return precioImp + precioExp;
            }
        }
    }
}
