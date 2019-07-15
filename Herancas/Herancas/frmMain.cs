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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (nomeUsuario.Text == "")
            {
                MessageBox.Show("Nenhum nome foi inserido");
                return;
            }
                
            frmUm formulario = new frmUm(nomeUsuario.Text);
            MessageBox.Show($@"O nome de usuário digitado é:{nomeUsuario.Text}");
            formulario.ShowDialog();
        }

        private void Frm2_Click(object sender, EventArgs e)
        {
            frmDois frm2 = new frmDois();
            frm2.ShowDialog();
;        }

        private void Frm1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTexto_Click(object sender, EventArgs e)
        {

        }

        private void cmbTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNome.Text = cmbTexto.Text;
        }

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
