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
    public partial class EditContacForm : Form
    {
        public EditContacForm()
        {
            InitializeComponent();
        }

        private void SelectContactButton_Click(object sender, EventArgs e)
        {
            SelectContactForm scf = new SelectContactForm();
            scf.Show();
            int contactid = Int32.Parse(scf.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            CONTACT cnt = new CONTACT();
            DataTable table = cnt.getContactById(contactid);
            IDTextBox.Text = table.Rows[0]["Id"].ToString().Trim();
            FirstNameTextBox.Text = table.Rows[0]["fname"].ToString().Trim();
            LastNameTextBox.Text = table.Rows[0]["lname"].ToString().Trim();
            GroupComboBox.SelectedValue = table.Rows[0]["group_id"];
            PhoneTextBox.Text = table.Rows[0]["phone"].ToString().Trim();
            AddressTextBox.Text = table.Rows[0]["address"].ToString().Trim();
            EmailTextBox.Text = table.Rows[0]["email"].ToString().Trim();
            byte[] pic = (byte[])table.Rows[0]["pic"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }

        private void EditContacForm_Load(object sender, EventArgs e)
        {
            GROUP grp = new GROUP();
            GroupComboBox.DataSource = grp.getGroups(Globals.GlobalUserId);
            GroupComboBox.DisplayMember = "Name";
            GroupComboBox.ValueMember = "ID";
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            CONTACT cnt = new CONTACT();
            string fname = FirstNameTextBox.Text;
            string lname = LastNameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string email = EmailTextBox.Text;
            int userid = Globals.GlobalUserId;
            try
            {
                int id = Int32.Parse(IDTextBox.Text);
                int groupid = (int)GroupComboBox.SelectedValue;
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (cnt.updateContact(id, fname, lname, phone, address, email, userid, groupid, pic))
                {
                    MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
