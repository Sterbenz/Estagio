using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public abstract class  Conta
    {
        public int Numero { get; set; }
        public Cliente TitularCartao { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }

        }

        public virtual bool Saca(double saque)
        {
            if (saque > this.Saldo || saque < 0)
            {
                return false;
            }
            else
            {
                if (this.TitularCartao.ehMaiorDeIdade())
                {
                    this.Saldo -= saque;
                    return true;
                }
                else
                {
                    if (saque <= 200)
                    {
                        this.Saldo -= saque;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;

        }
        public override string ToString()
        {
            return TitularCartao.Nome;
        }

    }
}
