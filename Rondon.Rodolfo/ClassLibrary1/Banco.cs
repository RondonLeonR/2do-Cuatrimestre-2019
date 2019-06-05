using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.RPP
{
    public class Banco
    {
        public string nombre;
        public Banco(string nom)
        {
            this.nombre = nom;
        }

        public virtual string Mostrar()
        {
            return this.nombre;
        }
        public virtual string Mostrar(Banco b)
        {
            return b.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Banco)
            {
                MessageBox.Show("Banco");
                retorno = true;
            }
            else if(obj is BancoNacional)
            {
                MessageBox.Show("Banco Nacional");
            }
            else if(obj is BancoProvincial)
            {
                MessageBox.Show("Banco Provincial");
            }
            else if(obj is BancoMunicipal)
            {
                MessageBox.Show("Banco Municipal");
            }
            else
            {
                MessageBox.Show("no es ningun tipo de banco");
            }
            return retorno;
        }
    }
}
