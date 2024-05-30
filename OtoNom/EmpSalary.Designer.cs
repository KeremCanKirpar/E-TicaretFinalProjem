namespace OtoNom
{
    partial class EmpSalary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salaryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoDuzDataSet = new OtoNom.InsertCoDuzDataSet();
            this.salariesTableAdapter = new OtoNom.InsertCoDuzDataSetTableAdapters.SalariesTableAdapter();
            this.ZamY = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSalary = new Guna.UI2.WinForms.Guna2Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 160);
            this.panel1.TabIndex = 0;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit.Location = new System.Drawing.Point(1209, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(19, 20);
            this.quit.TabIndex = 1;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.salaryamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salariesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // salaryidDataGridViewTextBoxColumn
            // 
            this.salaryidDataGridViewTextBoxColumn.DataPropertyName = "salary_id";
            this.salaryidDataGridViewTextBoxColumn.HeaderText = "salary_id";
            this.salaryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryidDataGridViewTextBoxColumn.Name = "salaryidDataGridViewTextBoxColumn";
            this.salaryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryidDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryamountDataGridViewTextBoxColumn
            // 
            this.salaryamountDataGridViewTextBoxColumn.DataPropertyName = "salary_amount";
            this.salaryamountDataGridViewTextBoxColumn.HeaderText = "salary_amount";
            this.salaryamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryamountDataGridViewTextBoxColumn.Name = "salaryamountDataGridViewTextBoxColumn";
            this.salaryamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "Salaries";
            this.salariesBindingSource.DataSource = this.insertCoDuzDataSet;
            // 
            // insertCoDuzDataSet
            // 
            this.insertCoDuzDataSet.DataSetName = "InsertCoDuzDataSet";
            this.insertCoDuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // ZamY
            // 
            this.ZamY.Animated = true;
            this.ZamY.BorderRadius = 10;
            this.ZamY.BorderThickness = 1;
            this.ZamY.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ZamY.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ZamY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ZamY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ZamY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ZamY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamY.ForeColor = System.Drawing.Color.White;
            this.ZamY.Location = new System.Drawing.Point(777, 348);
            this.ZamY.Name = "ZamY";
            this.ZamY.Size = new System.Drawing.Size(180, 45);
            this.ZamY.TabIndex = 1;
            this.ZamY.Text = "Zam Yap";
            this.ZamY.Click += new System.EventHandler(this.ZamY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışan:";
            // 
            // cmbCal
            // 
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Location = new System.Drawing.Point(150, 218);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(121, 24);
            this.cmbCal.TabIndex = 3;
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
            this.backPage.Location = new System.Drawing.Point(0, 0);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(64, 31);
            this.backPage.TabIndex = 6;
            this.backPage.Text = "←";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.Animated = true;
            this.btnAddSalary.BorderRadius = 10;
            this.btnAddSalary.BorderThickness = 1;
            this.btnAddSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSalary.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.Location = new System.Drawing.Point(291, 348);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(180, 45);
            this.btnAddSalary.TabIndex = 4;
            this.btnAddSalary.Text = "Çalışan Maaş Ekle";
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(417, 214);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(119, 22);
            this.txtMonth.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(678, 214);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(139, 22);
            this.txtYear.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(379, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(630, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yıl:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(1000, 212);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(143, 22);
            this.txtSalary.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(912, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maaşı:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmpSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 441);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.cmbCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZamY);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpSalary";
            this.Text = "EmpSalary";
            this.Load += new System.EventHandler(this.EmpSalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InsertCoDuzDataSet insertCoDuzDataSet;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private InsertCoDuzDataSetTableAdapters.SalariesTableAdapter salariesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryamountDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button ZamY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCal;
        private System.Windows.Forms.Label quit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backPage;
        private Guna.UI2.WinForms.Guna2Button btnAddSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
    }
}