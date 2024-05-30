using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpAd : Form
    {
        SqlConnection conn;

        public EmpAd()
        {
            InitializeComponent();
        }

        SqlFunc SqlFunc = new SqlFunc();

        private void EmpAd_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.insertCoDuzDataSet.Employee);

            var gelenYon = SqlFunc.Select("SELECT manager_id, (RTRIM(CONVERT(char(2),manager_id)) + ' - ' + first_name) as manager FROM Managers");
            cmbYone.DisplayMember = "manager";
            cmbYone.ValueMember = "manager_id";
            cmbYone.DataSource = gelenYon;

            var gelenDep = SqlFunc.Select("SELECT department_id, (RTRIM(CONVERT(CHAR(2),department_id)) + ' - ' + department_name) as Dep FROM Departments");
            cmbDep.DisplayMember = "Dep";
            cmbDep.ValueMember = "department_id";
            cmbDep.DataSource = gelenDep;


        }

        private void EmpSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

               
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                   
                    sqlConnection.Open();

                    
                    var query = "INSERT INTO Employee (first_name, last_name, email, department_id, hire_date, manager_id, Gender, TcKimlik) " +
                                "VALUES (@firstName, @lastName, @Email, @department, @hireDate, @managerId, @Gender, @TcKimlik)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        
                        command.Parameters.AddWithValue("@firstName", txtAd.Text);
                        command.Parameters.AddWithValue("@lastName", txtSoy.Text);
                        command.Parameters.AddWithValue("@Email", txtmail.Text);

                       
                        if (cmbDep.SelectedValue != null && int.TryParse(cmbDep.SelectedValue.ToString(), out int departmentId))
                        {
                            command.Parameters.AddWithValue("@department", departmentId);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir departman seçin.");
                        }

                        command.Parameters.AddWithValue("@hireDate", hire.Value.ToString("yyyy-MM-dd"));

                        if (cmbYone.SelectedValue != null && int.TryParse(cmbYone.SelectedValue.ToString(), out int managerId))
                        {
                            command.Parameters.AddWithValue("@managerId", managerId);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir yönetici seçin.");
                        }

                        if (!string.IsNullOrEmpty(cmbCins.Text))
                        {
                            command.Parameters.AddWithValue("@Gender", cmbCins.Text);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir cinsiyet seçin.");
                        }

                        command.Parameters.AddWithValue("@TcKimlik", txtTc.Text);

                        
                        command.ExecuteNonQuery();

                        
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşturuldu.");
                        EmpAd_Load(sender, e);
                    }

                    
                    sqlConnection.Close();
                }

                
                EmpAd_Load(sender, e);
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
            }
        }

        private void EmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

              
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    
                    sqlConnection.Open();

                    
                    var query = "DELETE FROM Employee WHERE TcKimlik = @TcKimlik";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        
                        if (decimal.TryParse(txtTc.Text, out decimal tcKimlik))
                        {
                            command.Parameters.AddWithValue("@TcKimlik", tcKimlik);
                        }
                        else
                        {
                            throw new Exception("Geçerli bir TC Kimlik numarası girin.");
                        }

                    
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Bulunamadı.");
                        }
                    }

                    
                    sqlConnection.Close();
                }

               
                EmpAd_Load(sender, e);
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
              
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
            }
        }

        private void EmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

               
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                   
                    sqlConnection.Open();

                    
                    var query = "UPDATE Employee SET first_name = @firstName, last_name = @lastName, email = @Email, department_id = @department, hire_date = @hireDate, manager_id = @managerId, Gender = @Gender WHERE TcKimlik = @TcKimlik";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                       
                        command.Parameters.AddWithValue("@firstName", txtAd.Text);
                        command.Parameters.AddWithValue("@lastName", txtSoy.Text);
                        command.Parameters.AddWithValue("@Email", txtmail.Text);

                        
                        if (cmbDep.SelectedValue != null && int.TryParse(cmbDep.SelectedValue.ToString(), out int departmentId))
                        {
                            command.Parameters.AddWithValue("@department", departmentId);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir departman seçin.");
                        }

                        command.Parameters.AddWithValue("@hireDate", hire.Value.ToString("yyyy-MM-dd"));

                        if (cmbYone.SelectedValue != null && int.TryParse(cmbYone.SelectedValue.ToString(), out int managerId))
                        {
                            command.Parameters.AddWithValue("@managerId", managerId);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir yönetici seçin.");
                        }

                        if (!string.IsNullOrEmpty(cmbCins.Text))
                        {
                            command.Parameters.AddWithValue("@Gender", cmbCins.Text);
                        }
                        else
                        {
                            throw new Exception("Lütfen geçerli bir cinsiyet seçin.");
                        }

                        
                        if (decimal.TryParse(txtTc.Text, out decimal tcKimlik))
                        {
                            command.Parameters.AddWithValue("@TcKimlik", tcKimlik);
                        }
                        else
                        {
                            throw new Exception("Geçerli bir TC Kimlik numarası girin.");
                        }

                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Bulunamadı.");
                        }
                    }

                   
                    sqlConnection.Close();
                }

                
                EmpAd_Load(sender, e);
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            MainPage mP = new MainPage();
            mP.Show();
            this.Close();
        }
    }
}
