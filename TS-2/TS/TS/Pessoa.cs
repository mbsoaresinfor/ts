using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class Pessoa
    {
        public String nome;
        public int idade;
        public string endereco;


        public String concatenaNomeSobreNome(String nome, String sobreNome)
        {
            return nome + sobreNome ;
        }

        public int retornaTamanhoTexto(String texto)
        {
            if(texto == null)
            {
                return -1;
            }
            else { 
                return texto.Length;
            }
        }


    }
}
