using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herancas
{
    class Carro : Veiculo
    {
        public int qtd_portas { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("O Carro acelerou !");
        }
    }
}
