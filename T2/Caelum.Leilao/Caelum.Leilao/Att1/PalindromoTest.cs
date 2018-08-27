using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Att1
{

    [TestFixture]
    class PalindromoTest
    {
        [Test]
        public void Main()
        {
            Palindromo palavra = new Palindromo();
            

            
            Assert.AreEqual(true, palavra.EhPalindromo("arara"));
        }
    }
}
