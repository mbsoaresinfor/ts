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
            Pessoa pessoa = new Pessoa();
            bool resultadoPrograma = pessoa.eMaiorIdade(17);
            Assert.IsFalse(resultadoPrograma);
        }

    }
}
