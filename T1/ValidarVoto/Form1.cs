using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarVoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 17;
            bool brasileiro = true;

            if (idade >= 16 && brasileiro)
            {
                MessageBox.Show("Você está apto para votar");
            }
            else
            {
                MessageBox.Show("Você não está apto para votar");
            }
        }
    }
}
