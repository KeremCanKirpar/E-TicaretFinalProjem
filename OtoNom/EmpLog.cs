using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoNom
{
    public partial class EmpLog : Form
    {
        public EmpLog()
        {
            InitializeComponent();
        }
        SqlFunc sqlFunc = new SqlFunc();
        private void CalLogin_Click(object sender, EventArgs e)
        {
            int empId =2;
            try
            {
             var sonuc = sqlFunc.Select("Select * From Employee WHERE TcKimlik = '" + txtEmpTc.Text +"'");

                EmpProjeAd empProjeAdForm = new EmpProjeAd(empId);
                empProjeAdForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :", ex.Message);
            }
           
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
