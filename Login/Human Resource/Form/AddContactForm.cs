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
using System.Data.SqlClient;

namespace Login
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = FirstNameTextBox.Text;
            string lname = LastNameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string email = EmailTextBox.Text;
            int userid = Globals.GlobalUserId;
            //get the group id
            int groupid = (int)GroupComboBox.SelectedValue;
            //get th image
            MemoryStream pic = new MemoryStream();
            CONTACT contact = new CONTACT();
            if (contact.checkIdContact(Convert.ToInt32(id)))
            {
                MessageBox.Show("Contact ID Already Exists", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (contact.insertContact(id, fname, lname, groupid, phone, email, address,pic, userid))
                {
                    MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FirstNameTextBox.Text = "";
                    LastNameTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    EmailTextBox.Text = "";
                    AddressTextBox.Text = "";
                    IDTextBox.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool verif()
        {
            if ((FirstNameTextBox.Text.Trim() == "") || (LastNameTextBox.Text.Trim() == "") || (GroupComboBox.Items.ToString() == "") || (EmailTextBox.Text.Trim() == "") || (IDTextBox.Text.Trim() == "") || (AddressTextBox.Text.Trim() == "") || (PhoneTextBox.Text.Trim() == "") || (pictureBox1.Image == null))
                return false;
            else
                return true;
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();


            GroupComboBox.DataSource = group.getGroups(Globals.GlobalUserId);
            GroupComboBox.DisplayMember = "name";
            GroupComboBox.ValueMember = "id";

        }

        private void UploadPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
