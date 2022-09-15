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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            CourseComboBox.DataSource = course.getAllCourses();
            CourseComboBox.DisplayMember = "label";
            CourseComboBox.ValueMember = "id";
            CourseComboBox.SelectedItem = null;
        }
        public void fillCombo(int index)
        {
            CourseComboBox.DataSource = course.getAllCourses();
            CourseComboBox.DisplayMember = "label";
            CourseComboBox.ValueMember = "id";
            CourseComboBox.SelectedIndex = index;
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(CourseComboBox.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                LabelTextBox.Text = table.Rows[0][1].ToString();
                PeriodNumericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                DescriptionTextBox.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string label = LabelTextBox.Text;
            int hrs = (int)PeriodNumericUpDown.Value;
            string descr = DescriptionTextBox.Text;
            int id = (int)CourseComboBox.SelectedValue;
            if (hrs < 10)
            {
                MessageBox.Show("The period must have more then 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!course.checkCourseName(label, Convert.ToInt32(CourseComboBox.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(course.updateCourse(id, label, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(CourseComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
