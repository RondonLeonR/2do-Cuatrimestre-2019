using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int numMax = 0;
            int numMin = 0;
            int suma = 0;
            bool flag = true;
            float promedio;

            Console.Title = "Ejercicio 1";
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese Numero: ");
                num = int.Parse(Console.ReadLine()) ;

                if(flag == true)
                {
                    numMax = num;
                    numMin = num;
                    flag = false;
                }

                if (num > numMax )
                    numMax = num;
                else if (num < numMin )
                    numMin = num;
                
                suma = suma +num;
            }

            promedio = suma / 5.0f;
            Console.WriteLine("Promedio: {0}\nNumero Maximo: {1}\nNumero Minimo: {2}", promedio,numMax,numMin);
            Console.ReadKey();

            

        }
    }
}
