using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondon.Rodolfo
{
     public class Clase04
    {
        public class Cosa
        {
            #region Atributos
            public int entero;
            public string cadena;
            public DateTime fecha;
            #endregion

            public string Mostrar()
            {
                return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString();         
            }

            public static string Mostrar(Cosa cosa)
            {
                return cosa.Mostrar();//Llamo al metodo
            }

            public void EstablecerValor(int valor)
            {
                this.entero = valor;
            }

            public void EstablecerValor(DateTime valor)
            {
                this.fecha = valor;
            }

            public void EstablecerValor(string valor)
            {
                this.cadena = valor;
            }

            public Cosa()
            {
                this.cadena = "Sin Valor";
                this.entero = 10;
                this.fecha = DateTime.Now;
            }

            public Cosa(int valor) : this() 
            {
                this.entero = valor;
                //this.cadena = "Sin Valor";
                //this.fecha = DateTime.Now;
            }

            public Cosa(int valor,DateTime fecha) : this(valor)
            {
                //this.cadena = "Sin Valor";
                //this.entero = valor;
                this.fecha = fecha;
            }

            public Cosa(int valor, DateTime fecha, string cadena) : this(valor,fecha)
            {
                this.cadena = cadena;
                //this.entero = valor;
                //this.fecha = fecha;
            }


        }
    }
}
