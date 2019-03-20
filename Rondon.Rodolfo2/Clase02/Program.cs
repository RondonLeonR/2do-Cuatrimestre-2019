using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "aaaaaaaaaa";

            //Console.WriteLine(Sello.Imprimir()); 
            //Sello.Borrar();
            Sello.ImprimirEnColor();
            //Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();
            
        }
    }
}
