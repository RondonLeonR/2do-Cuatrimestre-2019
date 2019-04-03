using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;

namespace Clase05.test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Tinta ejem1 = new Tinta();
            Tinta ejem2 = new Tinta(ConsoleColor.Cyan);
            Tinta ejem3 = new Tinta(ConsoleColor.DarkMagenta,ETipoTinta.conBrillo);

            Pluma pluma1 = new Pluma("BIC", ejem3, 20);

            Pluma pluma2 = new Pluma();

            Tinta ejem4 = new Tinta();
            Tinta ejem5 = ejem1;

            s1 = pluma1;
            Console.WriteLine(s1);
             
            pluma2 = pluma1 - ejem3;
            s2 = pluma2;
            Console.WriteLine(s2);

            if (pluma1 == ejem3)
            {
                Console.WriteLine("Son iguales");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No son iguales");
                Console.ReadLine();
            }

            Console.WriteLine(Tinta.Mostrar(ejem1));
            Console.WriteLine(Tinta.Mostrar(ejem2));
            Console.WriteLine(Tinta.Mostrar(ejem3));

            
            Console.ReadKey();
        }
    }
}
