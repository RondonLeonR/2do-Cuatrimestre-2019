using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa.Sellada;
//using Entidades.Externa;

namespace test
{
  class Program 
  {
    static void Main(string[] args)
    {
        MiPersona p = new MiPersona("Juan","Perez",22,Entidades.Alumnos.ESexo.Masculino);

      /*Metodos de Extension, se puede agregar cualquier clase. Sin tocar el codigo.*/

      PersonaExternaSellada pes = pes.Nombre();
    }
  }
}
