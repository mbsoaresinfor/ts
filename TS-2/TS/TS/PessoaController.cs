using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class PessoaController
    {
        private IPessoaRepository pessoaRepository = new PessoaRepository();

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }

        public int salvar(Pessoa pessoa)
        {
            Console.WriteLine("processando salvar pessoa");
            int retorno = 0;
            
            retorno = pessoaRepository.persistir(pessoa);
            
            if(retorno == -1)
            {
                throw new Exception("error");
            }            
            
            Console.WriteLine("fim salvar pessoa");
            return retorno;
        }
        public MyActionResult salvar2(Pessoa pessoa)
        {
            return new MyActionResult();
        }

    }
}
