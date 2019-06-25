using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        int valor_inicial = 1000;
     

        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Botão executar da aplicação
        private void btn_executar_Click(object sender, EventArgs e)
        {
         

            caixa_texto.Text = "Tenho o seguinte valor: " + valor_inicial.ToString();
        }

        private void Close_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_100_Click(object sender, EventArgs e)
        {
            int valor_total = 100;
            int isaac = 12;
            int valor_somado100 = valor_inicial + 100;
            caixa_texto.Text = "Tenho o seguinte valor: " + Valor_total.ToString();
        }
    }
}
