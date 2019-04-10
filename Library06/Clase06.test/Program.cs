using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library06;

namespace Clase06.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera p1 = new Tempera(ConsoleColor.Cyan,"hola",4);
            Paleta p = 7;

            Console.WriteLine(p.Mostrar());
            //Console.ReadLine();

            Console.WriteLine(Tempera.Mostrar(p1));
            Console.ReadLine();
        }
    }
}
