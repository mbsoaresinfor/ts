﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public interface IPessoaRepository
    {
        public int persistir(Pessoa pessoa);
    }
}