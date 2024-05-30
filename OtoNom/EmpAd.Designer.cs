namespace OtoNom
{
    partial class EmpAd
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
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoDuzDataSet = new OtoNom.InsertCoDuzDataSet();
            this.employeeTableAdapter = new OtoNom.InsertCoDuzDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hire = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.cmbYone = new System.Windows.Forms.ComboBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.EmpSave = new Guna.UI2.WinForms.Guna2Button();
            this.EmpDelete = new Guna.UI2.WinForms.Guna2Button();
            this.EmpUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backPage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.hiredateDataGridViewTextBoxColumn,
            this.manageridDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            this.departmentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // hiredateDataGridViewTextBoxColumn
            // 
            this.hiredateDataGridViewTextBoxColumn.DataPropertyName = "hire_date";
            this.hiredateDataGridViewTextBoxColumn.HeaderText = "hire_date";
            this.hiredateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hiredateDataGridViewTextBoxColumn.Name = "hiredateDataGridViewTextBoxColumn";
            this.hiredateDataGridViewTextBoxColumn.Width = 125;
            // 
            // manageridDataGridViewTextBoxColumn
            // 
            this.manageridDataGridViewTextBoxColumn.DataPropertyName = "manager_id";
            this.manageridDataGridViewTextBoxColumn.HeaderText = "manager_id";
            this.manageridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manageridDataGridViewTextBoxColumn.Name = "manageridDataGridViewTextBoxColumn";
            this.manageridDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "TcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            this.tcKimlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.insertCoDuzDataSet;
            // 
            // insertCoDuzDataSet
            // 
            this.insertCoDuzDataSet.DataSetName = "InsertCoDuzDataSet";
            this.insertCoDuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 245);
            this.panel1.TabIndex = 1;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit.Location = new System.Drawing.Point(1159, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(19, 20);
            this.quit.TabIndex = 1;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışan Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalışan Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(117, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Posta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Departman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "İşe Giriş Tarihi:";
            // 
            // hire
            // 
            this.hire.Location = new System.Drawing.Point(684, 275);
            this.hire.Name = "hire";
            this.hire.Size = new System.Drawing.Size(200, 22);
            this.hire.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(579, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yönetici:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(579, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(579, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tc-Kimlik:";
            // 
            // txtAd
            // 
            this.txtAd.Animated = true;
            this.txtAd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAd.BorderRadius = 10;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.DefaultText = "";
            this.txtAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Location = new System.Drawing.Point(218, 275);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PlaceholderText = "Adı:\r\n";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(258, 19);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoy
            // 
            this.txtSoy.Animated = true;
            this.txtSoy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSoy.BorderRadius = 10;
            this.txtSoy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoy.DefaultText = "";
            this.txtSoy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoy.Location = new System.Drawing.Point(218, 315);
            this.txtSoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.PasswordChar = '\0';
            this.txtSoy.PlaceholderText = "Soyadı:";
            this.txtSoy.SelectedText = "";
            this.txtSoy.Size = new System.Drawing.Size(258, 19);
            this.txtSoy.TabIndex = 4;
            // 
            // txtmail
            // 
            this.txtmail.Animated = true;
            this.txtmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtmail.BorderRadius = 10;
            this.txtmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.DefaultText = "";
            this.txtmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmail.Location = new System.Drawing.Point(218, 353);
            this.txtmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmail.Name = "txtmail";
            this.txtmail.PasswordChar = '\0';
            this.txtmail.PlaceholderText = "@example.com\r\n";
            this.txtmail.SelectedText = "";
            this.txtmail.Size = new System.Drawing.Size(258, 19);
            this.txtmail.TabIndex = 4;
            // 
            // cmbDep
            // 
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(218, 387);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(154, 24);
            this.cmbDep.TabIndex = 5;
            // 
            // cmbYone
            // 
            this.cmbYone.FormattingEnabled = true;
            this.cmbYone.Location = new System.Drawing.Point(654, 315);
            this.cmbYone.Name = "cmbYone";
            this.cmbYone.Size = new System.Drawing.Size(121, 24);
            this.cmbYone.TabIndex = 6;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbCins.Location = new System.Drawing.Point(654, 361);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(121, 24);
            this.cmbCins.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(665, 409);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 8;
            // 
            // EmpSave
            // 
            this.EmpSave.Animated = true;
            this.EmpSave.BorderRadius = 10;
            this.EmpSave.BorderThickness = 1;
            this.EmpSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmpSave.ForeColor = System.Drawing.Color.Black;
            this.EmpSave.Location = new System.Drawing.Point(66, 451);
            this.EmpSave.Name = "EmpSave";
            this.EmpSave.Size = new System.Drawing.Size(180, 45);
            this.EmpSave.TabIndex = 9;
            this.EmpSave.Text = "Çalışan Kaydet";
            this.EmpSave.Click += new System.EventHandler(this.EmpSave_Click);
            // 
            // EmpDelete
            // 
            this.EmpDelete.Animated = true;
            this.EmpDelete.BorderRadius = 10;
            this.EmpDelete.BorderThickness = 1;
            this.EmpDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmpDelete.ForeColor = System.Drawing.Color.Black;
            this.EmpDelete.Location = new System.Drawing.Point(420, 451);
            this.EmpDelete.Name = "EmpDelete";
            this.EmpDelete.Size = new System.Drawing.Size(180, 45);
            this.EmpDelete.TabIndex = 10;
            this.EmpDelete.Text = "Çalışan Sil";
            this.EmpDelete.Click += new System.EventHandler(this.EmpDelete_Click);
            // 
            // EmpUpdate
            // 
            this.EmpUpdate.BorderRadius = 10;
            this.EmpUpdate.BorderThickness = 1;
            this.EmpUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmpUpdate.ForeColor = System.Drawing.Color.Black;
            this.EmpUpdate.Location = new System.Drawing.Point(814, 451);
            this.EmpUpdate.Name = "EmpUpdate";
            this.EmpUpdate.Size = new System.Drawing.Size(180, 45);
            this.EmpUpdate.TabIndex = 11;
            this.EmpUpdate.Text = "Çalışan Bilgisi Güncelle";
            this.EmpUpdate.Click += new System.EventHandler(this.EmpUpdate_Click);
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
            this.backPage.Size = new System.Drawing.Size(53, 28);
            this.backPage.TabIndex = 12;
            this.backPage.Text = "←";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // EmpAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 508);
            this.Controls.Add(this.EmpUpdate);
            this.Controls.Add(this.EmpDelete);
            this.Controls.Add(this.EmpSave);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.cmbYone);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.hire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpAd";
            this.Text = "EmpAd";
            this.Load += new System.EventHandler(this.EmpAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InsertCoDuzDataSet insertCoDuzDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private InsertCoDuzDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker hire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private Guna.UI2.WinForms.Guna2TextBox txtSoy;
        private Guna.UI2.WinForms.Guna2TextBox txtmail;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.ComboBox cmbYone;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private Guna.UI2.WinForms.Guna2Button EmpSave;
        private Guna.UI2.WinForms.Guna2Button EmpDelete;
        private Guna.UI2.WinForms.Guna2Button EmpUpdate;
        private System.Windows.Forms.Label quit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backPage;
    }
}