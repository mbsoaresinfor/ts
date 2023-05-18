using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        public int persistir(Pessoa pessoa)
        {
            Console.WriteLine("persistindo pessoa");
            return 1;
        }
    }
}
