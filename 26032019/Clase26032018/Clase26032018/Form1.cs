using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Clase26032018
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        Resta ingresoR;
        Multi ingresoM;
        Division ingresoD;

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
             ingreso = new Operacion();
             ingreso.V1 = double.Parse(textboxA.Text);
             ingreso.V2 = double.Parse(textbox2.Text);
             label3.Text = ingreso.Calcular().ToString();
          
        }

        private void butonresta_Click(object sender, EventArgs e)
        {
            ingresoR = new Resta();
            ingresoR.V3 = double.Parse(textboxA.Text);
            ingresoR.V4 = double.Parse(textbox2.Text);
            label3.Text = ingresoR.CalcularR().ToString();
        }

        private void butonmulti_Click(object sender, EventArgs e)
        {
            ingresoM = new Multi();
            ingresoM.V5 = double.Parse(textboxA.Text);
            ingresoM.V6 = double.Parse(textbox2.Text);
            label3.Text = ingresoM.CalcularM().ToString();
        }

        private void botondivi_Click(object sender, EventArgs e)
        {
            ingresoD = new Division();
            ingresoD.V7 = double.Parse(textboxA.Text);
            ingresoD.V8 = double.Parse(textbox2.Text);
            label3.Text = ingresoD.CalcularD().ToString();
        }
    }
}
