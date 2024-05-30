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
    public partial class YoneOrEmp : Form
    {
        public YoneOrEmp()
        {
            InitializeComponent();
        }

        private void EnYone_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void EnterCal_Click(object sender, EventArgs e)
        {
            EmpLog Elo = new EmpLog();
            this.Hide();
            Elo.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
