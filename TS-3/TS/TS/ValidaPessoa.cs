using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ValidaPessoa
    {
        public bool validar(Pessoa pessoa)
        {
            if(pessoa == null)
            {
                return false;
            }
            if(pessoa.nome == null || pessoa.nome.Equals(""))
            {
                return false;
            }
            if(pessoa.idade < 0 || pessoa.idade > 150)
            {
                return false;
            }
            return true;
        }

    }
}
