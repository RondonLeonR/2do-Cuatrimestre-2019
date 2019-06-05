using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;
        public BancoMunicipal(BancoProvincial bp, string municipio) : base(((BancoNacional)bp),bp.provincia)
        {
            this.municipio = municipio;
        }

        public override string Mostrar()
        {
            return base.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return Mostrar((BancoProvincial)b) + " - " + this.municipio;
        }

        public static implicit operator string(BancoMunicipal bm)
        {
            return bm.Mostrar(bm);
        }
        public override string ToString()
        {
            return this;
        }
    }
}
