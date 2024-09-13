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
    public partial class frmRegister : Form
    {

        private frmLogin FormLogin;

        public frmRegister()
        {
            InitializeComponent();
        }


        private void llblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormLogin == null || FormLogin.IsDisposed)
            {
                FormLogin = new frmLogin();
                FormLogin.FormClosed += (s, args) => FormLogin = null;
            }
            this.Hide();
            FormLogin.ShowDialog();
        }

    }
}
