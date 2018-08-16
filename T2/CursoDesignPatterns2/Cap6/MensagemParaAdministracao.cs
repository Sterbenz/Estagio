using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    class MensagemParaAdministracao : IMensagem
    {
        private string nome;

        public IEnvia Enviador { get; set; }

        public MensagemParaAdministracao(string nome)
        {
            this.nome = nome;
        }

        public string Formata()
        {
            return String.Format("Mensagem administrativa para {0}", nome);
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }
    }
}
