namespace HR_ManagmentSystem_Client
{
    public partial class MyProfile : Form
    {

        #region Database information

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";


        #endregion

        public MyProfile()
        {

            InitializeComponent();
        }

        #region FORM LOAD
        private void MyProfile_Load(object sender, EventArgs e)
        {
            DisplayProfile();
        }
        #endregion

        #region Display Profile
        void DisplayProfile()
        {
            try
            {



            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Update Profile
        private void UpdateUserData()
        {
            string str = Login.Instance.username;

            try
            {

            }
            catch (Exception ex)
            {
                var result = RJMessageBox.Show("Error updating user data: " + ex.Message);
            }
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

        #region Edit Button
        private void rjButton3_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        #endregion

    }
}
