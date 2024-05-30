using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpPerf : Form
    {
        public EmpPerf()
        {
            InitializeComponent();
        }

        SqlFunc sqlFunc = new SqlFunc();
        DataTable employeesDataTable;
        DataTable managersDataTable;

        private void EmpPerf_Load(object sender, EventArgs e)
        {

            this.performanceTableAdapter.Fill(this.insertCoDuzDataSet.Performance);


            employeesDataTable = sqlFunc.Select("SELECT employee_id, manager_id, (RTRIM(CONVERT(CHAR(2), employee_id)) + ' - ' + first_name) AS Employees FROM Employee");
            cmbCal.DisplayMember = "Employees";
            cmbCal.ValueMember = "employee_id";
            cmbCal.DataSource = employeesDataTable;


            managersDataTable = sqlFunc.Select("SELECT manager_id, (RTRIM(CONVERT(char(2), manager_id)) + ' - ' + first_name) as manager FROM Managers");
            cmbYone.DisplayMember = "manager";
            cmbYone.ValueMember = "manager_id";
            cmbYone.DataSource = managersDataTable;


            cmbCal.SelectedIndexChanged += cmbCal_SelectedIndexChanged;
        }

        private void cmbCal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCal.SelectedValue != null)
            {

                DataRowView selectedRow = (DataRowView)cmbCal.SelectedItem;
                int selectedManagerId = Convert.ToInt32(selectedRow["manager_id"]);


                cmbYone.SelectedValue = selectedManagerId;
            }
        }

        private void nPuan_ValueChanged(object sender, EventArgs e)
        {
            nPuan.Minimum = 1;
            nPuan.Maximum = 10;
        }

        private void SavePerf_Click(object sender, EventArgs e)
        {
            try
            {

                var employeeId = cmbCal.SelectedValue;
                var managerId = cmbYone.SelectedValue;
                var score = nPuan.Value;
                var comments = Rdeger.Text;

                if (employeeId == null || managerId == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var query = "INSERT INTO Performance (employee_id, manager_id, score, comments) VALUES (@EmployeeID, @ManagerID, @Score, @Comments)";
                var parameters = new Dictionary<string, object>
                {
                    { "@EmployeeID", employeeId },
                    { "@ManagerID", managerId },
                    { "@Score", score },
                    { "@Comments", comments }
                };

                var sonuc = sqlFunc.Insert(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmpPerf_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            MainPage mP = new MainPage();
            mP.ShowDialog();
            this.Close();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeId = cmbCal.SelectedValue;

                if (employeeId != null)
                {
                    var deleteQuery = "DELETE FROM Performance WHERE employee_id = @EmployeeIDDelete";
                    var deleteParameters = new Dictionary<string, object>
            {
                { "@EmployeeIDDelete", employeeId }
            };

                    var sonuc = sqlFunc.Delete(deleteQuery, deleteParameters);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Performans kayıtları başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Verileri yeniden yükle
                        this.performanceTableAdapter.Fill(this.insertCoDuzDataSet.Performance);
                        employeesDataTable = sqlFunc.Select("SELECT employee_id, manager_id, (RTRIM(CONVERT(CHAR(2), employee_id)) + ' - ' + first_name) AS Employees FROM Employee");
                        cmbCal.DisplayMember = "Employees";
                        cmbCal.ValueMember = "employee_id";
                        cmbCal.DataSource = employeesDataTable;

                        managersDataTable = sqlFunc.Select("SELECT manager_id, (RTRIM(CONVERT(char(2), manager_id)) + ' - ' + first_name) as manager FROM Managers");
                        cmbYone.DisplayMember = "manager";
                        cmbYone.ValueMember = "manager_id";
                        cmbYone.DataSource = managersDataTable;

                        // Seçimleri temizle
                        cmbCal.SelectedIndex = -1;
                        cmbYone.SelectedIndex = -1;
                        nPuan.Value = 1;
                        Rdeger.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Performans kayıtları silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz çalışanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası: " + ex.Message, "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
