using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    class TesteDoAvaliador
    {

        [Test]
        public void Main()
        {
            //1a parte: Cenario
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");
            Usuario Bob = new Usuario("Bob");
            Usuario Marley = new Usuario("Marley");
            Usuario Steav = new Usuario("Steav");
            Usuario Jon = new Usuario("Jon");
            Usuario Bills = new Usuario("Bills");
            Usuario Hohenhain = new Usuario("Hohenhain");
        
            Leilao leilao = new Leilao("Playstation 3 Novo");


            leilao.Propoe(new Lance(Bob, 400.0));                       
            leilao.Propoe(new Lance(Bills, 300.0));
            leilao.Propoe(new Lance(Marley, 200.0));
            leilao.Propoe(new Lance(Hohenhain, 100.0));


            //2a parte: acao
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //3a parte: validacao
            Assert.AreEqual(400, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(100, leiloeiro.MenorLance, 0.00001);

        }

        [Test]
        public void QuatroValores()
        {
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");
            Usuario Bob = new Usuario("Bob");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 405.0));
            leilao.Propoe(new Lance(jose, 395.0));
            leilao.Propoe(new Lance(joao, 200.0));
            leilao.Propoe(new Lance(Bob, 230.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            
            Assert.AreEqual(3, leiloeiro.TresMaiores.Count);
            Assert.AreEqual(405, leiloeiro.TresMaiores[0].Valor);
            Assert.AreEqual(395, leiloeiro.TresMaiores[1].Valor);
            Assert.AreEqual(230, leiloeiro.TresMaiores[2].Valor);

        }


        [Test]
        public void DoisValores()
        {
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");            

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(jose, 395.0));
            leilao.Propoe(new Lance(joao, 200.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(2, leiloeiro.TresMaiores.Count);
            Assert.AreEqual(395, leiloeiro.TresMaiores[0].Valor);
            Assert.AreEqual(200, leiloeiro.TresMaiores[1].Valor);


        }

        [Test]
        public void ListaNula()
        {          

            Leilao leilao = new Leilao("Playstation 3 Novo");          

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(0, leiloeiro.TresMaiores.Count);
           


        }
    }
}