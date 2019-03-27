using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04;



namespace Rondon.Rodolfo
{
    public class Class004
    { 
        static void Main(string[] args)
        {
            Cosa obj = new Cosa();

            obj.entero = 111;
            obj.cadena = "holaaa";
            Console.WriteLine(obj.Mostrar());
            Console.ReadLine();
            
        }
    }
}
