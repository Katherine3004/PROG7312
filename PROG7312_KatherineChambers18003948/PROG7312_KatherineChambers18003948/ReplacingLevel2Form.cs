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
    public partial class ReplacingLevel2Form : Form
    {
        public ReplacingLevel2Form()
        {
            InitializeComponent();
        }
        //close
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReplacingLevelForm replacing = new ReplacingLevelForm();
            this.Hide();
            replacing.ShowDialog();
            this.Close();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            //if no item is selected
            if (lbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select book to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //to move item up
            else
            {
                //when moving item up index needs to change to -1
                int newIndex = lbBooks.SelectedIndex - 1;
                //if item is < new index
                if (newIndex < 0)
                    return;
                //select item
                object selectedItem = lbBooks.SelectedItem;
                //remove the selected item
                lbBooks.Items.Remove(selectedItem);
                //place selected item where the new index is
                lbBooks.Items.Insert(newIndex, selectedItem);
                //keep selected item selected
                lbBooks.SetSelected(newIndex, true);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //if no item is selected
            if (lbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select book to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //to move item down
            else
            {
                //when moving item up index needs to change to +1
                int newIndex = lbBooks.SelectedIndex + 1;
                //if item is > how mmay items are in listbox
                if (newIndex >= lbBooks.Items.Count)
                    return;
                //select item
                object selectedItem = lbBooks.SelectedItem;
                //remove the selected item
                lbBooks.Items.Remove(selectedItem);
                //place selected item where the new index is
                lbBooks.Items.Insert(newIndex, selectedItem);
                //keep selected item selected
                lbBooks.SetSelected(newIndex, true);
            }
        }

        private void ReplacingLevel2Form_Load(object sender, EventArgs e)
        {
            List<Book> library = LibraryManager.getBooks2();
            foreach (var book in library)
            {
                lbBooks.Items.Add($"{book.dewey}");
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //listbox to list
            List<Book> bookList = lbBooks.Items.OfType<Book>().ToList();
            //get answer list
            List<Book> answers2 = LibraryManager.getBookAnswer2();
            //if the lists are equal
            if (bookList.SequenceEqual(answers2))
            {
                DialogResult dialogResult = MessageBox.Show("Well Done! Do you want to try Level 2?", "Congratulations", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ReplacingLevel3Form l3 = new ReplacingLevel3Form();
                    this.Hide();
                    l3.ShowDialog();
                    this.Close();
                }
                else
                {
                    HomeForm home = new HomeForm();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Try again", "Oh No", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
