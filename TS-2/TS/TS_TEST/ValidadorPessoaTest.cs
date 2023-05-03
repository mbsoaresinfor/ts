using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class ValidadorPessoaTest
    {
        private ValidadorPessoa validadorPessoa;

        [SetUp]
        public void setup()
        {
            validadorPessoa = new ValidadorPessoa();
        }

        [Test ]
        public void validaPessoaComIdadeInvalida()
        {
            // arrange
            Pessoa pessoa = criaPessoa();
            pessoa.idade = 151;

            // ack, assert
            Assert.Throws<Exception>(() =>
                     validadorPessoa.validar(pessoa));

        }

        [Test]
        public void validaPessoaComNomeInvalida()
        {
            // arrange
            Pessoa pessoa = criaPessoa();
            pessoa.nome = null;

            // ack, assert
            Assert.Throws<Exception>(() =>
                     validadorPessoa.validar(pessoa));

        }

        [Test]
        public void validaPessoaComEnderecoInvalida()
        {
            // arrange
            Pessoa pessoa = criaPessoa();
            pessoa.endereco = null;

            // ack, assert
            Assert.Throws<Exception>(() =>
                     validadorPessoa.validar(pessoa));

        }

        [Test]
        public void validaPessoaValida()
        {
            // arrange
            Pessoa pessoa = criaPessoa();            

            // ack, assert
            validadorPessoa.validar(pessoa);

        }



        private Pessoa criaPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.endereco = "cachoerinha";
            pessoa.idade = 100;
            pessoa.nome = "marcelo";
            return pessoa;
        }



    }
}
