namespace CY_Avenue_Fitness_Hub
{
    public partial class LoadingForm : Form
    {
        frmLogin FormLogin = new frmLogin();
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrLoading.Start();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if(prgLoading.Value < 100)
            {
                prgLoading.Value += 5;
                lblPercent.Text = prgLoading.Value.ToString() + "%";
            }
            else
            {
                tmrLoading.Stop();
                this.Hide();
                FormLogin.ShowDialog();
            }           
        }
    }
}
