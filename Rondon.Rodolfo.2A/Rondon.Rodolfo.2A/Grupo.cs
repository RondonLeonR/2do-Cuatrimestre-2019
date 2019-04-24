using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondon.Rodolfo._2A
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;



        #region Constructores


        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            _tipo = tipo;
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        static Grupo() 
        {
            _tipo = EtipoManada.Única;
        }
       

        #endregion


        #region Propiedades

        public EtipoManada Tipo
        {
            set { _tipo = value; }
        }

        #endregion

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;
            foreach(Mascota item in g._manada)
            {
                if(item == m)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m )
            {
                g._manada.Add(m);
            }
            else if(g == m)
            {
                Console.WriteLine("Ya esta el " + m.ToString() + " en el grupo");
            }

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No esta el " + m.ToString() + "en el grupo");
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            string retor = "Grupo: " + g._nombre + " - Tipo: " + _tipo.ToString() +
                          "\nIntegrantes: " + g._manada.Count.ToString();
            string ret = "\n";
            foreach (Mascota item in g._manada)
            {
                ret += item.ToString();
                ret += "\n";
            }

            retor += ret;

            return retor;
        }
    }
}
