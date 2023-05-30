using System;
using System.Collections.Generic;

namespace TS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClientesSitesRepositorio clientesSitesRepositorio = new ClientesSitesRepositorio();
            List<ClientesSitesEntidade> listaclietesSistesEntidade =
                clientesSitesRepositorio.listarClientesSites(50);
            
            foreach(ClientesSitesEntidade clientesSitesEntidade in listaclietesSistesEntidade) { 
                Console.WriteLine(clientesSitesEntidade);
            }

            ClientesSitesEntidade cr = new ClientesSitesEntidade("marcelo barbosa soares","","");
            clientesSitesRepositorio.inserirClienteSites(cr);


        }
    }
}
