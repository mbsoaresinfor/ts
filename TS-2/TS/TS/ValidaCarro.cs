using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ValidaCarro
    {
        public bool validaCarro(Carro carro) 
        {
            
       
        if(carro.codigo < 0 ){
          return false;
        }

        if(carro.modelo.Length > 20) { 
            return false;
        }
        
        return true;
        
    }
}
}
