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
    public partial class AddCourseForm : Form
    {
        MY_DB mydb = new MY_DB();
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int id = Convert.ToInt32(IDTextBox.Text);
            string label = LabelTextBox.Text;
            int period = Convert.ToInt32(PeriodTextBox.Text);
            string description = DescriptionTextBox.Text;
            if (course.checkCourseID(id))
            {
                MessageBox.Show("This Subject Already Exsist", "Add New Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (period < 10)
            {
                MessageBox.Show("The period must have more then 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label.Trim() == "")
            {
                MessageBox.Show("Add A New Course Name", "Add New Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(course.checkCourseName(label))
            {
                if(course.insertCourse(id, label, period, description))
                {
                    MessageBox.Show("New Course Added", "Add New Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course  Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Already Exists", "Add New Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
