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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlFunc SqlFunc = new SqlFunc();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
             MainPage mP = new MainPage();
            try
            {
                var sonuc = SqlFunc.Select("Select * From Managers Where username = '" + txtKul.Text + "'And password = '" + txtSif.Text + "'");
                if (sonuc.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş Yapıldı.");
                    this.Hide();
                    mP.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }

            }
            catch(Exception ex) { 
                MessageBox.Show("Hata:",ex.Message);
            } 
           
        }

        private void passShow_CheckedChanged(object sender, EventArgs e)
        {
            txtSif.PasswordChar = passShow.Checked ? '\0' : '*';
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
