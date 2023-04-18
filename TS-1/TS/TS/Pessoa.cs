using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class Pessoa
    {

        public String concatenaNomeSobreNome(String nome, String sobreNome)
        {
            return nome + sobreNome ;
        }

        public Boolean eMaiorIdade(int idade)
        {
            if(idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
