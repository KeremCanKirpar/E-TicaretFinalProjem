using Guna.UI2.WinForms.Suite;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpLeave : Form
    {
        public EmpLeave()
        {
            InitializeComponent();
        }

        SqlFunc SqlFunc = new SqlFunc();
        private string connectionString = @"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;";

        private void EmpLeave_Load(object sender, EventArgs e)
        {
            this.leaveTableAdapter.Fill(this.insertCoDuzDataSet.Leave);

            
            var gelenCal = SqlFunc.Select("SELECT employee_id, (RTRIM(CONVERT(CHAR(2), employee_id)) + ' - ' + first_name) AS Employees FROM Employee");
            cmbEmp.DisplayMember = "Employees";
            cmbEmp.ValueMember = "employee_id";
            cmbEmp.DataSource = gelenCal;

            
            var gelenType = SqlFunc.Select("SELECT LeaveType_id, LeaveType FROM LeaveType");
            cmbLtype.DisplayMember = "LeaveType";
            cmbLtype.ValueMember = "LeaveType_id"; 
            cmbLtype.DataSource = gelenType;

            
            cmbLtype.SelectedIndexChanged += cmbLtype_SelectedIndexChanged;
        }

        private void cmbLtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLtype.SelectedValue != null)
            {
                int leaveTypeId = Convert.ToInt32(cmbLtype.SelectedValue);
                GetLeaveRights(leaveTypeId);
            }
        }

        private void GetLeaveRights(int leaveTypeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT default_days FROM LeaveType WHERE LeaveType_id = @LeaveTypeId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LeaveTypeId", leaveTypeId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        label6.Text = "İzin Hakkı: " + result.ToString();
                    }
                    else
                    {
                        label6.Text = "İzin Hakkı bulunamadı.";
                    }
                }
            }
        }

        private void LeaveSet_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Convert.ToInt32(cmbEmp.SelectedValue);
                DateTime startDate = dateStart.Value;
                DateTime endDate = dateEnd.Value;
                TimeSpan duration = endDate - startDate;
                int daysRequested = duration.Days + 1;

                int leaveTypeId;
                if (cmbLtype.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cmbLtype.SelectedValue;
                    leaveTypeId = Convert.ToInt32(drv["LeaveType_id"]);  
                }
                else
                {
                    leaveTypeId = Convert.ToInt32(cmbLtype.SelectedValue);
                }

                string approvalStatus = cmbStat.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string getRightsQuery = "SELECT default_days FROM LeaveType WHERE LeaveType_id = @LeaveTypeId";
                    using (SqlCommand cmd = new SqlCommand(getRightsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@LeaveTypeId", leaveTypeId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int leaveRights = Convert.ToInt32(result);
                            if (leaveRights >= daysRequested)
                            {
                                
                                string insertQuery = "INSERT INTO Leave (employee_id, start_date, end_date, Leave_type, status) VALUES (@EmployeeID, @StartDate, @EndDate, @LeaveType, @ApprovalStatus)";
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                                    insertCmd.Parameters.AddWithValue("@StartDate", startDate);
                                    insertCmd.Parameters.AddWithValue("@EndDate", endDate);
                                    insertCmd.Parameters.AddWithValue("@LeaveType", leaveTypeId);
                                    insertCmd.Parameters.AddWithValue("@ApprovalStatus", approvalStatus);

                                    insertCmd.ExecuteNonQuery();
                                }

                                
                                int newLeaveRights = leaveRights - daysRequested;
                                string updateRightsQuery = "UPDATE LeaveType SET default_days = @NewLeaveRights WHERE LeaveType_id = @LeaveTypeId";
                                using (SqlCommand updateCmd = new SqlCommand(updateRightsQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@NewLeaveRights", newLeaveRights);
                                    updateCmd.Parameters.AddWithValue("@LeaveTypeId", leaveTypeId);

                                    updateCmd.ExecuteNonQuery();
                                }

                               
                                label6.Text = "İzin Hakkı: " + newLeaveRights.ToString();

                                MessageBox.Show("İzin başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EmpLeave_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Yetersiz izin hakkı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("İzin türü bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İzni kaydederken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            MainPage mP = new MainPage();
            mP.ShowDialog();
            this.Close();
        }
    }
}
