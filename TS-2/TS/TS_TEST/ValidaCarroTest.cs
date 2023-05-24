using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class ValidaCarroTest
    {

        [Test]
        public void testIdCArroOk()
        {
            // arrange
            ValidaCarro validaCarro = new ValidaCarro();
            Carro carro = criaCarro();
            carro.codigo = 1;
            bool resultadoExperado = true;
            bool resultadoPrograma;

            // act
            resultadoPrograma = validaCarro.validaCarro(carro);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);


        }

        [Test]
        public void testIdCArroError()
        {
            // arrange
            ValidaCarro validaCarro = new ValidaCarro();
            Carro carro = criaCarro();
            carro.codigo = -1;
            bool resultadoExperado = false;
            bool resultadoPrograma;

            // act
            resultadoPrograma = validaCarro.validaCarro(carro);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);


        }

        private Carro criaCarro()
        {
            Carro carro = new Carro();
            carro.codigo = 1;
            carro.modelo = "gol";
            return carro;
        }
    }
}
