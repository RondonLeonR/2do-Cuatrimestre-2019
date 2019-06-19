using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClaseLibrary19._06
{
    public class EmpleadoMejorado
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        /*Eventos*/

        public event DelSueldo _limiteSueldo;


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
                if (value > 12000)
                {
                    EmpleadoSueldoArgs ems = new EmpleadoSueldoArgs();
                    ems.Sueldo = value;
                    this._limiteSueldo(this, ems);
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

        public void GuardarLog(EmpleadoMejorado e, float f)
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
                throw;
            }

        }
    }
}
