using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fibonacci = "";
            int a = 1;
            int p = 0;
            int n = 0;
            while (a <= 100)
            {
                fibonacci += a + ", ";
                p = a + n;
                n = a;
                a = p;
            }
            MessageBox.Show("A sequencia fibanacci entre 1 e 100 é: " + fibonacci);
        }

    }
}

