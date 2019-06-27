using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        string _nome;
        string _idade;

        // definindo uma propriedade
        public string Nome
        {
            set
            {
                _nome = value;  
            }
            get
            {
                return _nome;
            }

            
        }
        public void Apresentar()
        {
            MessageBox.Show(_nome);
        }



    }
}
