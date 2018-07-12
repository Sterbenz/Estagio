using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -5;
            int c = 6;

            double a1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double a2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            MessageBox.Show("O resultado é : " + a1 + " E " + a2);

        }
    }
}
