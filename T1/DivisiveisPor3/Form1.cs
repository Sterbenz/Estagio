using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisiveisPor3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lista = "";
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    lista += i + ", ";
                }
            }
            MessageBox.Show("Lista de numeros divisiveis por 3 ou 4: " + lista);
        }

    }
}

