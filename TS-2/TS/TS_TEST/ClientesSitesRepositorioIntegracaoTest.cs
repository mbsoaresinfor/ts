using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS;

namespace TS_TEST
{
    public class ClientesSitesRepositorioIntegracaoTest
    {
        ClientesSitesRepositorio clientesSitesRepositorio;

        [SetUp]
        public void Setup()
        {
            clientesSitesRepositorio = new ClientesSitesRepositorio();
        }

        [Test]
        public void testListaClientesSitesEntidade()
        {
            // arrange
            // inserir dados na tablea clientes Sites

            // act
            int total = clientesSitesRepositorio.listarClientesSites(50).Count();

            // assert
            Assert.IsTrue(total > 0);
        }

        [Test]
        public void testdeletarClientesSites()
        {
            // arrange
            // insercao de um registo no banco de dados que o id é 166
            // insercao de um registo no banco de dados que o id é 171

            // act
            clientesSitesRepositorio.deletarClientesSites(166);
            clientesSitesRepositorio.deletarClientesSites(171);

            // assert
            Assert.IsNotNull(clientesSitesRepositorio.buscarClientesSitesPeloId(166));
            Assert.IsNotNull(clientesSitesRepositorio.buscarClientesSitesPeloId(171));
        }
    }
}
