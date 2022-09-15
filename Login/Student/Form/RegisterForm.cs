using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND pass = @Pass", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = UserNameTextBox.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = PasswordTextBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("This Account Already Exist", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Account acc = new Account();
                string username = UserNameTextBox.Text;
                string password = PasswordTextBox.Text;
                if (verif())
                {
                    if(acc.insertAccount(username,password))
                    {
                        MessageBox.Show("New Account Created", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        bool verif()
        {
            if((UserNameTextBox.Text.Trim() == "") || (PasswordTextBox.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SignUpButton.PerformClick();
            }
        }
    }
}
