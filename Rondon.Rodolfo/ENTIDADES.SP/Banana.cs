using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public class Banana : Fruta
  {
    protected string _paisOrigen;

    public string Nombre
    {
      get
      {
        return "Banana";
      }
    }

    public override bool TieneCarozo
    {
      get
      {
        return false;
      }
    }

    public Banana(string color, double peso, string paisOrigen) : base(color,peso)
    {
      this._paisOrigen = paisOrigen;
    }

    public override string ToString()
    {
      return this.Nombre +" Carozo: " + this.TieneCarozo.ToString() + " Origen: " +  this._paisOrigen + base.FrutaToString();
    }
  }
}
