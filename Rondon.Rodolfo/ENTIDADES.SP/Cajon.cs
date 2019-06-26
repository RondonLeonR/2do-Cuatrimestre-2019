using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public class Cajon<T> : ISerializar
  {
    protected int _capacidad;
    protected List<T> _elementos;
    protected double _precioUnitario;

    public List<T> Elementos
    {
      get
      {
        return this._elementos;
      }
    }

    public double PrecioTotal
    {
      get
      {
        return (double) this._capacidad * this._precioUnitario;
      }
    }

    public Cajon()
    {
      this._elementos = new List<T>();
    }

    public Cajon(int cap) :this()
    {
      this._capacidad = cap;
    }

    public Cajon(double precio ,int cap) : this(cap)
    {
      this._precioUnitario = precio;
    }

    public override string ToString()
    {

      string retorno = "Capacidad: " + this._capacidad.ToString() + " Cantidad Total:" + this.Elementos.Count + " Precio Total: " + this.PrecioTotal.ToString() ;
      foreach(T elemento in this.Elementos)
      {
        if(elemento is Manzana)
        {
          retorno += "\n";
          retorno += elemento.ToString();
        }
        else if(elemento is Banana)
        {
          retorno += "\n";
          retorno += elemento.ToString();
        }
        else if(elemento is Durazno)
        {
          retorno += "\n";
          retorno += elemento.ToString();
        }
      }
      return retorno;
    }

    public bool Xml(string path)
    {
      throw new NotImplementedException();
    }

    public static Cajon<T> operator +(Cajon<T> cajon, T elemento)
    {

      if(cajon.Elementos.Count <= cajon._capacidad)
      {
        cajon.Elementos.Add(elemento);
      }
      return cajon;
    }
  }
}
