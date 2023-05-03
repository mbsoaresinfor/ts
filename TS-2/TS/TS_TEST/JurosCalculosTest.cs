using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    class JurosCalculosTest
    {

        JurosCalculos jurosCalculos;

        [SetUp]
        public void setup()
        {
            jurosCalculos = new JurosCalculos();
        }

        [Test]
        public void testvalidarComValoresValidos()
        {
            // arrange            
            int  entrada = 5;

            // act
            Boolean resultadoPrograma = jurosCalculos.validar(entrada);
            Boolean resultadoExperado = true;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            // ----------------

            // arrange
            entrada = 20;
            
            // act
             resultadoPrograma = jurosCalculos.validar(entrada);
             resultadoExperado = true;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);


        }

        [Test]
        public void testvalidarComValoresInValidos()
        {
            // arrange            
            int entrada = 4;

            // act
            Boolean resultadoPrograma = jurosCalculos.validar(entrada);
            Boolean resultadoExperado = false;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            // ----------------

            // arrange
            entrada = 21;

            // act
            resultadoPrograma = jurosCalculos.validar(entrada);
            resultadoExperado = false;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);


        }




    }
}
