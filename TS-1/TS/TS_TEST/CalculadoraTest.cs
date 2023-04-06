using NUnit.Framework;
using TS;

namespace TS_TEST
{
    public class CalculadoraTest
    {
        Calculadora calculadora;

        [SetUp]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            int resultadoPrograma = calculadora.somar(5, 5);
            int resultadoExperado = 10;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }
    }
}