using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class ShowProjeManager : Form
    {
        public ShowProjeManager()
        {
            InitializeComponent();
        }

        private int employeeId; // Oturum açmış çalışan ID'si
        private string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

        private void ShowProjeManager_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectId, ProjectName, FileData, employee_id FROM Projects";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // DataGridView'in otomatik sütun oluşturma özelliğini kapatın
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns.Clear();

                        // ProjectId sütununu oluşturun
                        DataGridViewTextBoxColumn projectIdColumn = new DataGridViewTextBoxColumn();
                        projectIdColumn.DataPropertyName = "ProjectId";
                        projectIdColumn.HeaderText = "Project ID";
                        dataGridView1.Columns.Add(projectIdColumn);

                        // ProjectName sütununu oluşturun
                        DataGridViewTextBoxColumn projectNameColumn = new DataGridViewTextBoxColumn();
                        projectNameColumn.DataPropertyName = "ProjectName";
                        projectNameColumn.HeaderText = "Project Name";
                        dataGridView1.Columns.Add(projectNameColumn);

                        // employee_id sütununu oluşturun
                        DataGridViewTextBoxColumn employeeIdColumn = new DataGridViewTextBoxColumn();
                        employeeIdColumn.DataPropertyName = "employee_id";
                        employeeIdColumn.HeaderText = "Employee ID";
                        dataGridView1.Columns.Add(employeeIdColumn);

                        // FileData sütununu oluşturun ve gizleyin
                        DataGridViewTextBoxColumn fileDataColumn = new DataGridViewTextBoxColumn();
                        fileDataColumn.DataPropertyName = "FileData";
                        fileDataColumn.HeaderText = "File Data";
                        fileDataColumn.Visible = false;
                        dataGridView1.Columns.Add(fileDataColumn);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void ProjDow_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;

            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("Lütfen bir proje adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectName, FileData FROM Projects WHERE ProjectName = @ProjectName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string foundProjectName = reader.GetString(0);
                            byte[] fileData = (byte[])reader["FileData"];

                            using (SaveFileDialog saveDialog = new SaveFileDialog())
                            {
                                saveDialog.FileName = foundProjectName; // Dosya ismi proje adı olacak
                                saveDialog.Filter = "All Files|*.*"; // Tüm dosyaları göster

                                if (saveDialog.ShowDialog() == DialogResult.OK)
                                {
                                    File.WriteAllBytes(saveDialog.FileName, fileData);
                                    MessageBox.Show("Proje başarıyla indirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proje bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            MainPage Mp = new MainPage();
            this.Close();
            Mp.Show();
        }
    }
}
