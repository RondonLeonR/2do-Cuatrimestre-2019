using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.RPP
{
    public class ClaseConstructores
    {
        int a;
        static ClaseConstructores() 
        {
            new ClaseConstructores("", "");
            MessageBox.Show("Constructor estático");
        }

        private ClaseConstructores(string p1,string p2) : this()
        {
            MessageBox.Show("\nConstructor privado con 2 parametros");
        }

        public ClaseConstructores() 
        {
            this.Propiedad1 = a;
            MessageBox.Show("\nConstructor publico (default)");
        }

        private int myVar;
        public int Propiedad1
        {
            set {
                MessageBox.Show("\nPropiedad solo escritura");
                this.myVar = Propiedad;
                }
        }

        public int Propiedad
        {
            get {
                MessageBox.Show("\nPropiedad solo lectura");
                this.MetodoDeInstancia();
                return myVar; }
        }

        public void MetodoDeInstancia()
        {
            MessageBox.Show("\nMetodo de Instancia");
            ClaseConstructores.MetodoDeClase();
        }

        public static void MetodoDeClase()
        {
            MessageBox.Show("\nMetodo de Clase");
        }


    }
}
