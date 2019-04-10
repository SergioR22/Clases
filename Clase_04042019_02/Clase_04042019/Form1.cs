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

namespace Clase_04042019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DriveInfo[] u = DriveInfo.GetDrives();
            foreach (DriveInfo unidad in u)
            {
                try
                {
                    listBox1.Items.Add(unidad.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de lectura" + ex.Message);
                    MessageBox.Show("Error leyendo los diiscos");
                }
            }
         
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            String unidades = listBox1.SelectedItem.ToString();
            DriveInfo d = new DriveInfo(unidades);
            listBox2.Items.Add("Disco: " + d.Name+"\n");
            if (d.IsReady)
            {
                listBox2.Items.Add("Espacio ocupado(GB): "+(d.TotalSize - d.AvailableFreeSpace)
                    /1024 / 1024 / 1024 + "\n");
                listBox2.Items.Add("Espacio disponible(GB): " + (d.TotalFreeSpace) /1024    /1024
                    /1024 + "\n");
                listBox2.Items.Add("Espacio total(GB): " + (d.TotalSize) /1024  /1024 /1024 + "\n");     
            }
            listBox2.Items.Add("Tipo de disco utilizado" + d.DriveType.ToString() + "\n");
            
            treeView1.Nodes.Clear();
           
            {   
                if (d.IsReady)
                {
                    DirectoryInfo dir = new DirectoryInfo(unidades);
                    foreach (DirectoryInfo sub in dir.GetDirectories())
                    {
                        treeView1.Nodes.Add(sub.Name);
                    }
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        TreeNode nodo = new TreeNode();
                        nodo.Text = file.Name;
                        nodo.ForeColor = Color.Blue;
                        treeView1.Nodes.Add(nodo);
                    }
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Dir = "C:/Sergio";
            String arch = "C:/SergioA.text";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            else
            {
                MessageBox.Show("Existe el directorio");
            }
            if (!File.Exists(arch))
            {
                File.Create(arch);
            }
            else
            {
                MessageBox.Show("Existe el directorio");
            }
        }
    }
}
