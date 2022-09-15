using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ManageCourseForm : Form
    {
        COURSE course = new COURSE();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            CourseListBox.DataSource = course.getAllCourses();
            CourseListBox.ValueMember = "id";
            CourseListBox.DisplayMember = "label";
            CourseListBox.SelectedItem = null;
            TotalCourseLabel.Text = ("Total Course:" + course.totalCourse());
        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            CourseListBox.SelectedIndex = index;
            IDTextBox.Text = dr.ItemArray[0].ToString();
            LabelTextBox.Text = dr.ItemArray[1].ToString();
            HoursNumericUpDown.Value = int.Parse(dr.ItemArray[2].ToString());
            DescriptionTextBox.Text = dr.ItemArray[3].ToString();
        }

        //dung thu datarowview xem tung dong
        private void CourseListBox_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)CourseListBox.SelectedItem;
            pos = CourseListBox.SelectedIndex;
            showData(pos);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string label = LabelTextBox.Text;
            int hours = (int)HoursNumericUpDown.Value;
            string description = DescriptionTextBox.Text;
            if (label.Trim() == "")
            {
                MessageBox.Show("Add A New Course Name", "Add New Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(label))
            {
                if (course.insertCourse(id, label, hours, description))
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            string label = LabelTextBox.Text;
            int hrs = (int)HoursNumericUpDown.Value;
            string descr = DescriptionTextBox.Text;
            int id = int.Parse(IDTextBox.Text);
            if (!course.checkCourseName(label, Convert.ToInt32(IDTextBox.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, label, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(IDTextBox.Text);
                if(MessageBox.Show("Are You Sure You Want To Delete This Course","Remove Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        IDTextBox.Text = "";
                        LabelTextBox.Text = "";
                        HoursNumericUpDown.Value = 10;
                        DescriptionTextBox.Text = "";
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if(pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
