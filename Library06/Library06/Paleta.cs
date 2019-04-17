using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library06
{
    public class Paleta
    {
        
        private int _cantidadMaxima;
        /*Cambio array por lista de Temperas List<Temperas>*/
        private List<Tempera> _temperas;

        public List<Tempera> MisTemperas
        {
            get { return  this._temperas; }
           
        }


        private Paleta() : this(5)
        {
          
        }

        private Paleta(int a) 
        {
            this._cantidadMaxima = a;
            this._temperas = new List<Tempera>(a);
            for (int i = 0; i < this._cantidadMaxima; i++)
            {
                this._temperas.Insert(i, null);
            }
        }

        public static implicit operator Paleta(int cant)
        {           
            return new Paleta(cant);
        }

        public string Mostrar()
        {
            string texto = "";

            foreach(Tempera t in this._temperas)
            {
                if(t != null)
                {
                    texto += Tempera.Mostrar(t);      
                }
               
            }

            return "Cant" + this._cantidadMaxima.ToString() + "Temperas" + texto.ToString();
        }

        public static explicit operator string(Paleta p1)
        {
            return p1.Mostrar();
        }

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            Boolean retorno = false;
            foreach(Tempera t in p1.MisTemperas)
            {
                if(t == t1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        private int ObtenerIndice()
        {
            int ret = -1;
            int i = 0;
             
            if(this._temperas.Count != 0)
            {
                foreach (Tempera t in this.MisTemperas)
                {
                    if (Equals(t,null))
                    {
                        ret = i;
                        break;
                    }
                    if(i >= this._cantidadMaxima)
                    {
                        break;
                    }
                    i++;
                }
            }
            
            return ret;
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            int indice;
            if (p1 != t1)
            {
                indice = p1.ObtenerIndice();
                if(indice >= 0 && indice < p1._cantidadMaxima)
                {
                    p1._temperas.Insert(indice, t1);
                }
                
            }
            return p1;
        }
    }
}
