namespace CY_Avenue_Fitness_Hub
{
    partial class frmRevenue
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
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(185, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 1);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(-2, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 1);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 6);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 557);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRevenue";
            Text = "frmRevenue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}