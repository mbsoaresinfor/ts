using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class PessoaControllerTest
    {
        private PessoaController pessoaController;
        [SetUp]
        public void Setup()
        {

            Mock<IPessoaRepository> mock = new Mock<IPessoaRepository>();

            mock.Setup(m => m.persistir(It.IsAny<Pessoa>())).Returns(5);

            pessoaController = new PessoaController(mock.Object);
        }

        [Test]
        public void TestSalvarSucesso()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "teste";
            int resultado;

            // act
            resultado = pessoaController.salvar(pessoa);

            // assert
            Assert.IsTrue(resultado > 0);
        }

        [Test]
        public void TestSalvarError()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            Mock<IPessoaRepository> mock = new Mock<IPessoaRepository>();
            mock.Setup(m => m.persistir(It.IsAny<Pessoa>())).Returns(-1);
            pessoaController = new PessoaController(mock.Object);

            // act, assert
            Assert.Throws<Exception>(() =>
                     pessoaController.salvar(pessoa));
        }

        [Test]
        public void TestSalvarError2()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            Mock<IPessoaRepository> mock = new Mock<IPessoaRepository>();
            mock.Setup(m => m.persistir(It.IsAny<Pessoa>())).Throws(new Exception("error"));
            pessoaController = new PessoaController(mock.Object);

            // act, assert
            Assert.Throws<Exception>(() =>
                     pessoaController.salvar(pessoa));
        }

    }
}