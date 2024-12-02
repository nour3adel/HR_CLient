using Magazine.Logic;
using System.Runtime.InteropServices;




namespace HR_ManagmentSystem_Client
{
    public partial class Users : Form
    {
        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion

        public Users()
        {
            InitializeComponent();

        }

        #region FORM LOAD
        private void USERSFORM_Load(object sender, EventArgs e)
        {

            label1.Text = sessionManager.Username.ToUpper();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); // make winform rounded

        }
        #endregion

        #region Exit BUTTON
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

        #region LogOut
        private void LogOut_Click(object sender, EventArgs e)
        {

            var result = RJMessageBox.Show("Log Out",
       "",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Login form = new Login();
                form.Show();
                form.Owner = this;
                this.Hide();
            }

        }
        #endregion

        #region profile
        private void Profile_Click(object sender, EventArgs e)
        {
            MyProfile frm = new MyProfile();

            openformpanel(frm);
        }
        #endregion


        #region My Orders
        private void Favorites_Click(object sender, EventArgs e)
        {
            MyOrder frm = new MyOrder();

            openformpanel(frm);
        }

        #endregion

        #region PanelControl
        private void openformpanel(Form form)
        {
            // Remove all controls from the panel
            this.ContainerPanel.Controls.Clear();

            // Add the new form to the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(form);
            this.ContainerPanel.Tag = form;
            form.Show();

        }


        #endregion

        #region Magazine List Button
        private void MagazineList_Click(object sender, EventArgs e)
        {
            Magazines frm = new Magazines();
            openformpanel(frm);
        }
        #endregion

        #region Category List Button
        private void button1_Click(object sender, EventArgs e)
        {
            CategoryLists frm = new CategoryLists();
            openformpanel(frm);
        }

        #endregion

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
