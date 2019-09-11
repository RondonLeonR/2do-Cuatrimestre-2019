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
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            this.MiPaleta -= frm.MiTempera;
            this.listBox1.Items.Clear();
            foreach (Tempera i in this.MiPaleta.MisTemperas)
            {
                if (!Equals(i, null))
                {
                    listBox1.Items.Add(Tempera.Mostrar(i));
                }
            }
            
            //int indice = this.listBox1.SelectedIndex;
            //this.listBox1.Items.RemoveAt(indice);
            //this.MiPaleta -= this.MiPaleta.MisTemperas[indice];

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(index.ToString());
            FrmTempera  p = new FrmTempera(this.MiPaleta.MisTemperas[this.listBox1.SelectedIndex]);
            p.ShowDialog();

            this.MiPaleta.MisTemperas[this.listBox1.SelectedIndex] = p.MiTempera;
            this.listBox1.Items.Clear();
            foreach (Tempera i in this.MiPaleta.MisTemperas)
            {
                if (!Equals(i, null))
                {
                    listBox1.Items.Add(Tempera.Mostrar(i));
                }
            }
        }
    }
}
