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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(IDTextBox.Text);
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields after delete
                        IDTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course Not Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
