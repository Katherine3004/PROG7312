using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_KatherineChambers18003948
{
    public partial class ReplacingLevelForm : Form
    {
        public ReplacingLevelForm()
        {
            InitializeComponent();
        }
        //close
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimize
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //go back to previous page
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            ReplacingLevel1Form l1 = new ReplacingLevel1Form();
            this.Hide();
            l1.ShowDialog();
            this.Close();
        }

        private void ReplacingLevel1Form_Load(object sender, EventArgs e)
        {

        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            ReplacingLevel2Form l2 = new ReplacingLevel2Form();
            this.Hide();
            l2.ShowDialog();
            this.Close();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            ReplacingLevel3Form l3 = new ReplacingLevel3Form();
            this.Hide();
            l3.ShowDialog();
            this.Close();
        }
    }
}
