using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ValidadorPessoa
    {
        public void validar(Pessoa pessoa)
        {
            if(pessoa == null)
            {
                throw new Exception("pessoa esta null");
            }

            if(pessoa.nome == null || pessoa.nome.Equals(""))
            {
                throw new Exception("Nome da pessoa esta invalida (null ou vazio)");
            }

            if(pessoa.idade < 0 || pessoa.idade > 150)
            {
                throw new Exception("Idade invalida, valores validos sao [0 -- 150]");
            }

            if (pessoa.endereco == null || pessoa.endereco.Equals(""))
            {
                throw new Exception("Endereco da pessoa esta invalida (null ou vazio)");
            }
        }
    }
}
