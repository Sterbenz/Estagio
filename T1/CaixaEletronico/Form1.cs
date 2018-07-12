using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        Conta conta;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.conta.titularCartao = new Cliente();
            this.conta.Numero = 1;
            this.conta.Deposita(250.0);
            this.conta.titularCartao.idade = 20;
            this.conta.titularCartao.Nome = "Guilherme";

            mostrarInfosBanco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDeposito.Text != "")
            {
                double dep = Convert.ToDouble(tbDeposito.Text);

                this.conta.Deposita(dep);
                tbDeposito.Text = "";
                mostrarInfosBanco();
            }
            else
            {
                MessageBox.Show("Sem valor de deposito!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbSacar.Text != "")
            {


                double sac = Convert.ToDouble(tbSacar.Text);
                if (sac <= this.conta.Saldo)
                {
                    this.conta.Saca(sac);
                    tbSacar.Text = "";
                    mostrarInfosBanco();
                }
                else
                {
                    MessageBox.Show("Dinheiro em conta insufuciente!!");
                }
            }
            else
            {
                MessageBox.Show("Sem valor de saque!!");
            }
        }

        private void mostrarInfosBanco()
        {
            tbTitular.Text = conta.titularCartao.Nome;
            tbNumeroConta.Text = Convert.ToString(this.conta.Numero);
            tbSaldo.Text = Convert.ToString(this.conta.Saldo);
        }

    }
}
