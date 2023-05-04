using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class ValidaPessoaTest
    {
        private ValidaPessoa validaPessoa;

        [SetUp]
        public void setup()
        {
            validaPessoa = new ValidaPessoa();
        }

        [Test]
        public void testVAlidarNomeVazio()
        {
            // arrange
            Pessoa pessoa = criaPessoaValida();
            pessoa.nome = "";
            bool resultadoExperado = false;

            // act
            bool resultadoPrograma = validaPessoa.validar(pessoa);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testVAlidarIdadeComError()
        {
            // arrange
            Pessoa pessoa = criaPessoaValida();
            pessoa.idade = -1;
            bool resultadoExperado = false;

            // act
            bool resultadoPrograma = validaPessoa.validar(pessoa);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }

        [Test]
        public void testVAlidarPessoaValida()
        {
            // arrange
            Pessoa pessoa = criaPessoaValida();            
            bool resultadoExperado = true;

            // act
            bool resultadoPrograma = validaPessoa.validar(pessoa);

            // assert
            Assert.AreEqual(resultadoExperado, resultadoPrograma);
        }


        private Pessoa criaPessoaValida()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "marcelo";
            pessoa.idade = 40;
            return pessoa;
        }

    }
}
