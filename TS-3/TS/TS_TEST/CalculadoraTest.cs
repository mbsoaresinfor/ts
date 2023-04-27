using NUnit.Framework;
using System;
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

        [Test]
        public void TestSomarValoresNegativos()
        {
            int resultadoPrograma = calculadora.somar(-5, -5);
            int resultadoExperado = -10;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestSubtracao()
        {
            int resultadoPrograma = calculadora.subtrair(5, 3);
            int resultadoExperado = 2;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestSubtracaoNumerosNegativos()
        {
            int resultadoPrograma = calculadora.subtrair(-5, -3);
            int resultadoExperado = -2;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestMultiplicacao()
        {
            int resultadoPrograma = calculadora.multiplicar(5, 3);
            int resultadoExperado = 15;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestMultiplicacaoNumeroNegativos()
        {
            int resultadoPrograma = calculadora.multiplicar(-5, -3);
            int resultadoExperado = 15;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestDivisao()
        {
            int resultadoPrograma = calculadora.dividir(10, 2);
            int resultadoExperado = 5;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestDivisaoComZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
                    calculadora.dividir(5, 0));
        }

    }
}