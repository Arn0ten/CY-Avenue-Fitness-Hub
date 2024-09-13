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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Clear();
            frmDashboard Dashboard = new frmDashboard();
            Dashboard.TopLevel = false;
            Dashboard.Dock = DockStyle.Fill;
            pnlDisplay.Controls.Add(Dashboard);
            Dashboard.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Clear();
            frmRevenue Revenue = new frmRevenue();
            Revenue.TopLevel = false;
            Revenue.Dock = DockStyle.Fill;
            pnlDisplay.Controls.Add(Revenue);
            Revenue.Show();
        }
    }
}
