using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ENTIDADES.SP
{
  [Serializable]
  public class Manzana : Fruta , ISerializar , IDeserializar
  {
    protected string _provinciaOrigen;

    public string Nombre
    {
      get
      {
        return "Manzana";
      }
    }

    public override bool TieneCarozo
    {
      get
      {
        return true;
      }
    }

    public Manzana(string color, double peso, string provinciaOrigen): base(color,peso)
    {
      this._provinciaOrigen = provinciaOrigen;
    }

    public override string ToString()
    {
      return this.Nombre + " Carozo: "+ this.TieneCarozo.ToString() + " Origen: "+this._provinciaOrigen + base.FrutaToString() ;
    }

    public bool Xml(string path)
    {
      bool retorno;
      try
      {
        XmlSerializer xml = new XmlSerializer(typeof(Manzana));
        using (StreamWriter str = new StreamWriter(path))
        {
          xml.Serialize(str, this);
        }
        retorno = true;
      }
      catch (Exception)
      {
        retorno = false;
      }
      return retorno;
    }

    bool IDeserializar.Xml(string c, out Fruta fruta)
    {
      bool retorno = true;

      try
      {
        XmlSerializer xml = new XmlSerializer(typeof(Fruta));
        StreamReader str = new StreamReader(c);
        Fruta f = (Fruta)xml.Deserialize(str);
        fruta = f;
        return retorno;
      }
      catch (Exception)
      {
        throw;
      }

      
    }
  }
}
