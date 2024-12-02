namespace HR_ManagmentSystem_Client
{
    public partial class CategoryLists : Form
    {

        #region Databsae Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";



        #endregion

        public CategoryLists()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            roundedButton4.Visible = false;
        }

        #endregion





        #region EXIT
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
                "Alert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
