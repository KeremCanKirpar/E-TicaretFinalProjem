using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpProjeAd : Form
    {
        public EmpProjeAd(int empId)
        {
            InitializeComponent();
            employeeId = empId;
        }

        private int employeeId; 
        private string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

        private void AddProje_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text))
            {
                string folderPath = txtFilePath.Text;
                string projectName = new DirectoryInfo(folderPath).Name;

                
                byte[] fileData = GetFolderDataAsBytes(folderPath);

                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Projects (ProjectName, FileData, employee_id) VALUES (@ProjectName, @FileData, @EmployeeId)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectName", projectName);
                        cmd.Parameters.AddWithValue("@FileData", fileData); 
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Proje başarıyla yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetFolderDataAsBytes(string folderPath)
        {
           
            using (MemoryStream ms = new MemoryStream())
            {
                foreach (string filePath in Directory.GetFiles(folderPath))
                {
                    byte[] fileBytes = File.ReadAllBytes(filePath);
                    ms.Write(fileBytes, 0, fileBytes.Length);
                }
                return ms.ToArray();
            }
        }

        private void BrowsePro_Click(object sender, EventArgs e)
        {

        }

        private void BrowsePro_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
