using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace frmListado
{
    public partial class Form1 : Form
    {
        private List<Persona> _personas;
        private DataTable _tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            this._personas = ad.TraerTodos();
            this._tabla = ad.TraerTablaPersonas();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ////this.dataGridView1.DataSource = this._personas;
            this.dataGridView1.DataSource = this._tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
