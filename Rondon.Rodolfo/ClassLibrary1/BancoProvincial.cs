using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class BancoProvincial : BancoNacional
    {
        public string provincia;
        public BancoProvincial(BancoNacional bn, string prov) : base(bn.nombre,bn.pais)
        {
            this.provincia = prov;
        }

        public override string Mostrar()
        {
            return base.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return Mostrar((BancoNacional)b) + ((BancoProvincial)b).provincia;
        }
    }
}
