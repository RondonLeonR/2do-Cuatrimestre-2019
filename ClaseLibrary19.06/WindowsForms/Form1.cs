using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseLibrary19._06;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoMejorado.Items.Add(TipoMejorado.ambos);
            cmbTipoMejorado.Items.Add(TipoMejorado.limiteSueldo);
            cmbTipoMejorado.Items.Add(TipoMejorado.log);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado em = new EmpleadoMejorado();

            if ((TipoMejorado)cmbTipoMejorado.SelectedItem == TipoMejorado.log)
            {
                em.GuardarLog(em, float.Parse(txtSueldo.Text));
            }
            else if((TipoMejorado)cmbTipoMejorado.SelectedItem == TipoMejorado.limiteSueldo)
            {
                em._limiteSueldo += new DelSueldo(EmpleadoMejorado_limiteSueldo);
            }
            else
            {
                em._limiteSueldo += new DelSueldo(EmpleadoMejorado_log_limiteSueldo);
            }

            em.Nombre = txtNombre.Text;
            em.Legajo = int.Parse(txtLegajo.Text);
            em.Sueldo = float.Parse(txtSueldo.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private static void EmpleadoMejorado_limiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs f)
        {
            string cadena = "Al empleado " + e.Nombre + " de Legajo " + e.Legajo.ToString() + " se le quiso asignar el sueldo de: " + f.Sueldo.ToString() + "\n";
            MessageBox.Show(cadena);
        }

        private static void EmpleadoMejorado_log_limiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs f)
        {
            string cadena = "Al empleado " + e.Nombre + " de Legajo " + e.Legajo.ToString() + " se le quiso asignar el sueldo de: " + f.Sueldo.ToString() + "\n";
            MessageBox.Show(cadena);
            e.GuardarLog(e, f.Sueldo);
        }

        public enum TipoMejorado
        {
            limiteSueldo,
            log,
            ambos
        }
    }
}
