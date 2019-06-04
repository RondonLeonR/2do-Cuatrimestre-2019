using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface ISerializableXML
    {
        bool SerializarXML(object o);
        object DeserializarXML(object o);
        string Path { get; set; }
      
    }
}
