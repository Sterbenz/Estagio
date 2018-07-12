using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaNãoMultiplosDe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    res += i;
                }
            }
            MessageBox.Show("Soma dos números que não são multiplos de 3 entre 1 e 100: " + res);
        }
    }
}
