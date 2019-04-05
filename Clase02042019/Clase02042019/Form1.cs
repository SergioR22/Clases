using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase02042019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {

                progressBar1.PerformStep();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                progressBar1.PerformStep();
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {

                progressBar1.PerformStep();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            timer1.Interval = 3000;
            timer1.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
