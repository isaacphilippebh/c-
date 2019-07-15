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
    public partial class NewContact : Form
    {
        public NewContact(Form Pai)
        {
            InitializeComponent();
            MdiParent = Pai;
        }

        private void NewContact_Load(object sender, EventArgs e)
        {
            frmMain principal = new frmMain();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
