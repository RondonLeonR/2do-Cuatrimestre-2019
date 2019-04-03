using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClase4;


namespace Clase04Forms
{
    public partial class FormCosa : Form
    {
        public FormCosa()
        {
            InitializeComponent();
        }
        Cosa obj = new Cosa();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(obj.fecha.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.entero.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.cadena);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
