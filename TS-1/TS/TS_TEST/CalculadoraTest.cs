using Moq;
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
        public void TestSubtrair()
        {
            int resultadoPrograma = calculadora.subtrair(3, 2);
            int resultadoExperado = 1;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestSubtrairComValorNegativo()
        {
            int resultadoPrograma = calculadora.subtrair(2, 3);
            int resultadoExperado = -1;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestSubtrairComValoresZero()
        {
            int resultadoPrograma = calculadora.subtrair(0, 0);
            int resultadoExperado = 0;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestMultipicacao()
        {
            int resultadoPrograma = calculadora.multiplicar(2, 5);
            int resultadoExperado = 10;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestMultipicacaoComValoresNegativos()
        {
            int resultadoPrograma = calculadora.multiplicar(-2, -5);
            int resultadoExperado = 10;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestMultipicacaoComValorZero()
        {
            int resultadoPrograma = calculadora.multiplicar(2, 0);
            int resultadoExperado = 0;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestDivisao()
        {
            int resultadoPrograma = calculadora.dividir(3, 3);
            int resultadoExperado = 1;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void TestDivisaoComDivisaoZero()
        {
            Assert.Throws<DivideByZeroException>(() => 
                    calculadora.dividir(5, 0));
            
        }

        [Test]
        public void TestSomarComMock()
        {
            // arrange
            Mock<ICalculadora> mock = new Mock<ICalculadora>();
            mock.Setup(m => m.somar(It.IsAny<int>(), It.IsAny<int>())).Returns(15);
            ICalculadora calculadora = mock.Object;
            int resultado;

            // act
            resultado = calculadora.somar(200, 35);

            // assert
            Assert.AreEqual(15, resultado);


        }


    }
}