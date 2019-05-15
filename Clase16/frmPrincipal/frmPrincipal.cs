using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        private string _pathDir = "" ;
        public frmPrincipal()
        {
            
            InitializeComponent();
            this.btnEntrar.Text = "&Entrar";
            this.btnTraer.Text = "&Traer";
            this.btnBuscar.Text = "&Buscar";
            
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //String pathExe = AppDomain.CurrentDomain.BaseDirectory;
            string path = this._pathDir;
            if (path == "" || path == null)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt";
            }
            
             
            //MessageBox.Show(pathEscritorio);
            try
            {
                StreamWriter strWr = new StreamWriter(path , true);
                strWr.WriteLine(this.txtValor.Text);
                strWr.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
                throw;
            }
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            //string pathExe = AppDomain.CurrentDomain.BaseDirectory;
            //string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string text = "";
            string path = this._pathDir;
            if (path == "" || path == null)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt";
            }
            this.lstVisor.Items.Clear();
            StreamReader strRe = new StreamReader(path, true);
            while ((text = strRe.ReadLine()) != null)
            {
                this.lstVisor.Items.Add(text);
            }
            
            strRe.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string path = "";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = this.openFileDialog1.FileName;
                //MessageBox.Show(path);
            }

            this._pathDir = path;


  
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog1.Title = "Seleccione un archivo ";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.DefaultExt = ".txt";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.Filter = "Archivo(*.txt)|*.TXT";
        }
    }
}
