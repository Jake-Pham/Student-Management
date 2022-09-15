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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        SCORE score = new SCORE();

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Score.student_id,std.fname,lname,course_id,Course.label,student_score FROM Score,std,Course Where Score.student_id=std.Id AND score.course_id=Course.Id", mydb.GetConnection);
            System.Data.DataTable table = new System.Data.DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Score.student_id,std.fname,lname,course_id,Course.label,student_score FROM Score,std,Course Where Score.student_id=std.Id AND score.course_id=Course.Id", mydb.GetConnection);
            System.Data.DataTable table = new System.Data.DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dataGridView1.ReadOnly = true;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void RemoveScoreButton_Click(object sender, EventArgs e)
        {
            //try
            //{
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
            //}
            //catch
            //{
               //MessageBox.Show("Please Choose A StudentID Or CourseID", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
