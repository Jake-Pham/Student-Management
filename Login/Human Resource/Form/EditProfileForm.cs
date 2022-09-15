using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }
        USER user = new USER();

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            IDTextBox.ReadOnly = true;
            int id;
            string fname = FirstNameTextBox.Text;
            string lname = LastNameTextBox.Text;
            string uname = UserNameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    id = Convert.ToInt32(IDTextBox.Text);
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (user.updateUser(id, fname, lname, uname, pwd, pic))
                    {
                        MessageBox.Show("User Information Updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((FirstNameTextBox.Text.Trim() == "") || (LastNameTextBox.Text.Trim() == "") || (UserNameTextBox.Text.Trim() == "") || (PasswordTextBox.Text.Trim() == "") || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UploadPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
