using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 1;

            for (int i = 1; i <= 10; i++)
            {
                f *= i;
                MessageBox.Show("O fatorial de " + i + " é " + f);
            }
        }
    }
}
