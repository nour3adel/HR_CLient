using System.Runtime.InteropServices;



namespace HR_ManagmentSystem_Client
{
    public partial class Recover : Form
    {

        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion

        #region Database information
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        #endregion
        public Recover()
        {
            InitializeComponent();
        }

        #region Recover Form Load
        private void Recover_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); // make winform rounded

        }
        #endregion

        #region Return
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

        #region Password Toggle
        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.CheckState == CheckState.Checked)
            {
                pass.PasswordChar = false;
                pass_confirm.PasswordChar = false;

            }

            if (rjToggleButton2.CheckState == CheckState.Unchecked)
            {

                pass.PasswordChar = true;
                pass_confirm.PasswordChar = true;
            }
        }
        #endregion

        #region OTP BUTTON
        private string generateOTP()
        {
            email.BorderColor = Color.FromArgb(0, 128, 0);
            //OTP generator
            string otp_char = "0123456789";
            OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {

                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                OTP += random_char;

            }
            return OTP;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {









        }
        #endregion

        #region  Recover BUTTON
        public string OTP;
        private void rjButton3_Click(object sender, EventArgs e)
        {

            if (email.Texts != string.Empty && pass.Texts != string.Empty && pass_confirm.Texts != string.Empty && OTPrec.Texts != string.Empty)
            {
                email.BorderColor = Color.FromArgb(0, 128, 0);
                if (OTPrec.Texts == OTP)
                {
                    OTPrec.BorderFocusColor = Color.FromArgb(0, 128, 0);
                    if (pass.Texts == pass_confirm.Texts)
                    {





                    }
                    else
                    {
                        pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
                        var result = RJMessageBox.Show("Password are not identical");
                    }
                }
                else
                {
                    OTPrec.BorderColor = Color.FromArgb(255, 0, 0);
                    var result = RJMessageBox.Show("Invalid OTP");
                }

            }


            else
            {
                var result = RJMessageBox.Show("Make sure you correctly fill up the form");
                email.BorderColor = Color.FromArgb(255, 0, 0);
            }


        }

        #endregion

        #region Email
        private void email__TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region OTP TEXTBOX
        private void OTP__TextChanged(object sender, EventArgs e)
        {

            if (OTPrec.Texts == OTP)
            {
                OTPrec.BorderColor = Color.FromArgb(0, 128, 0);
            }

        }
        #endregion

        #region New Password
        private void pass__TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region New Password Confirm
        private void pass_confirm__TextChanged(object sender, EventArgs e)
        {
            if (pass_confirm.Texts != string.Empty)
            {

                if (pass.Texts == pass_confirm.Texts)
                {
                    pass_confirm.BorderColor = Color.FromArgb(0, 128, 0);
                    pass.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
                }


            }
            else
            {
                pass_confirm.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion
    }
}
