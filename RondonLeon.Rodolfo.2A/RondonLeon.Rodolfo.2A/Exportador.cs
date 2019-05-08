﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RondonLeon.Rodolfo._2A
{
    public class Exportador : Comercio
    {
        ETipoProducto tipo = new ETipoProducto();
        
        public Exportador(string nombreComercio, float precioAlquiler, string nombre,string apellido, ETipoProducto tipo) : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        /*Terminar*/
        public string Mostrar()
        {
            return "Tipo de Producto: " + this.tipo.ToString() + base.ToString();
        }

        public static bool operator ==(Exportador a, Exportador b)
        {
            bool retorno = false;
            if(a == b && a.tipo == b.tipo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }

        public static implicit operator double(Exportador m)
        {
            return (double) m._precioAlquiler;
        }
    }
}
