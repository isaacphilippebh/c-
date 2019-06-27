using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teste obj = new Teste();
            int valor = 10;
            obj.Subtracao(ref valor);
            label1.Text = valor.ToString();
            obj.Nome = "Isaac Philippe";
            obj.Apresentar();

        }
    }
}
