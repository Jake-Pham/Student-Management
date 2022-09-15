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

namespace Login
{
    public partial class ShowFullListForm : Form
    {
        public ShowFullListForm()
        {
            InitializeComponent();
        }

        private void ShowFullListForm_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            CONTACT cnt = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT fname as FirstName, lname as LastName, mygroups.name as GroupName, phone as Phone, email as Email, address as Address, pic as Picture FROM mycontacts INNER JOIN mygroups ON mycontacts.group_id = mygroups.Id WHERE mycontacts.userid=@uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView1.DataSource = cnt.SelectContactList(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (isOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            GROUP grp = new GROUP();
            GroupListBox.DataSource = grp.getGroups(Globals.GlobalUserId);
            GroupListBox.DisplayMember = "name";
            GroupListBox.ValueMember = "Id";
            GroupListBox.SelectedItem = null;
            dataGridView1.ClearSelection();
        }
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (isOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void GroupListBox_Click(object sender, EventArgs e)
        {
            try
            {
                CONTACT cnt = new CONTACT();
                int groupid = (Int32)GroupListBox.SelectedValue;
                SqlCommand command = new SqlCommand("SELECT fname as FirstName, lname as LastName, mygroups.name as GroupName, phone as Phone, email as Email,  address as Address, pic FROM mycontacts INNER JOIN mygroups ON mycontacts.group_id = mygroups.Id WHERE mycontacts.userid=@uid AND mycontacts.group_id=@gid");
                command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
                dataGridView1.DataSource = cnt.SelectContactList(command);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (isOdd(i))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception)
            {

            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void labelShowAll_Click(object sender, EventArgs e)
        {
            ShowFullListForm_Load(null, null);
        }

    }
}
