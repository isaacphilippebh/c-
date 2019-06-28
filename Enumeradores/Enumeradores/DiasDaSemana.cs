using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    class DiasDaSemana
    {
        public enum Dia
        {
            Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
        }
        public void ApresentarDia(Dia diaSemana)
        {
            Console.WriteLine(diaSemana);
        }
    }
}
