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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        //close
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimizing
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //go to replacing form
        private void btnReplacing_Click(object sender, EventArgs e)
        {
            ReplacingLevelForm l1 = new ReplacingLevelForm();
            this.Hide();
            l1.ShowDialog();
            this.Close();
        }
    }
}
