using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Humano))]
    [XmlInclude(typeof(Persona))]
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Alumno))]
    public class Humano : ISerializableXML
    {
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private string _path;
        public string Path
        {
            get { return "D://humano.xml"; }
            set { _path = value; }
        }

        public object DeserializarXML(object o)
        {
            Humano h = new Humano();
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(object));
                using (StreamReader str = new StreamReader(Path))
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

        public bool SerializarXML(object o)
        {
            bool retorno;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(object));
                using (StreamWriter str = new StreamWriter(Path))
                {
                    xml.Serialize(str, o);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public override string ToString()
        {
            return "DNI : " + this.Dni;
        }
    }
}
