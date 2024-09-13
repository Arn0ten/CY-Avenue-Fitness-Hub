namespace CY_Avenue_Fitness_Hub
{
    partial class frmRegister
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
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            llblLogin = new LinkLabel();
            btnSignup = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtSPassword = new TextBox();
            txtSUsername = new TextBox();
            pictureBox3 = new PictureBox();
            txtSConfirPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(254, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(59, 1);
            panel3.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 329);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 24;
            label2.Text = "Already have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 22);
            label1.Name = "label1";
            label1.Size = new Size(121, 45);
            label1.TabIndex = 14;
            label1.Text = "Signup";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(6, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 1);
            panel2.TabIndex = 22;
            // 
            // llblLogin
            // 
            llblLogin.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            llblLogin.AutoSize = true;
            llblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llblLogin.Location = new Point(210, 326);
            llblLogin.Name = "llblLogin";
            llblLogin.Size = new Size(46, 19);
            llblLogin.TabIndex = 21;
            llblLogin.TabStop = true;
            llblLogin.Text = "Login";
            llblLogin.LinkClicked += llblLogin_LinkClicked;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Green;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnSignup.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(28, 261);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(259, 32);
            btnSignup.TabIndex = 19;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_lock_23;
            pictureBox2.Location = new Point(25, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_23__1_;
            pictureBox1.Location = new Point(25, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtSPassword
            // 
            txtSPassword.Font = new Font("Segoe UI", 12F);
            txtSPassword.Location = new Point(57, 172);
            txtSPassword.Name = "txtSPassword";
            txtSPassword.PasswordChar = '•';
            txtSPassword.PlaceholderText = "Password";
            txtSPassword.Size = new Size(227, 29);
            txtSPassword.TabIndex = 16;
            // 
            // txtSUsername
            // 
            txtSUsername.Font = new Font("Segoe UI", 12F);
            txtSUsername.Location = new Point(57, 137);
            txtSUsername.Name = "txtSUsername";
            txtSUsername.PlaceholderText = "Username";
            txtSUsername.Size = new Size(227, 29);
            txtSUsername.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_lock_23;
            pictureBox3.Location = new Point(25, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // txtSConfirPassword
            // 
            txtSConfirPassword.Font = new Font("Segoe UI", 12F);
            txtSConfirPassword.Location = new Point(57, 207);
            txtSConfirPassword.Name = "txtSConfirPassword";
            txtSConfirPassword.PasswordChar = '•';
            txtSConfirPassword.PlaceholderText = "Confirm Password";
            txtSConfirPassword.Size = new Size(227, 29);
            txtSConfirPassword.TabIndex = 25;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 370);
            Controls.Add(pictureBox3);
            Controls.Add(txtSConfirPassword);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(llblLogin);
            Controls.Add(btnSignup);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtSPassword);
            Controls.Add(txtSUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private LinkLabel llblLogin;
        private Button btnSignup;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtSPassword;
        private TextBox txtSUsername;
        private PictureBox pictureBox3;
        private TextBox txtSConfirPassword;
    }
}