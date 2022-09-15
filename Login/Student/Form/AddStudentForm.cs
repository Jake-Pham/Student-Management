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
    public partial class AddStudentForm : Form
    {
        MY_DB mydb = new MY_DB();
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(StudentIDtxt.Text);
            string fname = FirstNametxt.Text;
            string lname = LastNametxt.Text;
            DateTime bdt = dateTimePicker1.Value;
            string phone = Phonetxt.Text;
            string adrs = Addresstxt.Text;
            string gender = "Male";
            if (Female.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            SqlCommand comm = new SqlCommand("Select * from std where Id =@id", mydb.GetConnection);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("This Student Already Exsist", "Add new Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be  between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdt, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New student added", "Add new student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add new student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((FirstNamelable.Text.Trim() == "") || (LastNamelable.Text.Trim() == "") || (Addresslable.Text.Trim() == "") || (Phonelable.Text.Trim() == "") || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void UpLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg; *.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
