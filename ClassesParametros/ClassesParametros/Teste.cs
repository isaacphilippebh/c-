using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParametros
{
    class Teste
    {
        public void Soma(ref int valor)
        {
            valor += 5;
        }
        public void Subtracao(ref int valor)
        {
            valor -= 5;
        }
    }
}
