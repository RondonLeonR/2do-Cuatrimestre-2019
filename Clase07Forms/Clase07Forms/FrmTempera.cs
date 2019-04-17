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
    public partial class FrmTempera : Form
    {
        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get
            {
                return _miTempera;
            }
            set
            {
                _miTempera = value;
            }

        }


        public FrmTempera()
        {
            
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                comboBox1.Items.Add(color);
            }

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndex = 0;
        }

        public FrmTempera(Tempera tempera) : this()
        {
            MiTempera = tempera;
            sbyte cantidad = MiTempera;
            this.textBox1.Text = MiTempera.Marca;
            this.textBox2.Text = cantidad.ToString();
            this.comboBox1.SelectedItem = MiTempera.Color;
            
        }
        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.comboBox1.SelectedItem, this.textBox1.Text, sbyte.Parse(this.textBox2.Text));
            this._miTempera = nuevaTempera;
            
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
