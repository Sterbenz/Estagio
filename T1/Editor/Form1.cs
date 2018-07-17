using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (File.Exists("entrada.txt"))
            {
                using (Stream entrada = File.Open("entrada.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                { 
                    string texto = leitor.ReadToEnd();
                    tbTexto.Text = texto;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("entrada.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))

             
            escritor.Write(tbTexto.Text);           

        }       
    }
}