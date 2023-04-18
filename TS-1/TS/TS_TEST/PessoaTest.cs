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
        public void testEMaiorIdade() {
            int entrada = 18;
            Pessoa pessoa = new Pessoa();
            Boolean resutladoPrograma = pessoa.eMaiorIdade(entrada);
            Assert.AreEqual(true, resutladoPrograma);
        }

        [Test]
        public void testEMaiorIdadeComValorAbaixo18()
        {
            int entrada = 17;
            Pessoa pessoa = new Pessoa();
            Boolean resutladoPrograma = pessoa.eMaiorIdade(entrada);
            Assert.AreEqual(false, resutladoPrograma);
        }


    }
}
