using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : Humano , ISerializableXML
    {
        public string apellido;
        public string nombre;

        public Persona()
        {
            
        }

        public Persona(string nombre, string apellido) : this()
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return base.ToString() + "\nApellido: " + this.apellido + "\nNombre: " + this.nombre ;
        }
    }
}
