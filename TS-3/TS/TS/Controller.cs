using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    
    public class Controller
    {

        private IRepositorio repositorio = new Repositorio();

        public Controller(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public int salvarPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Iniciando processamento salvarPessoa");
            int resultado = 0;
            // algum processamento da controler.
            try
            {
                resultado = repositorio.salvar(pessoa);
                Console.WriteLine("SUCESSO salvarPessoa");
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR salvarPessoa");
                throw e;
            }            

            Console.WriteLine("Fim do processamento salvarPessoa");
            return resultado;

        }

    }
}
