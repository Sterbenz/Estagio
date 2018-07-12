using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeiaDeFORs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String texto = "";

            for (int i = 1; i <= 5; i++)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    texto += (i * i2) + " ";
                }
                texto += "\n";
            }
            MessageBox.Show(texto);
        }
    }
}
