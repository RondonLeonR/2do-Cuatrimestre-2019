using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library06;

namespace Clase07Forms
{
    public partial class FrmPaleta : Form
    {
        private Paleta _miPaleta;
        
        public Paleta MiPaleta
        {
            get { return _miPaleta; }
            set { _miPaleta = value; }
        }



        public FrmPaleta()
        {
            InitializeComponent();
            this.MiPaleta = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            

            if (frm.DialogResult == DialogResult.OK)
            {
                this.MiPaleta += frm.MiTempera;
                this.listBox1.Items.Clear();//Limpio la Lista

                foreach (Tempera i in this.MiPaleta.MisTemperas)
                {
                    if(!Equals(i,null))
                    {
                        listBox1.Items.Add(Tempera.Mostrar(i));
                    }
                }
            }
            
               
        }

        private void FrmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
