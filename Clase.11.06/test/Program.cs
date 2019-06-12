using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClassLibrary;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(5, "Luis", "Sanchez", 19);
            Persona p2 = new Persona(16, "aaaaaaaaaaaaaaaaaaaaaaa", "Gonzales", 22);
            AccesoDatos at = new AccesoDatos();

            //if(at.AgregarPersona(p2))
            //{
            //    Console.WriteLine("Se Agrego");
            //}

            //if(at.ModificarPersona(p2))
            //{
            //    Console.WriteLine("Se Modifico.");
            //}

            //if(at.EliminarPersona(21))
            //{
            //    Console.WriteLine("Se elimino.");
            //}

            DataTable dt = at.TraerTablaPersonas();
            
            //foreach(DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine(dr["id"]/*dr["nombre"]  dr["apellido"] dr["edad"]*/);
            //}

            //dt.ReadXmlSchema("Personas_Esquemas.xml");
            dt.ReadXml("Personas_Datos.xml");

            //dt.WriteXmlSchema("Personas_Esquemas.xml");
            //dt.WriteXml("Personas_Datos.xml");

            //List<Persona> personas = at.TraerTodos();
            
            //foreach (Persona item in personas)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Console.Read();
        }
    }
}
