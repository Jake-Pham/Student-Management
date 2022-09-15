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
    public partial class ManageScoreForm : Form
    {
        MY_DB mydb = new MY_DB();
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        public ManageScoreForm()
        {
            InitializeComponent();
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
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int courseID = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please Choose A StudentID Or CourseID", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avg = new AvgScoreByCourse();
            avg.Show();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //Lay thong tin all course
            CourseComboBox.DataSource = course.getAllCourses();
            CourseComboBox.DisplayMember = "label";
            CourseComboBox.ValueMember = "id";
            //dua no voi student
            SqlCommand command = new SqlCommand("SELECT Score.student_id as ID, std.fname as FirstName, std.lname as LastName, course_id as CourseID, Course.label as Label, student_score as Score, Score.description as Description FROM Score, std, Course Where Score.student_id=std.Id AND score.course_id=Course.Id",mydb.GetConnection);
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as FirstName, lname as LastName, bdate as BirthDate FROM std", mydb.GetConnection);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ShowScoresButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Score.student_id as ID, std.fname as FirstName, std.lname as LastName, course_id as CourseID, Course.label as Label, student_score as Score, Score.description as Description FROM Score, std, Course Where Score.student_id=std.Id AND score.course_id=Course.Id", mydb.GetConnection);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 4)
            {
                StudentIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ScoreTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                DescriptionTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                CourseComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                StudentIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ScoreTextBox.Text = "";
                DescriptionTextBox.Text = "";
            }
        }
    }
}
