using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondon.Rodolfo._2A
{
    public abstract class Mascota
    {
        //EtipoManada tipMan = new EtipoManada;
        private string _nombre;
        private string _raza;
        
        public string Nombre
        {
            get;
        }

        public string Raza
        {
            get;
        }

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return this._nombre + " " + this._raza;
        }
        
    }
}
