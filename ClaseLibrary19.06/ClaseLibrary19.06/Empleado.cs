using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using ClaseLibrary19._06;

namespace ClaseLibrary19._06
{
    public class Empleado
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        /*Eventos*/

        public event DelegadoSueldo _limiteSueldo;

        /*Propiedades*/
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return _sueldo;
            }
            set
            {
                if(value > 12000)
                {
                    this._limiteSueldo(this, value);
                }
                else
                {
                    this._sueldo = value;
                }  
            }
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " Legajo: " + this.Legajo.ToString() + " Sueldo: " + this._sueldo.ToString();
        }

        public void GuardarLog(Empleado e, float f)
        {
            try
            {
                using (StreamWriter str = new StreamWriter("D://incidentes.log"))
                {
                    str.WriteLine(DateTime.Now);
                    str.WriteLine(e.ToString());
                }
            }
            catch (Exception)
            {
                string cadena = "Al empleado " + e.Nombre + " de Legajo " + e.Legajo.ToString() + " se le quiso asignar el sueldo de: " + f.ToString() + "\n";
                Console.WriteLine(cadena);
            }

        }
    }
}
