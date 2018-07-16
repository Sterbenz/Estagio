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
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPadrao;
        public CadastroDeContas(Form1 aplicacaoPadrao)
        {
            this.aplicacaoPadrao = aplicacaoPadrao;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta newConta = null;
            if(cbCadTCon.Text == "Poupança")
            {
                newConta = new ContaPoupanca();
                newConta.TitularCartao = new Cliente();
                newConta.TitularCartao.Nome = tbCadTit.Text;
                newConta.Numero = Convert.ToInt32(tbCadNum.Text);
                newConta.Deposita(Convert.ToDouble(tbCadSald.Text));

            }
            else
            {
                newConta = new ContaCorrente();
                newConta.TitularCartao = new Cliente();
                newConta.TitularCartao.Nome = tbCadTit.Text;
                newConta.Numero = Convert.ToInt32(tbCadNum.Text);
                newConta.Deposita(Convert.ToDouble(tbCadSald.Text));
            }
            
            

            this.Visible = false;
            this.aplicacaoPadrao.adicionarConta(newConta);
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            cbCadTCon.Items.Add("Poupança");
            cbCadTCon.Items.Add("Corrente");
        }
    }
}
