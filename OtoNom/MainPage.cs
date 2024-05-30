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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EmpAd_Click(object sender, EventArgs e)
        {
            EmpAd em = new EmpAd();
            this.Hide();
            em.ShowDialog();
        }

        private void EmpLeave_Click(object sender, EventArgs e)
        {
            EmpLeave eL = new EmpLeave();
            this.Hide();
            eL.ShowDialog();
        }

        private void SPro_Click(object sender, EventArgs e)
        {
            ShowProjeManager Spro = new ShowProjeManager();
            this.Hide();
            Spro.ShowDialog();
        }

        private void EmpPerf_Click(object sender, EventArgs e)
        {
            EmpPerf eP = new EmpPerf();
            this.Hide();
            eP.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EmpSalary Es = new EmpSalary();
            this.Hide();
            Es.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
