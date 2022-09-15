using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Login
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        GROUP group = new GROUP();
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM HR_Log_in WHERE Id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                UserNameLabel.Text = "Welcome Back " +table.Rows[0]["l_name"].ToString().Trim()+" "+table.Rows[0]["f_name"].ToString()+"";
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            SelectComboBox1.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox1.DisplayMember = "name";
            SelectComboBox1.ValueMember = "id";
            SelectComboBox2.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox2.DisplayMember = "name";
            SelectComboBox2.ValueMember = "id";
        }

        private void EditLabel_Click(object sender, EventArgs e)
        {
            EditProfileForm edit = new EditProfileForm();
            SqlCommand command = new SqlCommand("SELECT * FROM HR_Log_in WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adpapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adpapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                edit.IDTextBox.Text = table.Rows[0][0].ToString();
                edit.FirstNameTextBox.Text = table.Rows[0][1].ToString();
                edit.LastNameTextBox.Text = table.Rows[0][2].ToString();
                edit.UserNameTextBox.Text = table.Rows[0][3].ToString();
                edit.PasswordTextBox.Text = table.Rows[0][4].ToString();
                byte[] pic = (byte[])table.Rows[0][5];
                MemoryStream picture = new MemoryStream(pic);
                edit.pictureBox1.Image = Image.FromStream(picture);
                edit.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                edit.IDTextBox.ReadOnly = true;
                edit.Show(this);
            }
        }

        private void RefreshLabel_Click(object sender, EventArgs e)
        {
            getImageAndUsername();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContactForm contact = new AddContactForm();
            contact.Show();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDGroupTextBox.Text);
            string grname = GroupNameTextBox.Text;
            int userid = Globals.GlobalUserId;
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE ID=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Group ID Already Exist", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDGroupTextBox.Text = "";
                GroupNameTextBox.Text = "";
            }
            else
            {
                if (verif())
                {
                    if (group.insertGroup(id, grname, userid))
                    {
                        MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            SelectComboBox2.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox2.DisplayMember = "name";
            SelectComboBox2.ValueMember = "id";
            SelectComboBox1.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox1.DisplayMember = "name";
            SelectComboBox1.ValueMember = "id";
        }
        bool verif()
        {
            if (IDGroupTextBox.Text.Trim() == "" || GroupNameTextBox.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void EditGroupButton_Click(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            string gname = NewNameTextBox.Text;
            int gid = (int)SelectComboBox1.SelectedValue;
            int userid = Globals.GlobalUserId;
            string operation = "edit";
            if (verif1())
            {
                if (group.groupExist(gname, operation, userid, gid))
                {
                    MessageBox.Show("Group Name Already Exist", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (group.updateGroup(gid, gname))
                    {
                        MessageBox.Show("Group Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SelectComboBox2.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox2.DisplayMember = "name";
            SelectComboBox2.ValueMember = "id";
            SelectComboBox1.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox1.DisplayMember = "name";
            SelectComboBox1.ValueMember = "id";
        }
        bool verif1()
        {
            if (NewNameTextBox.Text == "")
                return false;
            else
                return true;
        }

        private void RemoveGroupButton_Click(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            int gid = (int)SelectComboBox2.SelectedValue;
            if (group.deleteGroup(gid))
            {
                MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SelectComboBox2.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox2.DisplayMember = "name";
            SelectComboBox2.ValueMember = "id";
            SelectComboBox1.DataSource = group.getGroups(Globals.GlobalUserId);
            SelectComboBox1.DisplayMember = "name";
            SelectComboBox1.ValueMember = "id";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContacForm ecf = new EditContacForm();
            ecf.Show();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SelectContactForm scf = new SelectContactForm();
            scf.ShowDialog();
            EnterContactTextBox.Text =scf.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            CONTACT cnt = new CONTACT();
            try
            {
                int id = Int32.Parse(EnterContactTextBox.Text);
                if (cnt.deleteContact(id))
                {
                    MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            ShowFullListForm fullList = new ShowFullListForm();
            fullList.Show();
        }
    }
}
