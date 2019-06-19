using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
  public class MiPersona : PersonaExterna
  {
    public MiPersona(string nombre, string apellido, int edad, ESexo sexo) : base(nombre,apellido,edad,(Entidades.Externa.ESexo)sexo)
    {

    }

    public string Nombre
    {
      get
      {
        return base._nombre;
      }
    }

    public string Apellido
    {
      get
      {
        return base._apellido;
      }
    }

    public int Edad
    {
      get
      {
        return base._edad;
      }
    }

    public ESexo Sexo
    {
      get
      {
        return (ESexo)base._sexo;
      }
    }

  }
}
