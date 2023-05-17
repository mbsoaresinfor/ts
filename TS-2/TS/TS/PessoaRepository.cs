using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class PessoaRepository : IPessoaRepository
    {
        public int persistir(Pessoa pessoa)
        {
            if (pessoa.nome.Equals(""))
            {
                return -1;
            }
            return 1;
        }
    }
}
