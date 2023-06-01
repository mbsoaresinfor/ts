using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class Repositorio : IRepositorio
    {
        /// <summary>
        /// se não conseguir salvar, vai gerar uma excessao
        /// </summary>
        public int salvar(Pessoa pessoa) 
        {
            // processametno do banco.
            Console.WriteLine("salvando no banco de dados REAL");
            if(pessoa.idade == -1)
            {
                throw new Exception("Error ao salvar a pessoa no db");
            }
            return 1;
        }
    }
}
