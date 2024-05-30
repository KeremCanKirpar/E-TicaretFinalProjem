namespace OtoNom
{
    partial class EmpProjeAd
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
            this.AddProje = new Guna.UI2.WinForms.Guna2Button();
            this.BrowsePro = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddProje
            // 
            this.AddProje.Animated = true;
            this.AddProje.BorderRadius = 10;
            this.AddProje.BorderThickness = 1;
            this.AddProje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddProje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProje.ForeColor = System.Drawing.Color.White;
            this.AddProje.Location = new System.Drawing.Point(211, 391);
            this.AddProje.Name = "AddProje";
            this.AddProje.Size = new System.Drawing.Size(180, 45);
            this.AddProje.TabIndex = 0;
            this.AddProje.Text = "Proje Ekle";
            this.AddProje.Click += new System.EventHandler(this.AddProje_Click);
            // 
            // BrowsePro
            // 
            this.BrowsePro.Animated = true;
            this.BrowsePro.BorderRadius = 10;
            this.BrowsePro.BorderThickness = 1;
            this.BrowsePro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BrowsePro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BrowsePro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BrowsePro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BrowsePro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BrowsePro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrowsePro.ForeColor = System.Drawing.Color.White;
            this.BrowsePro.Location = new System.Drawing.Point(598, 391);
            this.BrowsePro.Name = "BrowsePro";
            this.BrowsePro.Size = new System.Drawing.Size(180, 45);
            this.BrowsePro.TabIndex = 1;
            this.BrowsePro.Text = "Proje Seç";
            this.BrowsePro.Click += new System.EventHandler(this.BrowsePro_Click_1);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Animated = true;
            this.txtFilePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFilePath.BorderRadius = 10;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Location = new System.Drawing.Point(172, 204);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "Proje Yolu:";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(229, 35);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Animated = true;
            this.txtProjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtProjectName.BorderRadius = 10;
            this.txtProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectName.DefaultText = "Proje Adı:";
            this.txtProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Location = new System.Drawing.Point(549, 200);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.PlaceholderText = "1";
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.Size = new System.Drawing.Size(229, 39);
            this.txtProjectName.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Quit.Location = new System.Drawing.Point(998, 0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(19, 20);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "X";
            // 
            // EmpProjeAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 496);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.BrowsePro);
            this.Controls.Add(this.AddProje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpProjeAd";
            this.Text = "EmpProjeAd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddProje;
        private Guna.UI2.WinForms.Guna2Button BrowsePro;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label Quit;
    }
}