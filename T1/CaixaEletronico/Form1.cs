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
        
        public Conta[] ListaConta { get; private set; }     
        private int quantidadeDeContas = 5;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListaConta = new Conta[10];

            Conta conta1 = new ContaCorrente();
            conta1.TitularCartao = new Cliente();
            conta1.TitularCartao.Nome = "Luigi";
            conta1.Deposita(800.0);
            conta1.Numero = 1;

            Conta conta2 = new ContaCorrente();
            conta2.TitularCartao = new Cliente();
            conta2.TitularCartao.Nome = "Mario";
            conta2.Deposita(760.0);
            conta2.Numero = 2;

            Conta conta3 = new ContaCorrente();
            conta3.TitularCartao = new Cliente();
            conta3.TitularCartao.Nome = "Yoshi";
            conta3.Deposita(130.0);
            conta3.Numero = 3;

            Conta conta4 = new ContaPoupanca();
            conta4.TitularCartao = new Cliente();
            conta4.TitularCartao.Nome = "Peach";
            conta4.Deposita(99999.0);
            conta4.Numero = 4;

            Conta conta5 = new ContaPoupanca();
            conta5.TitularCartao = new Cliente();
            conta5.TitularCartao.Nome = "Toad";
            conta5.Deposita(9999999.0);
            conta5.Numero = 5;

            ListaConta[0] = conta1;
            ListaConta[1] = conta2;
            ListaConta[2] = conta3;
            ListaConta[3] = conta4;
            ListaConta[4] = conta5;

            foreach (Conta conta in this.ListaConta)
            {
                if (conta != null)
                {
                    cbContas.Items.Add(conta);                    
                }
            }

        }

        public void excluirConta(Conta contaDel)
        {
            cbContas.Items.Remove(contaDel);
            
            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.ListaConta[i] == contaDel )
                {
                    break;
                }                             
            }
            while (i + 1 < this.quantidadeDeContas)
            {
                this.ListaConta[i] = this.ListaConta[i + 1];
                i++;
            }
            tbNumeroConta.Text = tbSaldo.Text = null;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDeposito.Text != "")
            {
                int indiceSelecionado = cbContas.SelectedIndex;
                Conta contaSelecionada = this.BuscaContaSelecionada();
                double dep = Convert.ToDouble(tbDeposito.Text);

                contaSelecionada.Deposita(dep);
                tbDeposito.Text = "";
                mostrarInfosBanco(contaSelecionada);
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
                Conta contaSelecionada = this.BuscaContaSelecionada();

                double sac = Convert.ToDouble(tbSacar.Text);
                if (sac <= contaSelecionada.Saldo)
                {
                                      
                    contaSelecionada.Saca(sac);
                    tbSacar.Text = "";
                    mostrarInfosBanco(contaSelecionada);
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

       private void mostrarInfosBanco(Conta conta)
        {            
                       
            tbSaldo.Text = Convert.ToString(conta.Saldo);
            tbNumeroConta.Text = Convert.ToString(conta.Numero);
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
            string titularSelecionado = cbContas.Text;
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.mostrarInfosBanco(contaSelecionada);
        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = cbContas.SelectedIndex;
            return this.ListaConta[indiceSelecionado];
        }

        public void adicionarConta(Conta conta)
        {
            if (this.quantidadeDeContas == this.ListaConta.Length)
            {
                Conta[] novo = new Conta[this.ListaConta.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.ListaConta[i];
                }
                this.ListaConta = novo;
            }
            this.ListaConta[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
            cbContas.Items.Add(conta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroDeContas aplicacaoCadastrarConta = new CadastroDeContas(this);
            aplicacaoCadastrarConta.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletarConta appDeletaConta = new DeletarConta(this);
            appDeletaConta.ShowDialog();
            
        }
    }
}