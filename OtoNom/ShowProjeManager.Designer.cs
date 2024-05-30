namespace OtoNom
{
    partial class ShowProjeManager
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
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoDuzDataSet1 = new OtoNom.InsertCoDuzDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backPage = new Guna.UI2.WinForms.Guna2Button();
            this.quit = new System.Windows.Forms.Label();
            this.insertCoDuzDataSet = new OtoNom.InsertCoDuzDataSet();
            this.insertCoDuzDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new OtoNom.InsertCoDuzDataSet1TableAdapters.ProjectsTableAdapter();
            this.ProjDow = new Guna.UI2.WinForms.Guna2Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.fileDataDataGridViewImageColumn,
            this.employeeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fileDataDataGridViewImageColumn
            // 
            this.fileDataDataGridViewImageColumn.DataPropertyName = "FileData";
            this.fileDataDataGridViewImageColumn.HeaderText = "FileData";
            this.fileDataDataGridViewImageColumn.MinimumWidth = 6;
            this.fileDataDataGridViewImageColumn.Name = "fileDataDataGridViewImageColumn";
            this.fileDataDataGridViewImageColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.insertCoDuzDataSet1;
            // 
            // insertCoDuzDataSet1
            // 
            this.insertCoDuzDataSet1.DataSetName = "InsertCoDuzDataSet1";
            this.insertCoDuzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 195);
            this.panel1.TabIndex = 1;
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
            this.backPage.TabIndex = 5;
            this.backPage.Text = "←";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit.Location = new System.Drawing.Point(1143, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(19, 20);
            this.quit.TabIndex = 1;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // insertCoDuzDataSet
            // 
            this.insertCoDuzDataSet.DataSetName = "InsertCoDuzDataSet";
            this.insertCoDuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertCoDuzDataSetBindingSource
            // 
            this.insertCoDuzDataSetBindingSource.DataSource = this.insertCoDuzDataSet;
            this.insertCoDuzDataSetBindingSource.Position = 0;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // ProjDow
            // 
            this.ProjDow.Animated = true;
            this.ProjDow.BorderRadius = 10;
            this.ProjDow.BorderThickness = 1;
            this.ProjDow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProjDow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProjDow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProjDow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProjDow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProjDow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProjDow.ForeColor = System.Drawing.Color.White;
            this.ProjDow.Location = new System.Drawing.Point(428, 352);
            this.ProjDow.Name = "ProjDow";
            this.ProjDow.Size = new System.Drawing.Size(180, 45);
            this.ProjDow.TabIndex = 2;
            this.ProjDow.Text = "Projeyi İndir";
            this.ProjDow.Click += new System.EventHandler(this.ProjDow_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(448, 267);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(121, 22);
            this.txtProjectName.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(319, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proje Adı:";
            // 
            // ShowProjeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.ProjDow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowProjeManager";
            this.Text = "ShowProjeManager";
            this.Load += new System.EventHandler(this.ShowProjeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource insertCoDuzDataSetBindingSource;
        private InsertCoDuzDataSet insertCoDuzDataSet;
        private System.Windows.Forms.Panel panel1;
        private InsertCoDuzDataSet1 insertCoDuzDataSet1;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private InsertCoDuzDataSet1TableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fileDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button ProjDow;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label quit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button backPage;
    }
}