using Magazine.Logic;
using System.Runtime.InteropServices;

namespace HR_ManagmentSystem_Client
{
    public partial class Test : Form
    {



        #region Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #endregion
        public Test()
        {
            InitializeComponent();
        }

        #region SignUp Form Load
        private void SignUp_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        #endregion

        #region Checkbox
        private void checkboxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region return button
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

        #region Password Toggle
        private void passtoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_toggle.CheckState == CheckState.Checked)
            {
                signup_pass.PasswordChar = false;
                signup_pass2.PasswordChar = false;

            }

            if (pass_toggle.CheckState == CheckState.Unchecked)
            {

                signup_pass.PasswordChar = true;
                signup_pass2.PasswordChar = true;
            }
        }

        #endregion


        #region Create Account
        private async void Createbtn_Click(object sender, EventArgs e)
        {
            // Retrieve form inputs
            string usrname = username.Texts.Trim();
            string firstName = Fname.Texts.Trim();
            string lastName = Lname.Texts.Trim();
            string password = signup_pass.Texts.Trim();
            string confirm_password = signup_pass2.Texts.Trim();
            string UserEmail = email.Texts.Trim();
            string UserAddress = address.Texts.Trim();
            string UserPhone = phonenumber.Texts.Trim();

            string fullname = $"{firstName} {lastName}";

            // Validate inputs
            if (string.IsNullOrWhiteSpace(UserEmail) ||
                string.IsNullOrWhiteSpace(usrname) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm_password) ||
                string.IsNullOrWhiteSpace(UserAddress) ||
                string.IsNullOrWhiteSpace(UserPhone) ||
                string.IsNullOrWhiteSpace(fullname) ||
    checkboxTerms.Checked == false)
            {
                RJMessageBox.Show("Make sure you correctly fill up the form.");
                return;
            }

            // Check password confirmation
            if (password != confirm_password)
            {
                RJMessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                var apiService = new ApiService("https://localhost:7130/api");
                var response = await apiService.RegisterAsync(fullname, usrname, password, UserEmail, UserAddress, UserPhone);

                if (response != null)
                {

                    if (response.Succeeded)
                    {
                        RJMessageBox.Show("Registration successful!");
                        Login form = new Login();
                        form.Show();
                        form.Owner = this;
                        this.Hide();
                    }
                    else
                    {
                        RJMessageBox.Show($"Registration failed: {response.message ?? "Invalid Password."}");
                    }
                }
                else
                {
                    RJMessageBox.Show("No response received from the server.");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        #endregion







        #region Signup Username
        private void signup_usr__TextChanged(object sender, EventArgs e)
        {
            if (username.Texts != string.Empty)
            {
                if (username.Texts.Length >= 8)
                {
                    username.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    username.BorderColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                username.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion


        #region already have ( Log in )
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

    }
}
