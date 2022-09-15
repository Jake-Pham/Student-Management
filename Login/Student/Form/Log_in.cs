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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            if(StudentRadioButton.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username=@User AND pass=@Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("OK, next time will be go to Main Menu of App");
                    MainForm main = new MainForm();
                    main.Show();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (HumanResourceRadioButton.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM HR_Log_in WHERE uname=@User AND pwd=@Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    ContactForm contact = new ContactForm();
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    //dùng 1 lớp static Global class, lớp này đung để lấy giá trị id
                    Globals.SetGlobalUserIId(userid);
                    contact.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/user.png");
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();
            }
        }

        private void CreateLabel_DoubleClick(object sender, EventArgs e)
        {
            if (StudentRadioButton.Checked)
            {
                RegisterForm res = new RegisterForm();
                res.Show();
            }
            if(HumanResourceRadioButton.Checked)
            {
                HRLoginForm HRres = new HRLoginForm();
                HRres.Show();
            }
        }

        private void TextBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            checkUsername();
        }
        private bool checkUsername()
        {
            bool User_status = true;
            if (TextBoxUserName.Text == "")
            {
                errorProvider1.SetError(TextBoxUserName, "Enter UserName");
                User_status = false;
            }
            else
                errorProvider1.SetError(TextBoxUserName, "");
            return User_status;
        }

    }
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study\Window Programming\Phạm Trung Kiên - 19110384\Login\Login\Kien.mdf;Integrated Security=True");
        //get the connection
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        //open the connection
        public void openConnection()
        {
            if((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        //close the connection
        public void closeConnection()
        {
            if((con.State==ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
