using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class MesTest
    {
        private Mes mes;

        [SetUp]
        public void setup()
        {
            mes = new Mes();
        }

        [Test]
        public void testvalidaMesValoresValidos_1() // 1 ,12
        {
            // arrange
            int entrada = 1;
            bool resultadoExperado = true;

            // act
            bool resultadoPrograma = mes.validaMes(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testvalidaMesValoresValidos_12() // 1 ,12
        {
            // arrange
            int entrada = 12;
            bool resultadoExperado = true;

            // act
            bool resultadoPrograma = mes.validaMes(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }


        [Test]
        public void testvalidaMesValoresInValidos_0()
        {
            // arrange
            int entrada = 0;
            bool resultadoExperado = false;

            // act
            bool resultadoPrograma = mes.validaMes(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testvalidaMesValoresInValidos_13()
        {
            // arrange
            int entrada = 13;
            bool resultadoExperado = false;

            // act
            bool resultadoPrograma = mes.validaMes(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

    }
}
