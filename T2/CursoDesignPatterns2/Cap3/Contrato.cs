using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoDeContrato Tipo { get; private set; }

        public Contrato(DateTime data, String cliente, TipoDeContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (this.Tipo == TipoDeContrato.Novo) this.Tipo = TipoDeContrato.EmAndamento;
            else if (this.Tipo == TipoDeContrato.EmAndamento) this.Tipo = TipoDeContrato.Acertado;
            else if (this.Tipo == TipoDeContrato.Acertado) this.Tipo = TipoDeContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }

    }
}
