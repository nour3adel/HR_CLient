namespace HR_ManagmentSystem_Client
{
    public partial class Dashboard : Form
    {
        #region Database Connection

        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";


        #endregion
        public Dashboard()
        {
            InitializeComponent();
        }

        #region FORM lOAD
        private void Dashboard_Load(object sender, EventArgs e)
        {





        }
        #endregion

        #region EXIT
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
            "Alert",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
