using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public interface IDeserializar
  {
    bool Xml(string c, out Fruta fruta);
  }
}
