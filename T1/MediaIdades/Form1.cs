using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeBob = 18;
            int idadeKlaus = 17;
            int idadeZe = 20;
            double mediaIdades = ((idadeBob + idadeKlaus + idadeZe) / 3);
            MessageBox.Show("A média das idades é : " + mediaIdades);

        }
    }
}
