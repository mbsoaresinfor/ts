using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ControllerPessoa
    {
        private IRepositorioPessoa repositorioPessoa = new RepositorioPessoa();

        public ControllerPessoa(IRepositorioPessoa repositorioPessoa)
        {
            this.repositorioPessoa = repositorioPessoa;
        }

        public int salvarPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Processando salvar pessoa");
            int retorno = repositorioPessoa.persistir(pessoa);
            return retorno;
        }
    }
}
