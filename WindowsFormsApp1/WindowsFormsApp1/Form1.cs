using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textNu1.Text);
            int numero2 = int.Parse(textNu2.Text);
            int resultado;

            resultado = numero1 * numero2;
            textResultado.Text = resultado.ToString();
        }

        private void btnDivideZero_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textNu1.Text);
            int numero2 = int.Parse(textNu2.Text);
            float resultado;
            float resultadoTotal;

            resultado = numero1 % numero2;
            resultadoTotal = numero1 / numero2;

            //if (resultado != 0)
            //{
            //    textResultado.Text = "O número não é divisível pelo outro o resto é: " + resultado.ToString();
            //    textTotal.Text = resultadoTotal.ToString();
            //}
            //else
            //{
            //    textResultado.Text = "O número é divisível pelo outro";
            //    textTotal.Text = resultadoTotal.ToString();
            //}

            textResultado.Text = resultado != 0? "O número não é divisível pelo outro, o resto é: " + resultado.ToString() : "O número é divisível pelo outro e seu resto é 0";
            textTotal.Text = resultadoTotal.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
