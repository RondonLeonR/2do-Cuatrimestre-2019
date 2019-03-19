using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double numCuadr;
            double numCubo;
            Console.Write("Ingrese Numero: ");
            num = double.Parse(Console.ReadLine());
            if(num > 0)
            {
                numCuadr = Math.Pow(num, 2);
                numCubo = Math.Pow(num, 3);
                Console.WriteLine(numCuadr);
                Console.WriteLine(numCubo);
                Console.ReadLine();


            }
            else
            {
                Console.Write("ERROR.¡Reingresar Numero!");
                Console.ReadKey();
            }
        }
    }
}
