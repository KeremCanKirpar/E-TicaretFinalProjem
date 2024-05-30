using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpSalary : Form
    {
        public EmpSalary()
        {
            InitializeComponent();
        }

        SqlFunc sqlFunc = new SqlFunc();

        private void EmpSalary_Load(object sender, EventArgs e)
        {
            this.salariesTableAdapter.Fill(this.insertCoDuzDataSet.Salaries);

            var gelenCal = sqlFunc.Select("SELECT employee_id, (RTRIM(CONVERT(CHAR(2), employee_id)) + ' - ' + first_name) AS Employees FROM Employee");
            cmbCal.DisplayMember = "Employees";
            cmbCal.ValueMember = "employee_id";
            cmbCal.DataSource = gelenCal;
        }

        private void ZamY_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeId = cmbCal.SelectedValue;

                if (employeeId != null)
                {
                    var selectSalaryQuery = "SELECT TOP 1 salary_amount, Month FROM Salaries WHERE employee_id = @EmployeeID ORDER BY Year DESC, Month DESC";
                    var selectSalaryParameters = new Dictionary<string, object>
            {
                { "@EmployeeID", employeeId }
            };
                    var salaryResult = sqlFunc.Select(selectSalaryQuery, selectSalaryParameters);

                    if (salaryResult.Rows.Count > 0)
                    {
                        var currentSalary = Convert.ToDecimal(salaryResult.Rows[0]["salary_amount"]);
                        var currentMonth = salaryResult.Rows[0]["Month"].ToString(); 
                        var newSalary = currentSalary * 1.10m;
                        var currentYear = DateTime.Now.Year;

                        var updateQuery = "UPDATE Salaries SET salary_amount = @NewSalary WHERE employee_id = @EmployeeID2 AND Month = @Month2 AND Year = @Year2";
                        var updateParameters = new Dictionary<string, object>
                {
                    { "@NewSalary", newSalary },
                    { "@EmployeeID2", employeeId },
                    { "@Month2", currentMonth }, 
                    { "@Year2", currentYear }
                };

                        var sonuc = sqlFunc.Update(updateQuery, updateParameters);

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Maaş başarıyla zamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmpSalary_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Maaş zammı başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçilen çalışanın mevcut maaşı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zam yapmak istediğiniz çalışanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeId = cmbCal.SelectedValue;

                if (employeeId != null)
                {
                    var month = txtMonth.Text;
                    var year = txtYear.Text;
                    var salaryAmount = txtSalary.Text;

                    if (string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(salaryAmount))
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var insertQuery = "INSERT INTO Salaries (employee_id, Month, Year, salary_amount) VALUES (@EmployeeID, @Month, @Year, @SalaryAmount)";
                    var insertParameters = new Dictionary<string, object>
            {
                { "@EmployeeID", employeeId },
                { "@Month", month },
                { "@Year", year },
                { "@SalaryAmount", salaryAmount }
            };

                    var sonuc = sqlFunc.Insert(insertQuery, insertParameters);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Maaş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmpSalary_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Maaş ekleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
