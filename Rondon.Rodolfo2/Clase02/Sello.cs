using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Sello
    {
        public static string mensaje;   //Atributo o Variable de una clase
        public static ConsoleColor color;

        public static string Imprimir()
        {
            
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "---";
        }

        public static void ImprimirEnColor()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
            

        }

        private static string ArmarFormatoMensaje()
        {
            string mensaje;
            string mensajeRetorno;
            int cantCarac;

            cantCarac = Sello.mensaje.Length +2;
            mensaje = "";
            mensajeRetorno = "";
            for(int i=0;i<cantCarac;i++)
            {
                mensaje += "*";
            }
            mensajeRetorno = mensaje + "\n*" + Sello.mensaje + "*\n" + mensaje;

            return mensajeRetorno;
        }
    }
}
