﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class Meses
    {
        public bool validaMes(int mes)
        {
            if (mes <= 0 || mes > 12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaMes30Dias(int dias)
        {
            if (dias <= 0 || dias > 30)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
