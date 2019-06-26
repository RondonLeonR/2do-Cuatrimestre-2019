using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public class Durazno : Fruta
  {
    protected int _cantPelusa;

    public string Nombre
    {
      get
      {
        return "Durazno";
      }
    }

    public override bool TieneCarozo
    {
      get
      {
        return true;
      }
    }

    public Durazno(string color, double peso, int cantPelusa) : base(color,peso)
    {
      this._cantPelusa = cantPelusa;
    }

    public override string ToString()
    {
      return this.Nombre + " Carozo :"+ this.TieneCarozo + " Cant. Pelusa: "+ this._cantPelusa.ToString()  + base.FrutaToString();
    }
  }
}
