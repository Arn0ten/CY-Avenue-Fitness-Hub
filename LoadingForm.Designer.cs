namespace CY_Avenue_Fitness_Hub
{
    partial class LoadingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlBlue = new Panel();
            label2 = new Label();
            prgLoading = new ProgressBar();
            tmrLoading = new System.Windows.Forms.Timer(components);
            lblPercent = new Label();
            picLogo = new PictureBox();
            pnlBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlBlue
            // 
            pnlBlue.BackColor = Color.Navy;
            pnlBlue.Controls.Add(picLogo);
            pnlBlue.Dock = DockStyle.Top;
            pnlBlue.Location = new Point(0, 0);
            pnlBlue.Name = "pnlBlue";
            pnlBlue.Size = new Size(551, 200);
            pnlBlue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 282);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Loading...";
            // 
            // prgLoading
            // 
            prgLoading.BackColor = Color.Navy;
            prgLoading.Location = new Point(165, 300);
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(215, 10);
            prgLoading.TabIndex = 3;
            // 
            // tmrLoading
            // 
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(389, 296);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(10, 15);
            lblPercent.TabIndex = 4;
            lblPercent.Text = " ";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.cy_Avenu_logo_removebg_preview;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(202, 200);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 328);
            Controls.Add(lblPercent);
            Controls.Add(prgLoading);
            Controls.Add(label2);
            Controls.Add(pnlBlue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlBlue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBlue;

        private Label label2;
        private ProgressBar prgLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private Label lblPercent;
        private PictureBox picLogo;
    }
}
