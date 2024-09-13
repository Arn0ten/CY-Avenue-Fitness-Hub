using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CY_Avenue_Fitness_Hub
{
    public partial class frmLogin : Form
    {
        private frmRegister FormRegister;
        private frmMain FormMain;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormRegister == null || FormRegister.IsDisposed)
            {
                FormRegister = new frmRegister();
                FormRegister.FormClosed += (s, args) => FormRegister = null;
            }
            this.Hide();
            FormRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (FormMain == null || FormMain.IsDisposed)
            {
                FormMain = new frmMain();
                FormMain.FormClosed += (s, args) => FormMain = null;
            }
            this.Hide();
            FormMain.ShowDialog();
        }
    }
}
