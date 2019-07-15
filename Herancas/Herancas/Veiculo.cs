using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herancas
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int Cavalos { get; set; }
        public string PressaoPneus { get; set; }
        public abstract void Acelerar();

    }
}
