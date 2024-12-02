using System.Runtime.InteropServices;

namespace HR_ManagmentSystem_Client
{
    public partial class SignUp : Form
    {



        #region Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #endregion
        public SignUp()
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

        #region create account 
        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (email.Texts != string.Empty && signup_usr.Texts != string.Empty && signup_pass.Texts != string.Empty && signup_pass2.Texts != string.Empty)
            {





            }
            else
            {
                var result = RJMessageBox.Show("Make sure you correctly fill up the form");
            }
        }

        #endregion

        #region Signup email
        private void email__TextChanged(object sender, EventArgs e)
        {
            if (email.Texts != string.Empty)
            {
                if (email.Texts.EndsWith(".com"))
                {
                    email.BorderColor = Color.FromArgb(0, 128, 0);
                }


            }
            else
            {
                email.BorderColor = Color.FromArgb(255, 0, 0);

            }
        }

        #endregion

        #region Signup Username
        private void signup_usr__TextChanged(object sender, EventArgs e)
        {
            if (signup_usr.Texts != string.Empty)
            {
                if (signup_usr.Texts.Length >= 8)
                {
                    signup_usr.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    signup_usr.BorderColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                signup_usr.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion

        #region Signup Password
        private void signup_pass__TextChanged(object sender, EventArgs e)
        {
            if (signup_pass.Texts != string.Empty)
            {
                if (signup_pass.Texts.Length >= 8)
                {
                    signup_pass.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    signup_pass.BorderColor = Color.FromArgb(255, 0, 0);
                    signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);

                }



            }
            else
            {
                signup_pass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }
        #endregion

        #region Signup Password Confirm
        private void signup_pass2__TextChanged(object sender, EventArgs e)
        {
            if (signup_pass2.Texts != string.Empty)
            {
                if (signup_pass.Texts.Length >= 8)
                {
                    if (signup_pass2.Texts == signup_pass.Texts)
                    {
                        signup_pass2.BorderColor = Color.FromArgb(0, 128, 0);

                    }
                    else
                    {
                        signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);
                    }
                }
                else
                {
                    signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);

                }


            }
            else
            {
                signup_pass2.BorderColor = Color.FromArgb(255, 0, 0);
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
