namespace HR_ManagmentSystem_Client
{
    partial class SignUp
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
            signup_usr = new CustomControls.RJControls.RJTextBox();
            email = new CustomControls.RJControls.RJTextBox();
            lblCreate = new Label();
            lblNote = new Label();
            checkboxTerms = new CheckBox();
            linkSignIn = new LinkLabel();
            Createbtn = new CustomControls.RJControls.RJButton();
            hoverButton4 = new HoverButton();
            SuspendLayout();
            // 
            // pass_toggle
            // 
            pass_toggle.AutoSize = true;
            pass_toggle.BackColor = Color.Transparent;
            pass_toggle.Cursor = Cursors.Hand;
            pass_toggle.ForeColor = Color.Transparent;
            pass_toggle.Location = new Point(408, 403);
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
            signup_pass2.Location = new Point(78, 468);
            signup_pass2.Margin = new Padding(5, 5, 5, 5);
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
            signup_pass2._TextChanged += signup_pass2__TextChanged;
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
            signup_pass.Location = new Point(78, 385);
            signup_pass.Margin = new Padding(5, 5, 5, 5);
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
            signup_pass._TextChanged += signup_pass__TextChanged;
            // 
            // signup_usr
            // 
            signup_usr.BackColor = Color.White;
            signup_usr.BorderColor = Color.Black;
            signup_usr.BorderFocusColor = Color.BlueViolet;
            signup_usr.BorderRadius = 12;
            signup_usr.BorderSize = 1;
            signup_usr.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_usr.ForeColor = Color.DimGray;
            signup_usr.Location = new Point(78, 301);
            signup_usr.Margin = new Padding(5, 5, 5, 5);
            signup_usr.MinimumSize = new Size(0, 58);
            signup_usr.Multiline = false;
            signup_usr.Name = "signup_usr";
            signup_usr.Padding = new Padding(14, 14, 8, 8);
            signup_usr.PasswordChar = false;
            signup_usr.PlaceholderColor = Color.DarkGray;
            signup_usr.PlaceholderText = "Create Username";
            signup_usr.Size = new Size(386, 58);
            signup_usr.TabIndex = 50;
            signup_usr.Texts = "";
            signup_usr.UnderlinedStyle = false;
            signup_usr._TextChanged += signup_usr__TextChanged;
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
            email.Location = new Point(78, 218);
            email.Margin = new Padding(5, 5, 5, 5);
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
            email._TextChanged += email__TextChanged;
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblCreate.Location = new Point(71, 52);
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
            lblNote.Location = new Point(74, 123);
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
            checkboxTerms.Location = new Point(80, 548);
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
            linkSignIn.Location = new Point(140, 677);
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
            Createbtn.Location = new Point(75, 593);
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
            hoverButton4.Location = new Point(507, 3);
            hoverButton4.Margin = new Padding(4, 3, 4, 3);
            hoverButton4.Name = "hoverButton4";
            hoverButton4.Size = new Size(33, 35);
            hoverButton4.TabIndex = 57;
            hoverButton4.Text = "▶";
            hoverButton4.UseVisualStyleBackColor = true;
            hoverButton4.Click += hoverButton4_Click;
            // 
            // SignUp
            // 
            AcceptButton = Createbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(542, 745);
            Controls.Add(hoverButton4);
            Controls.Add(Createbtn);
            Controls.Add(linkSignIn);
            Controls.Add(checkboxTerms);
            Controls.Add(lblNote);
            Controls.Add(lblCreate);
            Controls.Add(email);
            Controls.Add(signup_usr);
            Controls.Add(pass_toggle);
            Controls.Add(signup_pass2);
            Controls.Add(signup_pass);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SignUp";
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
        private CustomControls.RJControls.RJTextBox signup_usr;
        private CustomControls.RJControls.RJTextBox email;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox checkboxTerms;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private CustomControls.RJControls.RJButton Createbtn;
        private HoverButton hoverButton4;
    }
}