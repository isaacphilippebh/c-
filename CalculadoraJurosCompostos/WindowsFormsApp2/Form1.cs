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
            float inicial = float.Parse(recebeInicial.Text);
            float jurosMensal = float.Parse(recebeJuros.Text);
            int prazo = int.Parse(recebePrazo.Text);
            float mensalidade = 0;
            mensalidade = float.Parse(recebeValorPrestacao.Text);
            listaFinanciamento.Items.Clear();


            for (int c = 0; c  < prazo;  c++)
            {
                inicial += inicial * (jurosMensal / 100) - mensalidade;
                listaFinanciamento.Items.Add("parcela " + (c+1) + ":  R$" + inicial);
                
                resultado.Text = "R$" + inicial.ToString();
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
    }
}
