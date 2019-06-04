using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml.Serialization;
using System.IO;

namespace testEntidades
{
    class Program 
    {
        static void Main(string[] args)
        {
            /**XML: tipo de archivo Serializar: Pasar o guardar en un archivo fisico desde la memoria / Deserializar
             * Puede Serializar Atributos (solo publicos), sino es publico no se va a ver en el documento.
             * Los atributos privados se podran serializar si tienen propiedades de lectura y escritura.
             * Si es una coleccion puede tener una propiedad de solo lectura(si la coleccion es privada).
             * Constructores: Si o si debe tener un constructor por default.
             * La clase debe ser publica.
             * **/
            List<Humano> listaHum = new List<Humano>();
            Humano h = new Humano();
            Persona p = new Persona("Juan","Perez");
            Alumno a = new Alumno();
            Profesor pr = new Profesor();

            h.Dni = 1111;

            p.Dni = 2222;

            a.nombre = "Ale";
            a.apellido = "Perez";
            a.Dni = 2222;
            a.Legajo = 9999;

            pr.nombre = "Jorge";
            pr.apellido = "Perez";
            pr.Dni = 3333;
            pr.Titulo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            listaHum.Add(h);
            listaHum.Add(p);
            listaHum.Add(a);
            listaHum.Add(pr);

            //if(Program.SerializarAlumno(a) is true)
            //{
            //    Console.WriteLine("Si se pudo serializar el Alumno");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar el Alumno");
            //}

            //if (Program.DeserializarAlumno() != null )
            //{
            //    Console.WriteLine("Si se pudo Deserializar");
            //    Console.WriteLine(Program.DeserializarAlumno().ToString());

            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar");
            //}

            //if (Program.SerializarHumano(pr) is true)
            //{
            //    Console.WriteLine("Si se pudo serializar el Humano");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar el Humano");
            //}

            //if (Program.DeserializarHumano() != null)
            //{
            //    Console.WriteLine("Si se pudo Deserializar el Humano");
            //    Console.WriteLine(Program.DeserializarHumano().ToString());

            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar");
            //}

            //if (Program.SerializarLista(listaHum) is true)
            //{
            //    Console.WriteLine("Si se pudo serializar la lista");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar la lista");
            //}

            //if (Program.DeserializarLista() != null)
            //{
            //    Console.WriteLine("Si se pudo Deserializar la lista");
            //    Console.WriteLine(Program.DeserializarLista().ToString());

            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar");
            //}

            if(Program.SerializarXML(h) is true)
            {
                Console.WriteLine("Se pudo Serializar");
            }
            else
            {
                Console.WriteLine("NO Se pudo Serializar");
            }



            Console.ReadLine();
        }
        
        public static bool SerializarAlumno(Alumno a)
        {
            bool retorno;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Alumno));
                using (StreamWriter str = new StreamWriter("D://alumno.xml"))
                {
                    xml.Serialize(str, a);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false ;
            }
            return retorno;

        }

        public static Alumno DeserializarAlumno()
        {
            Alumno a = new Alumno();
            try
            {  
                XmlSerializer xml = new XmlSerializer(typeof(Alumno));
                using (StreamReader str = new StreamReader("D://alumno.xml"))
                {
                    a = (Alumno)xml.Deserialize(str);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return a;
        }

        public static bool SerializarHumano(Humano h)
        {
            bool retorno;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Humano));
                using (StreamWriter str = new StreamWriter("D://humano.xml"))
                {
                    xml.Serialize(str, h);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static Humano DeserializarHumano()
        {
            Humano h = new Humano();
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Humano));
                using (StreamReader str = new StreamReader("D://humano.xml"))
                {
                    h = (Humano)xml.Deserialize(str);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return h;
        }

        public static bool SerializarLista(List<Humano> h)
        {
            bool retorno;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Humano>));
                using (StreamWriter str = new StreamWriter("D://ListaDeHumano.xml"))
                {
                    xml.Serialize(str, h);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static List<Humano> DeserializarLista()
        {
            List<Humano> h = new List<Humano>();
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Humano>));
                using (StreamReader str = new StreamReader("D://ListaDeHumano.xml"))
                {
                    h = (List<Humano>)xml.Deserialize(str);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return h;
        }

        public static bool SerializarXML(ISerializableXML o)
        {
            /**Las interfaces le permite simular la herencia multiple.
             * Permite definir metodos, propiedades (no van a tener implementacion) solo va tener la firma del metodo
             * No se puede definir atributos
             * Ej: bool SerializarXML();
             * Son clase Abstractas con metodos abstractos y propiedades abstractos, pero no se puede colocar el modificar "Abstract" 
             * ni modificador de visivilidad(public,private)
             * Lo mismo con el override.
             * Si una clase implementa una interfaz se tiene que dar implementacion a todos los metodos/propiedades de las interfaces
             * Cuando se implementa el metodo o propiedad es publico
             * **/
            
            
            return o.Serializar();
        }
    }
}
