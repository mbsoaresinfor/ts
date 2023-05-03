using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    class PessoaTest
    {
        [Test]
        public void testConcatenaNomeSobreNome()
        {
            String nome = "Pedro";
            String sobreNome = "Silva";
            Pessoa pessoa = new Pessoa();
            String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
            Assert.AreEqual("PedroSilva", resultadoPrograma);
        }

        [Test]
        public void testRetornaTamanhoTexto()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            String entrada = "casa";

            // act
            int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);
            int resultadoExperado = 4;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testRetornaTamanhoTextoComValorNULL()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            String entrada = null;

            // act
            int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);
            int resultadoExperado = -1;

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }




    }
}
