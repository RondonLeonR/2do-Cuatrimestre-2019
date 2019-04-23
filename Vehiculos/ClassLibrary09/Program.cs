using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace ClassLibrary09
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("AAABBB", 4, EMarca.Ford, 11, 1200);
            Moto moto = new Moto("aaaddd", 2, EMarca.Honda, 100, 300);
            Camion camion = new Camion("BBBMMM", 4, EMarca.Iveco, 22, 200);

            Console.WriteLine(moto);
            Console.WriteLine("PRECIO MOTO: " + moto.CalcularPrecioConIVA().ToString());
            Console.WriteLine(camion);
            Console.WriteLine("PRECIO CAMION: " + camion.CalcularPrecioConIVA().ToString());
            Console.WriteLine(auto);
            Console.WriteLine("PRECIO AUTO: " + auto.CalcularPrecioConIVA().ToString());
            Console.ReadLine();
        
            

            
        }
    }
}
