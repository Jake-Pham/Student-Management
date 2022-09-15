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
using System.Drawing.Imaging;
using System.Data.SqlClient;
namespace Login
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        bool verif()
        {
            if ((FirstNameLabel.Text.Trim() == "") || (LastNameLabel.Text.Trim() == "") || (AddressLabel.Text.Trim() == "") || (PhoneLabel.Text.Trim() == "") || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = FnameTextBox.Text;
            string lname = LnameTextBox.Text;
            DateTime bdt = dateTimePicker1.Value;
            string phone = PhoneTextBox.Text;
            string adrs = AddressTextBox.Text;
            string gender = "Male";
            if (FemaleRadioButton.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if(student.checkID(id))
            {
                MessageBox.Show("This Student Already Exist", "Add new student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fillGrid(command);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string fname = FnameTextBox.Text;
            string lname = LnameTextBox.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = PhoneTextBox.Text;
            string adrs = AddressTextBox.Text;
            string gender = "Male";
            if (FemaleRadioButton.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //allow only student age between 10-100;
            if (((this_year - born_year) < 10) || ((this_year - born_year > 100)))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fillGrid(command);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(IDTextBox.Text);
                if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields after delete
                        IDTextBox.Text = "";
                        FnameTextBox.Text = "";
                        LnameTextBox.Text = "";
                        AddressTextBox.Text = "";
                        PhoneTextBox.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
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
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fillGrid(command);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            FnameTextBox.Text = "";
            LnameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            PictureBoxStudentImage.Image = null;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + IDTextBox.Text);
            if(PictureBoxStudentImage.Image==null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else
                if((svf.ShowDialog() == DialogResult.OK))
                {
                    PictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
                }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + SearchTextBox.Text + "%'");
            fillGrid(command);
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Id as ID, fname as FirstName, lname as LastName, bdate as BirthDate, gender as Gender, phone as Phone, address as Address, picture as Picture  FROM std");
            fillGrid(command);
        }
        private void fillGrid(SqlCommand command)
        {
            DataGridView.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            DataGridView.RowTemplate.Height = 80;
            DataGridView.DataSource = student.getStudents(command);
            piccol = (DataGridViewImageColumn)DataGridView.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView.AllowUserToAddRows = false;
            TotalStudentLabel.Text = ("Total Student:" + DataGridView.Rows.Count);
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            IDTextBox.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
            FnameTextBox.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            LnameTextBox.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)DataGridView.CurrentRow.Cells[3].Value;
            if ((DataGridView.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                FemaleRadioButton.Checked = true;
            }
            PhoneTextBox.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            AddressTextBox.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridView.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            //AddStudentCourseForm add = new AddStudentCourseForm();
            //add.StudentIDTextBox.Text = IDTextBox.Text;
            //add.Show();
        }
    }
}
