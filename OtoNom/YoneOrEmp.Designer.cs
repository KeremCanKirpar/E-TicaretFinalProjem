namespace OtoNom
{
    partial class YoneOrEmp
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
            this.components = new System.ComponentModel.Container();
            this.EnYone = new Guna.UI2.WinForms.Guna2Button();
            this.EnterCal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.quit = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnYone
            // 
            this.EnYone.Animated = true;
            this.EnYone.BorderRadius = 10;
            this.EnYone.BorderThickness = 1;
            this.EnYone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EnYone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EnYone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnYone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EnYone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnYone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnYone.ForeColor = System.Drawing.Color.White;
            this.EnYone.Location = new System.Drawing.Point(369, 136);
            this.EnYone.Name = "EnYone";
            this.EnYone.Size = new System.Drawing.Size(180, 45);
            this.EnYone.TabIndex = 0;
            this.EnYone.Text = "Yönetici Giriş";
            this.EnYone.Click += new System.EventHandler(this.EnYone_Click);
            // 
            // EnterCal
            // 
            this.EnterCal.Animated = true;
            this.EnterCal.BorderRadius = 10;
            this.EnterCal.BorderThickness = 1;
            this.EnterCal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EnterCal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EnterCal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EnterCal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EnterCal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnterCal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnterCal.ForeColor = System.Drawing.Color.White;
            this.EnterCal.Location = new System.Drawing.Point(369, 220);
            this.EnterCal.Name = "EnterCal";
            this.EnterCal.Size = new System.Drawing.Size(180, 45);
            this.EnterCal.TabIndex = 1;
            this.EnterCal.Text = "Çalışan giriş";
            this.EnterCal.Click += new System.EventHandler(this.EnterCal_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.quit.Location = new System.Drawing.Point(923, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(19, 20);
            this.quit.TabIndex = 2;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Maroon;
            this.guna2GradientPanel1.Controls.Add(this.quit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(945, 87);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Maroon;
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 356);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(945, 62);
            this.guna2GradientPanel2.TabIndex = 4;
            // 
            // YoneOrEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 418);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.EnterCal);
            this.Controls.Add(this.EnYone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoneOrEmp";
            this.Text = "YoneOrEmp";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button EnYone;
        private Guna.UI2.WinForms.Guna2Button EnterCal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label quit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}