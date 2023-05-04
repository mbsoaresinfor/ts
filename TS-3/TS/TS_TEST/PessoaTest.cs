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
        public void testConcatenaNomeSobreNomeVazio()
        {
            String nome = String.Empty;
            String sobreNome = String.Empty;
            Pessoa pessoa = new Pessoa();
            String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
            Assert.AreEqual(String.Empty, resultadoPrograma);
        }

        [Test]
        public void testConcatenaNomeSobreNomeComNull()
        {
            String nome = null;
            String sobreNome = null;
            Pessoa pessoa = new Pessoa();
            String resultadoPrograma = pessoa.concatenaNomeSobreNome(nome, sobreNome);
            Assert.AreEqual(String.Empty, resultadoPrograma);
        }

        [Test]
        public void testeMaiorIdadeComValorMaior18()
        {
            Pessoa pessoa = new Pessoa();
            bool resultadoPrograma = pessoa.eMaiorIdade(18);
            Assert.IsTrue(resultadoPrograma);
        }

        [Test]
        public void testeMaiorIdadeComValorMenor18()
        {
            // arrange
            Pessoa pessoa = new Pessoa();

            // ack
            bool resultadoPrograma = pessoa.eMaiorIdade(17);

            // assert
            Assert.IsFalse(resultadoPrograma);
        }


        [Test]
        public void testeretornaTamanhoTextoValorOk()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            String entrada = "casa";
            int resultadoExperado = 4;

            // ack
            int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testeretornaTamanhoTextoValorVazio()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            String entrada = "";
            int resultadoExperado = 0;

            // ack
            int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testeretornaTamanhoTextoValorNull()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            String entrada = null;
            int resultadoExperado = -1;

            // ack
            int resultadoPrograma = pessoa.retornaTamanhoTexto(entrada);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }


    }
}
