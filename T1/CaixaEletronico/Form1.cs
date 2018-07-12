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
        Conta[] ListaConta;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListaConta  = new Conta[2];

            Conta conta1 = new Conta();
            conta1.titularCartao = new Cliente();
            conta1.titularCartao.Nome = "Luigi";
            conta1.Deposita(800.0);
            conta1.Numero = 1;

            Conta conta2 = new Conta();
            conta2.titularCartao = new Cliente();
            conta2.titularCartao.Nome = "Mario";
            conta2.Deposita(760.0);
            conta2.Numero = 2;
                       
            this.ListaConta[0] = conta1;
            this.ListaConta[1] = conta2;

            cbContas.Items.Add(ListaConta[0].titularCartao.Nome);
            cbContas.Items.Add(ListaConta[1].titularCartao.Nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDeposito.Text != "")
            {
                int indiceSelecionado = cbContas.SelectedIndex;
                Conta contaSelecionada = ListaConta[indiceSelecionado];
                double dep = Convert.ToDouble(tbDeposito.Text);

                contaSelecionada.Deposita(dep);
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
                int indiceSelecionado = cbContas.SelectedIndex;
                Conta contaSelecionada = ListaConta[indiceSelecionado];

                double sac = Convert.ToDouble(tbSacar.Text);
                if (sac <= contaSelecionada.Saldo)
                {
                                      
                    contaSelecionada.Saca(sac);
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
            int indiceSelecionado = cbContas.SelectedIndex;
            Conta contaSelecionada = ListaConta[indiceSelecionado];            
            tbSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            tbNumeroConta.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
                c1.Deposita(200.0);
                ContaPoupanca c2 = new ContaPoupanca();
                c2.Deposita(125.0);
                TotalizadorDeContas t = new TotalizadorDeContas();
                t.Soma(c1);
                t.Soma(c2);

                MessageBox.Show("valor total: " + t.ValorTotal);
        }

        private void cbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarInfosBanco();
        }
    }
}