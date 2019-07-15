using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContact n = new NewContact(this);
            n.Show();
        }
    }
}
