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
    public partial class DeletarConta : Form
    {
        
        private Form1 aplicacaoPadrao;
        public DeletarConta(Form1 aplicacaoPadrao)
        {
            this.aplicacaoPadrao = aplicacaoPadrao;
            InitializeComponent();
        }

        private void deletarConta_Load(object sender, EventArgs e)
        {
            
            lbDelCon.Text = "Para deletar a conta de " + aplicacaoPadrao.cbContas.Text + " por favor insira o numero de sua conta abaixo.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aplicacaoPadrao.tbNumeroConta.Text == tbConfDelet.Text)
            {
                Conta contaDelete = buscarConta();
                this.aplicacaoPadrao.excluirConta(contaDelete);
                this.Visible = false;
            }
        }

        public Conta buscarConta()
        {
            int indiceSelecionado = aplicacaoPadrao.cbContas.SelectedIndex;
            return aplicacaoPadrao.ListaConta[indiceSelecionado];
        }

    }
}
