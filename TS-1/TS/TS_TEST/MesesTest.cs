using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    class MesesTest
    {
        // 1-12 part. valida
        // negativso invalida
        // numeros pos. acima de 12 invalida
        [Test]
        public void testValoresValidos()
        {
            Meses meses = new Meses();
            bool resultadoPrograma = meses.validaMes(1);
            bool resultadoExperado = true;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            resultadoPrograma = meses.validaMes(12);
            resultadoExperado = true;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testValoresInValidos()
        {
            Meses meses = new Meses();
            bool resultadoPrograma = meses.validaMes(0);
            bool resultadoExperado = false;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            resultadoPrograma = meses.validaMes(13);
            resultadoExperado = false;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testValoresMeses30diasValidos()
        {
            Meses meses = new Meses();
            bool resultadoPrograma = meses.validaMes30Dias(1);
            bool resultadoExperado = true;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            resultadoPrograma = meses.validaMes30Dias(30);
            resultadoExperado = true;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testValoresMeses30diasInValidos()
        {
            Meses meses = new Meses();
            bool resultadoPrograma = meses.validaMes30Dias(0);
            bool resultadoExperado = false;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);

            resultadoPrograma = meses.validaMes30Dias(31);
            resultadoExperado = false;
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

    }
}
