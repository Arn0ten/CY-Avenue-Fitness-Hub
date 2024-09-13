namespace CY_Avenue_Fitness_Hub
{
    partial class frmMain
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
            pnlTop = new Panel();
            pnlTopSide = new Panel();
            btnMenu = new Button();
            picLogo = new PictureBox();
            btnNotifications = new Button();
            btnWelcomeAdmin = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pnlDisplay = new Panel();
            btnRevenue = new Button();
            pnlTop.SuspendLayout();
            pnlTopSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Navy;
            pnlTop.Controls.Add(pnlTopSide);
            pnlTop.Controls.Add(btnNotifications);
            pnlTop.Controls.Add(btnWelcomeAdmin);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1075, 37);
            pnlTop.TabIndex = 0;
            // 
            // pnlTopSide
            // 
            pnlTopSide.BackColor = Color.MediumBlue;
            pnlTopSide.Controls.Add(btnMenu);
            pnlTopSide.Controls.Add(picLogo);
            pnlTopSide.Location = new Point(0, 0);
            pnlTopSide.Name = "pnlTopSide";
            pnlTopSide.Size = new Size(214, 37);
            pnlTopSide.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.MediumBlue;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.icons8_hamburger_menu_23;
            btnMenu.ImageAlign = ContentAlignment.MiddleRight;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(31, 31);
            btnMenu.TabIndex = 4;
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = ImageLayout.None;
            picLogo.Image = Properties.Resources.Screenshot_2024_09_10_154147_removebg_preview;
            picLogo.Location = new Point(40, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(157, 33);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.Navy;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = Color.White;
            btnNotifications.Image = Properties.Resources.icons8_bell_23;
            btnNotifications.ImageAlign = ContentAlignment.MiddleRight;
            btnNotifications.Location = new Point(818, 8);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(108, 21);
            btnNotifications.TabIndex = 1;
            btnNotifications.Text = "Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnWelcomeAdmin
            // 
            btnWelcomeAdmin.BackColor = Color.Navy;
            btnWelcomeAdmin.FlatAppearance.BorderSize = 0;
            btnWelcomeAdmin.FlatStyle = FlatStyle.Flat;
            btnWelcomeAdmin.ForeColor = Color.White;
            btnWelcomeAdmin.Image = Properties.Resources.icons8_user_23__2_;
            btnWelcomeAdmin.ImageAlign = ContentAlignment.MiddleRight;
            btnWelcomeAdmin.Location = new Point(929, 8);
            btnWelcomeAdmin.Name = "btnWelcomeAdmin";
            btnWelcomeAdmin.Size = new Size(138, 21);
            btnWelcomeAdmin.TabIndex = 0;
            btnWelcomeAdmin.Text = "Welcome | Admin";
            btnWelcomeAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnWelcomeAdmin.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(btnRevenue);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 565);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Navy;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 47);
            button2.Name = "button2";
            button2.Size = new Size(207, 38);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Navy;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 91);
            button3.Name = "button3";
            button3.Size = new Size(207, 38);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Navy;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 135);
            button4.Name = "button4";
            button4.Size = new Size(207, 38);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Navy;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 179);
            button5.Name = "button5";
            button5.Size = new Size(207, 38);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Navy;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 223);
            button6.Name = "button6";
            button6.Size = new Size(207, 38);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Navy;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 267);
            button7.Name = "button7";
            button7.Size = new Size(207, 38);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(214, 37);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(861, 565);
            pnlDisplay.TabIndex = 4;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = Color.Black;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnRevenue.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.ForeColor = Color.White;
            btnRevenue.Location = new Point(3, 3);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(207, 38);
            btnRevenue.TabIndex = 10;
            btnRevenue.Text = "button1";
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 602);
            Controls.Add(pnlDisplay);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            pnlTop.ResumeLayout(false);
            pnlTopSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnWelcomeAdmin;
        private Button btnNotifications;
        private Panel pnlTopSide;
        private PictureBox picLogo;
        private Panel pnlDisplay;
        private Button btnMenu;
        private Button btnRevenue;
    }
}