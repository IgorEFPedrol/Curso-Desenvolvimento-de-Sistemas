using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_EXTENSO;
using NUnit.Framework;

namespace TESTE_EXTENSO_TDD
{
    [TestFixture]
    public class TesteExtensoTDD
    {
        [TestCase("um", 1)]
        [TestCase("quatro", 4)]
        [TestCase("três", 3)]
        public void TestarUnidade( string esperado, int valor) {
            Assert.AreEqual(esperado, APIExtenso.Imprimir(valor));
        }
        [TestCase("dezenove", 19)]
        [TestCase("quarenta e dois", 42)]
        [TestCase("trinta e sete", 37)]
        public void TestarDezena( string esperado, int valor)
        {
            Assert.AreEqual("dezenove", APIExtenso.Imprimir(19));
        }
        [TestCase("cento e sessenta e cinco", 165)]
        [TestCase("setecentos e vinte e três", 723)]
        [TestCase("oitocentos e noventa e dois", 892)]
        public void TestarCentena( string esperado, int valor)
        {
            Assert.AreEqual(esperado, APIExtenso.Imprimir(valor));
        }
        [TestCase("dois mil, oitocentos e três", 2803)]
        [TestCase("quatro mil, quinhentos e noventa e um", 4591)]
        [TestCase("sete mil, setenta e três", 7073)]
        public void TestarMIlhar( string esperado, int valor)
        {
            Assert.AreEqual(esperado, APIExtenso.Imprimir(valor));
        }

    }
}
