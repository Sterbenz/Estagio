using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraImpostos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 5000.0;

            if (valorDaNotaFiscal < 1000.0)
            {
                valorDaNotaFiscal -= (valorDaNotaFiscal * 0.02);
                MessageBox.Show("O imposto é: " + 0.02 + ". O valor fica: " + valorDaNotaFiscal);
            }
            else if (valorDaNotaFiscal >= 1000.0 && valorDaNotaFiscal < 3000.0)
            {
                valorDaNotaFiscal -= (valorDaNotaFiscal * 0.025);
                MessageBox.Show("O imposto é: " + 0.025 + ". O valor fica: " + valorDaNotaFiscal);
            }
            else if (valorDaNotaFiscal >= 3000.0 && valorDaNotaFiscal < 7000.0)
            {
                valorDaNotaFiscal -= (valorDaNotaFiscal * 0.028);
                MessageBox.Show("O imposto é: " + 0.028 + ". O valor fica: " + valorDaNotaFiscal);
            }
            else
            {
                valorDaNotaFiscal -= (valorDaNotaFiscal * 0.03);
                MessageBox.Show("O imposto é: " + 0.03 + ". O valor fica: " + valorDaNotaFiscal);
            }

        }
    }
}