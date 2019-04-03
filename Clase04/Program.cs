using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase4;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa obj = new Cosa();

            obj.cadena = "Un mensaje ahhahahaah";
            obj.entero = 777;

            obj.fecha = DateTime.Now;

            Console.WriteLine(obj.Mostrar());
            Console.Read();

        }
    }
}
