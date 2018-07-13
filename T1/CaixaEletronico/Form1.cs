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
        
        private Conta[] ListaConta;
        private int quantidadeDeContas = 5;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListaConta  = new Conta[20];

            ContaCorrente conta1 = new ContaCorrente();
            conta1.TitularCartao = new Cliente();
            conta1.TitularCartao.Nome = "Luigi";
            conta1.Deposita(800.0);
            conta1.Numero = 1;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.TitularCartao = new Cliente();
            conta2.TitularCartao.Nome = "Mario";
            conta2.Deposita(760.0);
            conta2.Numero = 2;

            ContaCorrente conta3 = new ContaCorrente();
            conta3.TitularCartao = new Cliente();
            conta3.TitularCartao.Nome = "Yoshi";
            conta3.Deposita(130.0);
            conta3.Numero = 3;

            ContaPoupanca conta4 = new ContaPoupanca();
            conta4.TitularCartao = new Cliente();
            conta4.TitularCartao.Nome = "Peach";
            conta4.Deposita(99999.0);
            conta4.Numero = 4;

            ContaPoupanca conta5 = new ContaPoupanca();
            conta5.TitularCartao = new Cliente();
            conta5.TitularCartao.Nome = "Toad";
            conta5.Deposita(9999999.0);
            conta5.Numero = 5;

            this.ListaConta[0] = conta1;
            this.ListaConta[1] = conta2;
            this.ListaConta[2] = conta3;
            this.ListaConta[3] = conta4;
            this.ListaConta[4] = conta5;

            cbContas.Items.Add(ListaConta[0].TitularCartao.Nome);
            cbContas.Items.Add(ListaConta[1].TitularCartao.Nome);
            cbContas.Items.Add(ListaConta[2].TitularCartao.Nome);
            cbContas.Items.Add(ListaConta[3].TitularCartao.Nome);
            cbContas.Items.Add(ListaConta[4].TitularCartao.Nome);
                       
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

        //private void button3_Click(object sender, EventArgs e)
        //{
        //        ContaCorrente c1 = new ContaCorrente();
        //        c1.Deposita(200.0);
        //        ContaPoupanca c2 = new ContaPoupanca();
        //        c2.Deposita(125.0);
        //        TotalizadorDeContas t = new TotalizadorDeContas();
        //        t.Soma(c1);
        //        t.Soma(c2);
        //        MessageBox.Show("valor total: " + t.ValorTotal);
        //}

        private void cbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarInfosBanco();
        }

        public void adicionarConta(Conta conta)
        {
            this.ListaConta[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
            cbContas.Items.Add(conta.TitularCartao.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroDeContas aplicacaoCadastrarConta = new CadastroDeContas(this);
            aplicacaoCadastrarConta.ShowDialog();
            

        }
    }
}