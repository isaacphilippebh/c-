using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void executar_Click(object sender, EventArgs e)
        {
            decimal vl1 = decimal.Parse(recebeValor1.Text);
            decimal vl2 = decimal.Parse(recebeValor2.Text);
            decimal resultado;

            Matematica calculadora = new Matematica();
            resultado = calculadora.Adicao(vl1, vl2);


            lista.Items.Add($" {vl1} + {vl2} = {resultado} ");


            cxtxt.Text =  $" O resultado é:  {resultado}";


        }

        private void valor2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
