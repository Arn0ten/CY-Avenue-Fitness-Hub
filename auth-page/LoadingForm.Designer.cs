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

            label1 = new Label();

            label2 = new Label();
            prgLoading = new ProgressBar();
            tmrLoading = new System.Windows.Forms.Timer(components);
            lblPercent = new Label();

            pictureBox1 = new PictureBox();
            pnlBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            pnlBlue.SuspendLayout();

            SuspendLayout();
            // 
            // pnlBlue
            // 
            pnlBlue.BackColor = Color.Navy;

            pnlBlue.Controls.Add(pictureBox1);
            pnlBlue.Dock = DockStyle.Top;
            pnlBlue.Location = new Point(0, 0);
            pnlBlue.Name = "pnlBlue";
            pnlBlue.Size = new Size(551, 192);
            pnlBlue.TabIndex = 1;
            // 

            pnlBlue.Controls.Add(label1);
            pnlBlue.Dock = DockStyle.Top;
            pnlBlue.Location = new Point(0, 0);
            pnlBlue.Name = "pnlBlue";
            pnlBlue.Size = new Size(551, 164);
            pnlBlue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 70);
            label1.Name = "label1";
            label1.Size = new Size(424, 77);
            label1.TabIndex = 0;
            label1.Text = "CY - Avenue";
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

            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cy_Avenu_logo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoadingForm

            // Form1

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

            Name = "Form1";

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlBlue.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            pnlBlue.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBlue;

        private Label label1;

        private Label label2;
        private ProgressBar prgLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private Label lblPercent;

        private PictureBox pictureBox1;

    }
}
