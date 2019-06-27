using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            listaFinanciamento.Items.Clear();
            errorProvider1.Clear();

            //decimal inicial = decimal.Parse(recebeInicial.Text);
            //decimal jurosMensal = decimal.Parse(recebeJuros.Text);
            //int prazo = int.Parse(recebePrazo.Text);
            //decimal mensalidade = 0;
            //mensalidade = decimal.Parse(recebeValorPrestacao.Text);

            var erro = "";

            if (decimal.TryParse(recebeInicial.Text, out decimal inicial) == false)
            {
                errorProvider1.SetError(recebeInicial, "Erro");
                erro = "erro";
            }
            if (decimal.TryParse(recebeJuros.Text, out decimal jurosMensal) == false)
            {
                errorProvider1.SetError(recebeJuros, "Erro");
                erro = "erro";
            }
            if (decimal.TryParse(recebePrazo.Text, out decimal prazo)== false)
            {
                errorProvider1.SetError(recebePrazo, "Erro");
                erro = "erro";
            }
            if (decimal.TryParse(recebeValorPrestacao.Text, out decimal mensalidade) == false)
            {
                errorProvider1.SetError(recebeValorPrestacao, "Erro");
                erro = "erro";
            }

            if (erro != "erro")
            {
                for (int c = 0; c < prazo; c++)
                {
                    inicial += inicial * (jurosMensal / 100);

                    inicial = decimal.Round(inicial, 2);

                    listaFinanciamento.Items.Add("parcela " + (c + 1) + ":  R$" + inicial);

                    //resultado = resultado * 100M;
                    //resultado = Math.Truncate(resultado);
                    //resultado /= 100M;

                    resultado.Text = $"R$ + {inicial}";
                }

            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            listaFinanciamento.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recebeValorPrestacao.Clear();
            recebePrazo.Clear();
            recebeJuros.Clear();
            recebeInicial.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
    }
}
