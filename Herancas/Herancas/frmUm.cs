using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herancas
{
    public partial class frmUm : Form
    {
        public frmUm(string nomeUsuario)
        {
            InitializeComponent();
            frmUmApresentar.Text = nomeUsuario;
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //Fechar formulario
            this.Close();
        }

        private void frmUmApresentar_Click(object sender, EventArgs e)
        {

        }

        private void frmUm_Load(object sender, EventArgs e)
        {

        }
    }
}
