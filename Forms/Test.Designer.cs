namespace HR_ManagmentSystem_Client
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pass_toggle = new CustomControls.RJControls.RJToggleButton();
            signup_pass2 = new CustomControls.RJControls.RJTextBox();
            signup_pass = new CustomControls.RJControls.RJTextBox();
            username = new CustomControls.RJControls.RJTextBox();
            email = new CustomControls.RJControls.RJTextBox();
            lblCreate = new Label();
            lblNote = new Label();
            checkboxTerms = new CheckBox();
            linkSignIn = new LinkLabel();
            Createbtn = new CustomControls.RJControls.RJButton();
            hoverButton4 = new HoverButton();
            Fname = new CustomControls.RJControls.RJTextBox();
            address = new CustomControls.RJControls.RJTextBox();
            phonenumber = new CustomControls.RJControls.RJTextBox();
            Lname = new CustomControls.RJControls.RJTextBox();
            SuspendLayout();
            // 
            // pass_toggle
            // 
            pass_toggle.AutoSize = true;
            pass_toggle.BackColor = Color.Transparent;
            pass_toggle.Cursor = Cursors.Hand;
            pass_toggle.ForeColor = Color.Transparent;
            pass_toggle.Location = new Point(375, 408);
            pass_toggle.Margin = new Padding(4, 3, 4, 3);
            pass_toggle.MinimumSize = new Size(41, 23);
            pass_toggle.Name = "pass_toggle";
            pass_toggle.OffBackColor = Color.Gray;
            pass_toggle.OffToggleColor = Color.Gainsboro;
            pass_toggle.OnBackColor = Color.MediumSlateBlue;
            pass_toggle.OnToggleColor = Color.WhiteSmoke;
            pass_toggle.Size = new Size(41, 23);
            pass_toggle.TabIndex = 49;
            pass_toggle.UseVisualStyleBackColor = false;
            pass_toggle.CheckedChanged += passtoggle_CheckedChanged;
            // 
            // signup_pass2
            // 
            signup_pass2.BackColor = Color.White;
            signup_pass2.BorderColor = Color.Black;
            signup_pass2.BorderFocusColor = Color.BlueViolet;
            signup_pass2.BorderRadius = 12;
            signup_pass2.BorderSize = 1;
            signup_pass2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pass2.ForeColor = Color.DimGray;
            signup_pass2.Location = new Point(462, 390);
            signup_pass2.Margin = new Padding(5);
            signup_pass2.MinimumSize = new Size(0, 58);
            signup_pass2.Multiline = false;
            signup_pass2.Name = "signup_pass2";
            signup_pass2.Padding = new Padding(14, 14, 8, 8);
            signup_pass2.PasswordChar = false;
            signup_pass2.PlaceholderColor = Color.DarkGray;
            signup_pass2.PlaceholderText = "Confirm Password";
            signup_pass2.Size = new Size(386, 58);
            signup_pass2.TabIndex = 48;
            signup_pass2.Texts = "";
            signup_pass2.UnderlinedStyle = false;
            // 
            // signup_pass
            // 
            signup_pass.BackColor = Color.White;
            signup_pass.BorderColor = Color.Black;
            signup_pass.BorderFocusColor = Color.BlueViolet;
            signup_pass.BorderRadius = 12;
            signup_pass.BorderSize = 1;
            signup_pass.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pass.ForeColor = Color.DimGray;
            signup_pass.Location = new Point(45, 390);
            signup_pass.Margin = new Padding(5);
            signup_pass.MinimumSize = new Size(0, 58);
            signup_pass.Multiline = false;
            signup_pass.Name = "signup_pass";
            signup_pass.Padding = new Padding(14, 14, 8, 8);
            signup_pass.PasswordChar = true;
            signup_pass.PlaceholderColor = Color.DarkGray;
            signup_pass.PlaceholderText = "CreatePassword";
            signup_pass.Size = new Size(386, 58);
            signup_pass.TabIndex = 47;
            signup_pass.Texts = "";
            signup_pass.UnderlinedStyle = false;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderColor = Color.Black;
            username.BorderFocusColor = Color.BlueViolet;
            username.BorderRadius = 12;
            username.BorderSize = 1;
            username.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.DimGray;
            username.Location = new Point(45, 306);
            username.Margin = new Padding(5);
            username.MinimumSize = new Size(0, 58);
            username.Multiline = false;
            username.Name = "username";
            username.Padding = new Padding(14, 14, 8, 8);
            username.PasswordChar = false;
            username.PlaceholderColor = Color.DarkGray;
            username.PlaceholderText = "Create Username";
            username.Size = new Size(386, 58);
            username.TabIndex = 50;
            username.Texts = "";
            username.UnderlinedStyle = false;
            username._TextChanged += signup_usr__TextChanged;
            // 
            // email
            // 
            email.BackColor = Color.White;
            email.BorderColor = Color.Black;
            email.BorderFocusColor = Color.BlueViolet;
            email.BorderRadius = 12;
            email.BorderSize = 1;
            email.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.ForeColor = Color.DimGray;
            email.Location = new Point(462, 306);
            email.Margin = new Padding(5);
            email.MinimumSize = new Size(0, 58);
            email.Multiline = false;
            email.Name = "email";
            email.Padding = new Padding(14, 14, 8, 8);
            email.PasswordChar = false;
            email.PlaceholderColor = Color.DarkGray;
            email.PlaceholderText = "Enter Email";
            email.Size = new Size(386, 58);
            email.TabIndex = 51;
            email.Texts = "";
            email.UnderlinedStyle = false;
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblCreate.Location = new Point(262, 62);
            lblCreate.Margin = new Padding(4, 0, 4, 0);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(345, 44);
            lblCreate.TabIndex = 52;
            lblCreate.Text = "Create an account";
            // 
            // lblNote
            // 
            lblNote.BackColor = Color.Transparent;
            lblNote.Font = new Font("Microsoft Sans Serif", 12F);
            lblNote.ForeColor = Color.Gray;
            lblNote.Location = new Point(244, 125);
            lblNote.Margin = new Padding(4, 0, 4, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(400, 67);
            lblNote.TabIndex = 53;
            lblNote.Text = "Please fill up the neccessary information to create your account";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkboxTerms
            // 
            checkboxTerms.AutoSize = true;
            checkboxTerms.Cursor = Cursors.Hand;
            checkboxTerms.Location = new Point(244, 589);
            checkboxTerms.Margin = new Padding(4, 3, 4, 3);
            checkboxTerms.Name = "checkboxTerms";
            checkboxTerms.Size = new Size(238, 19);
            checkboxTerms.TabIndex = 54;
            checkboxTerms.Text = "I agree to all the Term and Privacy Policy";
            checkboxTerms.UseVisualStyleBackColor = true;
            checkboxTerms.CheckedChanged += checkboxTerms_CheckedChanged;
            // 
            // linkSignIn
            // 
            linkSignIn.AutoSize = true;
            linkSignIn.Cursor = Cursors.Hand;
            linkSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSignIn.LinkColor = Color.Black;
            linkSignIn.Location = new Point(316, 702);
            linkSignIn.Margin = new Padding(4, 0, 4, 0);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(246, 20);
            linkSignIn.TabIndex = 55;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "Already have an account? Sign In";
            linkSignIn.LinkClicked += linkSignIn_LinkClicked;
            // 
            // Createbtn
            // 
            Createbtn.BackColor = Color.FromArgb(255, 128, 128);
            Createbtn.BackgroundColor = Color.FromArgb(255, 128, 128);
            Createbtn.BorderColor = Color.PaleVioletRed;
            Createbtn.BorderRadius = 15;
            Createbtn.BorderSize = 0;
            Createbtn.Cursor = Cursors.Hand;
            Createbtn.FlatAppearance.BorderSize = 0;
            Createbtn.FlatStyle = FlatStyle.Flat;
            Createbtn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Createbtn.ForeColor = Color.White;
            Createbtn.Location = new Point(245, 628);
            Createbtn.Margin = new Padding(4, 3, 4, 3);
            Createbtn.Name = "Createbtn";
            Createbtn.Size = new Size(399, 62);
            Createbtn.TabIndex = 56;
            Createbtn.Text = "Create account";
            Createbtn.TextColor = Color.White;
            Createbtn.UseVisualStyleBackColor = false;
            Createbtn.Click += Createbtn_Click;
            // 
            // hoverButton4
            // 
            hoverButton4.FlatAppearance.BorderSize = 0;
            hoverButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton4.FlatStyle = FlatStyle.Flat;
            hoverButton4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton4.HoverColor = Color.Chocolate;
            hoverButton4.Location = new Point(851, 15);
            hoverButton4.Margin = new Padding(4, 3, 4, 3);
            hoverButton4.Name = "hoverButton4";
            hoverButton4.Size = new Size(33, 35);
            hoverButton4.TabIndex = 57;
            hoverButton4.Text = "▶";
            hoverButton4.UseVisualStyleBackColor = true;
            hoverButton4.Click += hoverButton4_Click;
            // 
            // Fname
            // 
            Fname.BackColor = Color.White;
            Fname.BorderColor = Color.Black;
            Fname.BorderFocusColor = Color.BlueViolet;
            Fname.BorderRadius = 12;
            Fname.BorderSize = 1;
            Fname.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fname.ForeColor = Color.DimGray;
            Fname.Location = new Point(45, 221);
            Fname.Margin = new Padding(5);
            Fname.MinimumSize = new Size(0, 58);
            Fname.Multiline = false;
            Fname.Name = "Fname";
            Fname.Padding = new Padding(14, 14, 8, 8);
            Fname.PasswordChar = false;
            Fname.PlaceholderColor = Color.DarkGray;
            Fname.PlaceholderText = "Enter First Name";
            Fname.Size = new Size(386, 58);
            Fname.TabIndex = 58;
            Fname.Texts = "";
            Fname.UnderlinedStyle = false;
            // 
            // address
            // 
            address.BackColor = Color.White;
            address.BorderColor = Color.Black;
            address.BorderFocusColor = Color.BlueViolet;
            address.BorderRadius = 12;
            address.BorderSize = 1;
            address.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.ForeColor = Color.DimGray;
            address.Location = new Point(45, 486);
            address.Margin = new Padding(5);
            address.MinimumSize = new Size(0, 58);
            address.Multiline = false;
            address.Name = "address";
            address.Padding = new Padding(14, 14, 8, 8);
            address.PasswordChar = false;
            address.PlaceholderColor = Color.DarkGray;
            address.PlaceholderText = "Enter Address";
            address.Size = new Size(386, 58);
            address.TabIndex = 59;
            address.Texts = "";
            address.UnderlinedStyle = false;
            // 
            // phonenumber
            // 
            phonenumber.BackColor = Color.White;
            phonenumber.BorderColor = Color.Black;
            phonenumber.BorderFocusColor = Color.BlueViolet;
            phonenumber.BorderRadius = 12;
            phonenumber.BorderSize = 1;
            phonenumber.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonenumber.ForeColor = Color.DimGray;
            phonenumber.Location = new Point(462, 486);
            phonenumber.Margin = new Padding(5);
            phonenumber.MinimumSize = new Size(0, 58);
            phonenumber.Multiline = false;
            phonenumber.Name = "phonenumber";
            phonenumber.Padding = new Padding(14, 14, 8, 8);
            phonenumber.PasswordChar = false;
            phonenumber.PlaceholderColor = Color.DarkGray;
            phonenumber.PlaceholderText = "Enter Phone Number";
            phonenumber.Size = new Size(386, 58);
            phonenumber.TabIndex = 60;
            phonenumber.Texts = "";
            phonenumber.UnderlinedStyle = false;
            // 
            // Lname
            // 
            Lname.BackColor = Color.White;
            Lname.BorderColor = Color.Black;
            Lname.BorderFocusColor = Color.BlueViolet;
            Lname.BorderRadius = 12;
            Lname.BorderSize = 1;
            Lname.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lname.ForeColor = Color.DimGray;
            Lname.Location = new Point(462, 221);
            Lname.Margin = new Padding(5);
            Lname.MinimumSize = new Size(0, 58);
            Lname.Multiline = false;
            Lname.Name = "Lname";
            Lname.Padding = new Padding(14, 14, 8, 8);
            Lname.PasswordChar = false;
            Lname.PlaceholderColor = Color.DarkGray;
            Lname.PlaceholderText = "Enter Lastname";
            Lname.Size = new Size(386, 58);
            Lname.TabIndex = 61;
            Lname.Texts = "";
            Lname.UnderlinedStyle = false;
            // 
            // Test
            // 
            AcceptButton = Createbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 771);
            Controls.Add(Lname);
            Controls.Add(phonenumber);
            Controls.Add(address);
            Controls.Add(Fname);
            Controls.Add(hoverButton4);
            Controls.Add(Createbtn);
            Controls.Add(linkSignIn);
            Controls.Add(checkboxTerms);
            Controls.Add(lblNote);
            Controls.Add(lblCreate);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(pass_toggle);
            Controls.Add(signup_pass2);
            Controls.Add(signup_pass);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJToggleButton pass_toggle;
        private CustomControls.RJControls.RJTextBox signup_pass2;
        private CustomControls.RJControls.RJTextBox signup_pass;
        private CustomControls.RJControls.RJTextBox username;
        private CustomControls.RJControls.RJTextBox email;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox checkboxTerms;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private CustomControls.RJControls.RJButton Createbtn;
        private HoverButton hoverButton4;
        private CustomControls.RJControls.RJTextBox Fname;
        private CustomControls.RJControls.RJTextBox address;
        private CustomControls.RJControls.RJTextBox phonenumber;
        private CustomControls.RJControls.RJTextBox Lname;
    }
}