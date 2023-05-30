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
        public void testInserirClienteSites() { 

        }

        [Test]
        public void testListarClientesSites()
        {
            // arrange
            int total;            

            // act
            total = clientesSitesRepositorio.listarClientesSites(3).Count;

            // assert
            Assert.IsTrue(total > 0);
        }
    }
}
