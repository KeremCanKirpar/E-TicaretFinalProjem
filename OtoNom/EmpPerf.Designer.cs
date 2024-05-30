namespace OtoNom
{
    partial class EmpPerf
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reviewidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoDuzDataSet = new OtoNom.InsertCoDuzDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Label();
            this.performanceTableAdapter = new OtoNom.InsertCoDuzDataSetTableAdapters.PerformanceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.Rdeger = new System.Windows.Forms.RichTextBox();
            this.nPuan = new System.Windows.Forms.NumericUpDown();
            this.cmbYone = new System.Windows.Forms.ComboBox();
            this.SavePerf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backPage = new Guna.UI2.WinForms.Guna2Button();
            this.Btndelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPuan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.manageridDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.performanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // reviewidDataGridViewTextBoxColumn
            // 
            this.reviewidDataGridViewTextBoxColumn.DataPropertyName = "review_id";
            this.reviewidDataGridViewTextBoxColumn.HeaderText = "review_id";
            this.reviewidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewidDataGridViewTextBoxColumn.Name = "reviewidDataGridViewTextBoxColumn";
            this.reviewidDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewidDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // manageridDataGridViewTextBoxColumn
            // 
            this.manageridDataGridViewTextBoxColumn.DataPropertyName = "manager_id";
            this.manageridDataGridViewTextBoxColumn.HeaderText = "manager_id";
            this.manageridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manageridDataGridViewTextBoxColumn.Name = "manageridDataGridViewTextBoxColumn";
            this.manageridDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataMember = "Performance";
            this.performanceBindingSource.DataSource = this.insertCoDuzDataSet;
            // 
            // insertCoDuzDataSet
            // 
            this.insertCoDuzDataSet.DataSetName = "InsertCoDuzDataSet";
            this.insertCoDuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 193);
            this.panel1.TabIndex = 1;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit.Location = new System.Drawing.Point(1226, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(19, 20);
            this.quit.TabIndex = 1;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // performanceTableAdapter
            // 
            this.performanceTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetici:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(567, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Değerlendirme Puanı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(567, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Değerlendirme Notu:";
            // 
            // cmbCal
            // 
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Location = new System.Drawing.Point(166, 232);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(121, 24);
            this.cmbCal.TabIndex = 3;
            // 
            // Rdeger
            // 
            this.Rdeger.Location = new System.Drawing.Point(731, 309);
            this.Rdeger.Name = "Rdeger";
            this.Rdeger.Size = new System.Drawing.Size(283, 96);
            this.Rdeger.TabIndex = 4;
            this.Rdeger.Text = "";
            // 
            // nPuan
            // 
            this.nPuan.Location = new System.Drawing.Point(734, 237);
            this.nPuan.Name = "nPuan";
            this.nPuan.Size = new System.Drawing.Size(120, 22);
            this.nPuan.TabIndex = 5;
            this.nPuan.ValueChanged += new System.EventHandler(this.nPuan_ValueChanged);
            // 
            // cmbYone
            // 
            this.cmbYone.FormattingEnabled = true;
            this.cmbYone.Location = new System.Drawing.Point(172, 309);
            this.cmbYone.Name = "cmbYone";
            this.cmbYone.Size = new System.Drawing.Size(121, 24);
            this.cmbYone.TabIndex = 6;
            // 
            // SavePerf
            // 
            this.SavePerf.Animated = true;
            this.SavePerf.BorderRadius = 10;
            this.SavePerf.BorderThickness = 1;
            this.SavePerf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SavePerf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SavePerf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SavePerf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SavePerf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SavePerf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SavePerf.ForeColor = System.Drawing.Color.White;
            this.SavePerf.Location = new System.Drawing.Point(113, 387);
            this.SavePerf.Name = "SavePerf";
            this.SavePerf.Size = new System.Drawing.Size(180, 45);
            this.SavePerf.TabIndex = 7;
            this.SavePerf.Text = "Değerlendirme Kaydet";
            this.SavePerf.Click += new System.EventHandler(this.SavePerf_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // backPage
            // 
            this.backPage.Animated = true;
            this.backPage.BorderColor = System.Drawing.Color.Transparent;
            this.backPage.BorderRadius = 10;
            this.backPage.BorderThickness = 1;
            this.backPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backPage.FillColor = System.Drawing.Color.Transparent;
            this.backPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backPage.ForeColor = System.Drawing.Color.Black;
            this.backPage.Location = new System.Drawing.Point(3, 0);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(64, 31);
            this.backPage.TabIndex = 6;
            this.backPage.Text = "←";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Animated = true;
            this.Btndelete.BorderRadius = 10;
            this.Btndelete.BorderThickness = 1;
            this.Btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btndelete.ForeColor = System.Drawing.Color.White;
            this.Btndelete.Location = new System.Drawing.Point(416, 387);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(180, 45);
            this.Btndelete.TabIndex = 8;
            this.Btndelete.Text = "Değerlendirme Sil";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // EmpPerf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 459);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.SavePerf);
            this.Controls.Add(this.cmbYone);
            this.Controls.Add(this.nPuan);
            this.Controls.Add(this.Rdeger);
            this.Controls.Add(this.cmbCal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpPerf";
            this.Text = "EmpPerf";
            this.Load += new System.EventHandler(this.EmpPerf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private InsertCoDuzDataSet insertCoDuzDataSet;
        private System.Windows.Forms.BindingSource performanceBindingSource;
        private InsertCoDuzDataSetTableAdapters.PerformanceTableAdapter performanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCal;
        private System.Windows.Forms.RichTextBox Rdeger;
        private System.Windows.Forms.NumericUpDown nPuan;
        private System.Windows.Forms.ComboBox cmbYone;
        private Guna.UI2.WinForms.Guna2Button SavePerf;
        private System.Windows.Forms.Label quit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backPage;
        private Guna.UI2.WinForms.Guna2Button Btndelete;
    }
}