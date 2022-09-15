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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            CONTACT cnt = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT Id as ID,fname as FirstName,lname as LastName, group_id as GroupID FROM mycontacts WHERE userid = @uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView1.DataSource = cnt.SelectContactList(command);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
