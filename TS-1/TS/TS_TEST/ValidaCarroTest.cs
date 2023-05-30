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
        public void testIdValidoOk()
        {
            // arrange
            Carro carro = new Carro();
            carro.codigo = 1;
            ValidaCarro validaCarro = new ValidaCarro();
            bool resultadoExperado = true;
            bool resultadoPrograma = true;

            // act
            resultadoPrograma = validaCarro.validaCarro(carro);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

        }

        [Test]
        public void testIdValidoError()
        {
            // arrange
            Carro carro = criaCarro();
            carro.codigo = -1;
            ValidaCarro validaCarro = new ValidaCarro();
            bool resultadoExperado = false;
            bool resultadoPrograma ;

            // act
            resultadoPrograma = validaCarro.validaCarro(carro);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

        }

        private Carro criaCarro()
        {
            Carro carro = new Carro();
            carro.modelo = "gol gti";
            carro.codigo = 1;
            return carro;
        }
    }
}
