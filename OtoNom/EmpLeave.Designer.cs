namespace OtoNom
{
    partial class EmpLeave
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
            this.Quit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leaveidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoDuzDataSet = new OtoNom.InsertCoDuzDataSet();
            this.leaveTableAdapter = new OtoNom.InsertCoDuzDataSetTableAdapters.LeaveTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LeaveSet = new Guna.UI2.WinForms.Guna2Button();
            this.SetStat = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbStat = new System.Windows.Forms.ComboBox();
            this.cmbLtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backPage = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backPage);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 160);
            this.panel1.TabIndex = 0;
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Quit.Location = new System.Drawing.Point(1196, 0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(19, 20);
            this.Quit.TabIndex = 10;
            this.Quit.Text = "X";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.leavetypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leaveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(179, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // leaveidDataGridViewTextBoxColumn
            // 
            this.leaveidDataGridViewTextBoxColumn.DataPropertyName = "Leave_id";
            this.leaveidDataGridViewTextBoxColumn.HeaderText = "Leave_id";
            this.leaveidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveidDataGridViewTextBoxColumn.Name = "leaveidDataGridViewTextBoxColumn";
            this.leaveidDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveidDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // leavetypeDataGridViewTextBoxColumn
            // 
            this.leavetypeDataGridViewTextBoxColumn.DataPropertyName = "leave_type";
            this.leavetypeDataGridViewTextBoxColumn.HeaderText = "leave_type";
            this.leavetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leavetypeDataGridViewTextBoxColumn.Name = "leavetypeDataGridViewTextBoxColumn";
            this.leavetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveBindingSource
            // 
            this.leaveBindingSource.DataMember = "Leave";
            this.leaveBindingSource.DataSource = this.insertCoDuzDataSet;
            // 
            // insertCoDuzDataSet
            // 
            this.insertCoDuzDataSet.DataSetName = "InsertCoDuzDataSet";
            this.insertCoDuzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTableAdapter
            // 
            this.leaveTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışan İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İzin Başlangıç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(442, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "İzin Bitiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(442, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "İzin Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(840, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "İzin Onayı:";
            // 
            // LeaveSet
            // 
            this.LeaveSet.Animated = true;
            this.LeaveSet.BorderRadius = 10;
            this.LeaveSet.BorderThickness = 1;
            this.LeaveSet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeaveSet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeaveSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeaveSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeaveSet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeaveSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LeaveSet.ForeColor = System.Drawing.Color.Black;
            this.LeaveSet.Location = new System.Drawing.Point(120, 369);
            this.LeaveSet.Name = "LeaveSet";
            this.LeaveSet.Size = new System.Drawing.Size(180, 45);
            this.LeaveSet.TabIndex = 2;
            this.LeaveSet.Text = "İzin Ayarla";
            this.LeaveSet.Click += new System.EventHandler(this.LeaveSet_Click);
            // 
            // SetStat
            // 
            this.SetStat.Animated = true;
            this.SetStat.BorderRadius = 10;
            this.SetStat.BorderThickness = 1;
            this.SetStat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetStat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetStat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetStat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetStat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SetStat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SetStat.ForeColor = System.Drawing.Color.Black;
            this.SetStat.Location = new System.Drawing.Point(446, 369);
            this.SetStat.Name = "SetStat";
            this.SetStat.Size = new System.Drawing.Size(180, 45);
            this.SetStat.TabIndex = 3;
            this.SetStat.Text = "Durumu Güncelle";
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(156, 216);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(121, 24);
            this.cmbEmp.TabIndex = 4;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(189, 280);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 22);
            this.dateStart.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(564, 220);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 22);
            this.dateEnd.TabIndex = 6;
            // 
            // cmbStat
            // 
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Items.AddRange(new object[] {
            "Onaylandı",
            "Reddedildi",
            "Beklemede"});
            this.cmbStat.Location = new System.Drawing.Point(928, 220);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(121, 24);
            this.cmbStat.TabIndex = 7;
            // 
            // cmbLtype
            // 
            this.cmbLtype.FormattingEnabled = true;
            this.cmbLtype.Location = new System.Drawing.Point(523, 283);
            this.cmbLtype.Name = "cmbLtype";
            this.cmbLtype.Size = new System.Drawing.Size(121, 24);
            this.cmbLtype.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
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
            this.backPage.TabIndex = 10;
            this.backPage.Text = "←";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // EmpLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLtype);
            this.Controls.Add(this.cmbStat);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.SetStat);
            this.Controls.Add(this.LeaveSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpLeave";
            this.Text = "EmpLeave";
            this.Load += new System.EventHandler(this.EmpLeave_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoDuzDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InsertCoDuzDataSet insertCoDuzDataSet;
        private System.Windows.Forms.BindingSource leaveBindingSource;
        private InsertCoDuzDataSetTableAdapters.LeaveTableAdapter leaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button LeaveSet;
        private Guna.UI2.WinForms.Guna2Button SetStat;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbStat;
        private System.Windows.Forms.ComboBox cmbLtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Quit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button backPage;
    }
}