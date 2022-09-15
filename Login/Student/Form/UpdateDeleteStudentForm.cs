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
using System.IO;

namespace Login
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDtxt.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id=" + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                FirstNametxt.Text = table.Rows[0]["fname"].ToString();
                LastNametxt.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                //gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    Female.Checked = true;
                }
                else
                {
                    Male.Checked = true;
                }
                Phonetxt.Text = table.Rows[0]["phone"].ToString();
                Addresstxt.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream pictrure = new MemoryStream(pic);
                PictureBoxStudentImage1.Image = Image.FromStream(pictrure);
            }
            else
            {
                MessageBox.Show("not found", "Find student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(IDtxt.Text);
                if(MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields after delete
                        IDtxt.Text = "";
                        FirstNametxt.Text = "";
                        LastNametxt.Text = "";
                        Addresstxt.Text = "";
                        Phonetxt.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog()==DialogResult.OK)
            {
                PictureBoxStudentImage1.Image = Image.FromFile(opf.FileName);
            }
        }
        //Verify data
        bool verif()
        {
            if((IDtxt.Text.Trim()=="") || (FirstNametxt.Text.Trim()=="") || (LastNametxt.Text.Trim()=="") || (Addresstxt.Text.Trim()=="") || (Phonetxt.Text.Trim()=="") || (PictureBoxStudentImage1.Image==null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtxt.Text);
            string fname = FirstNametxt.Text;
            string lname = LastNametxt.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = Phonetxt.Text;
            string adrs = Addresstxt.Text;
            string gender = "Male";
            if(Female.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (student.checkID(id))
            {
                MessageBox.Show("This Student Already Exist", "Add new student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //allow only student age between 10-100;
            if (((this_year - born_year) < 10) || ((this_year - born_year > 100)))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(verif())
            {
                try
                {
                    PictureBoxStudentImage1.Image.Save(pic, PictureBoxStudentImage1.Image.RawFormat);
                    if(student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //kiem tra nhap vao la ky tu

        private void IDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
