using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Deposito : Producto
    {
        public List<Producto> productos ;

        public Deposito() : this(3)
        {
        }

        public Deposito(int lis) : base("",0)
        {
            this.productos = new List<Producto>(lis);
        }

        public static List<Producto> operator +(Deposito a, Deposito b)
        {
            bool flag = false;
            List<Producto> listaRetorno = new List<Producto>();

            foreach(Producto p in a.productos)
            {
                listaRetorno.Add(p);
            }

            foreach(Producto p in b.productos)
            {
                foreach(Producto p2 in listaRetorno)
                {
                    if(p.nombre == p2.nombre)
                    {
                        p2.stock += p.stock;
                        break;
                    }
                    flag = true;
                }
                if(flag == true)
                {
                    listaRetorno.Add(p);
                    flag = false;
                }
               
            }
            
            return listaRetorno;
        }

    }
}
