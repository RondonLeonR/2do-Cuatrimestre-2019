using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseLibrary19._06;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            EmpleadoMejorado eM = new EmpleadoMejorado();
            /*Asocio el manejador de eventos, que esta en el archivo de codigo*/
            e._limiteSueldo += new DelegadoSueldo(limiteSueldoEmpleado);
            e._limiteSueldo += new DelegadoSueldo(e.GuardarLog);
            e.Nombre = "JUAN";
            e.Legajo = 1111;
            e.Sueldo = 11000;
            Console.WriteLine(e.ToString());
            Console.ReadLine();
        }

        private static void limiteSueldoEmpleado(Empleado e, float f)
        {
            string cadena = "Al empleado " + e.Nombre + " de Legajo " + e.Legajo.ToString() + " se le quiso asignar el sueldo de: " + f.ToString() + "\n";
            Console.WriteLine(cadena);
        }

        //public void GuardarLog(Empleado e, float f)
        //{
        //    try
        //    {
        //        using (StreamWriter str = new StreamWriter("D://incidentes.log"))
        //        {
        //            str.WriteLine(DateTime.Now);
        //            str.WriteLine(e.ToString());
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}
    }
}
