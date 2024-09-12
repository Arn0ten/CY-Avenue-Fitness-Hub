namespace CY_Avenue_Fitness_Hub
{
    public partial class LoadingForm : Form
    {
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
                prgLoading.Value += 1;

                lblPercent.Text = prgLoading.Value.ToString() + "%";
            }
            else
            {
                tmrLoading.Stop();
            }
        }
    }
}
