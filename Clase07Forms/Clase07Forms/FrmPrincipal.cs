using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07Forms
{
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaleta paleta = new FrmPaleta();
            paleta.MdiParent = this;
            paleta.StartPosition = FormStartPosition.CenterScreen;
            paleta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));
            
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
