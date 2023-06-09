﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public String concatenaNomeSobreNome(String nome, String sobreNome)
        {
            return nome + sobreNome;
        }

        public bool eMaiorIdade(int numero)
        {
            return numero >= 18 ? true : false;
        }

        public int retornaTamanhoTexto(String texto)
        {
            if(texto == null)
            {
                return -1;
            }
            return texto.Length;
        }


    }
}
