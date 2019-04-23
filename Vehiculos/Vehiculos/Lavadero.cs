using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Lavadero
    {
        protected List<Vehiculo> _vehiculos;
        protected float _precioAuto;
        protected float _precioCamion;
        protected float _precioMoto;

        public string MiLavadero
        {
            get { return " Precio Auto =" + this._precioAuto.ToString() + " Precio Camion =" + this._precioCamion.ToString() + " Precio Moto =" + this._precioMoto.ToString() + this.MostrarLista(); }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos; }

        }

        public Lavadero(float pAuto, float pCamion, float pMoto) : this()
        {
            this._precioAuto = pAuto;
            this._precioCamion = pCamion;
            this._precioMoto = pMoto;

        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        private string MostrarLista()
        {
            string retorno = "";
            //foreach(Vehiculo a in this._vehiculos)
            //{
            //    if(a is Auto)
            //    {
            //        retorno += ((Auto)a).MostrarAuto();
            //    }
            //    else if(a is Moto)
            //    {
            //        retorno += ((Moto)a).MostrarMoto();
            //    }
            //    else
            //    {
            //        retorno += ((Camion)a).MostrarCamion();
            //    }

            //}
            foreach (Vehiculo item in this._vehiculos)
            {
                //return item;
            }
            return retorno;
        }

        public static bool operator ==(Lavadero lav, Vehiculo v)
        {
            bool retorno = false;
            foreach (Vehiculo a in lav.Vehiculos)
            {
                if (a == v)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Lavadero lav, Vehiculo v)
        {
            return !(lav == v);
        }

        public static Lavadero operator +(Lavadero lav, Vehiculo v)
        {
            if (lav == v)
            {
                lav.Vehiculos.Add(v);
            }
            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo v)
        {
            if (lav == v)
            {
                lav.Vehiculos.Remove(v);
            }
            return lav;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(v1.Patente, v2.Patente);
        }

        //public int aa() 
        //{
        //    Enum.
        //}

    }
}
