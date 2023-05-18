using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ClientesSitesEntidade
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }

        public ClientesSitesEntidade(string nome,string cpf, string email)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
        }

        public override string ToString()
        {
            return $"Nome {nome}, Cpf {cpf}, Email {email}";
        }

        public override bool Equals(object obj)
        {
            return obj is ClientesSitesEntidade entidade &&
                   nome == entidade.nome &&
                   cpf == entidade.cpf &&
                   email == entidade.email;
        }
    }
}
