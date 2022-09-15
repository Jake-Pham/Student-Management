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
    public partial class AddScoreForm : Form
    {
        MY_DB mydb = new MY_DB();
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //Lay thong tin all course
            CourseComboBox.DataSource = course.getAllCourses();
            CourseComboBox.DisplayMember = "label";
            CourseComboBox.ValueMember = "id";
            //dua no voi student
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridView1.DataSource = student.getStudents(command);
        }

        // on datagrircview_student click
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //get the id of the selected student
            StudentIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(StudentIDTextBox.Text);
                int courseID = Convert.ToInt32(CourseComboBox.SelectedValue);
                float scoreValue = Convert.ToInt32(ScoreTextBox.Text);
                string description = DescriptionTextBox.Text;
                //check if the score is already set for this student on this score
                if(!score.studentScoreExist(studentID, courseID))
                {
                    if(score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Coursr Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
