using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(1, "Ariel", "Rodriguez", 86);
            AccesoDatos at = new AccesoDatos();
            
            if(at.AgregarPersona(p1))
            {
                Console.WriteLine("Se Agrego");
            }

            List<Persona> personas = at.TraerTodos();

            foreach (Persona item in personas)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
