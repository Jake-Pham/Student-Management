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
    public partial class HRLoginForm : Form
    {
        public HRLoginForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        HRAccount acc = new HRAccount();
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = FirstNameTextBox.Text;
            string lname = LastNameTextBox.Text;
            string uname = UserNameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            MemoryStream pic = new MemoryStream();
            SqlCommand comm = new SqlCommand("Select * from HR_Log_in where Id =@id", mydb.GetConnection);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This User Already Exsist", "Add new user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (acc.insertAccount(id, fname, lname, uname, pwd, pic))
                {
                    MessageBox.Show("New user added", "Add new user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add new user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ( (IDTextBox.Text.Trim() == "") || (FirstNameTextBox.Text.Trim() == "") || (LastNameLabel.Text.Trim() == "") || (UserNameTextBox.Text.Trim() == "") || (PasswordTextBox.Text.Trim() == ""))
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
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg; *.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void HaveAnAccountLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
