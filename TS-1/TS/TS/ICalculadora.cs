using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public interface ICalculadora
    {
		public int somar(int a, int b);

		public int subtrair(int a, int b);

		public int dividir(int a, int b);

		public int multiplicar(int a, int b);
		
	}
}
