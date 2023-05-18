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
    class ControlerPessoaTest
    {

        private ControllerPessoa controlerPessoa;

        [SetUp]
        public void Setup()
        {
            Mock<IRepositorioPessoa> mock = new Mock<IRepositorioPessoa>();
            mock.Setup(m => m.persistir(It.IsAny<Pessoa>())).Returns(5);
            controlerPessoa = new ControllerPessoa(mock.Object);
        }

        [Test]
        public void TestSalvarPessoaSucesso()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            int resultadoPrograma;

            // act
            resultadoPrograma = controlerPessoa.salvarPessoa(pessoa);

            // assert
            Assert.IsTrue(resultadoPrograma > 0);
            
        }

        [Test]
        public void TestSalvarPessoaError()
        {
            // arrange
            Pessoa pessoa = new Pessoa();            
            Mock<IRepositorioPessoa> mock = new Mock<IRepositorioPessoa>();
            mock.Setup(m => m.persistir(It.IsAny<Pessoa>())).Throws(new Exception("error"));
            controlerPessoa = new ControllerPessoa(mock.Object);

            // act,assert
            Assert.Throws<Exception>(() => controlerPessoa.salvarPessoa(pessoa));
            
        }
    }
}
