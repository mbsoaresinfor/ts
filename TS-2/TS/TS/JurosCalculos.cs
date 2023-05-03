using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class JurosCalculos
    {
        public Boolean validar(int juros)
        {
            if(juros >= 5 && juros <= 20)
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
