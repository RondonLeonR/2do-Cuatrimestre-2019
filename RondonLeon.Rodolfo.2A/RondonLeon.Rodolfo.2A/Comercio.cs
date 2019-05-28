using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondonLeon.Rodolfo._2A
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;

        public int CantidadDeEmpleados
        {
            get
            {
                if(this._cantidadDeEmpleados == 0)
                {
                    this._cantidadDeEmpleados = Comercio._generadorDeEmpleados.Next(0, 10);
                }
                return this._cantidadDeEmpleados;
            }
        }

        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre,string apellido) : this(nombreComercio,new Comerciante(nombre,apellido),precioAlquiler)
        {

        }

        public Comercio(string nombre, Comerciante comerciante, float precio)
        {
            this._nombre = nombre;
            this._precioAlquiler = precio;
            this._comerciante = comerciante;
        }


        private string Mostrar()
        {
            return "Nombre: " + this._nombre + "\nCantidad de Empleados: " + this._cantidadDeEmpleados + "\nComerciante: " + this._comerciante + "\nPrecio Alquiler: " + this._precioAlquiler;
        }

        public static bool operator ==(Comercio a, Comercio b)
        {
            bool retorno = false;
            if(a._nombre == b._nombre && a._comerciante == b._comerciante)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }

        public static implicit operator string(Comercio a)
        {
            return a.Mostrar();
        }
    }
}
