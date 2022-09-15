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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            studentListForm stdform = new studentListForm();
            stdform.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staticsForm = new StaticsForm();
            staticsForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStdF = new ManageStudentForm();
            manageStdF.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addcourse = new AddCourseForm();
            addcourse.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removecourse = new RemoveCourseForm();
            removecourse.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm edit = new EditCourseForm();
            edit.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm mngForm = new ManageCourseForm();
            mngForm.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm print = new PrintCourseForm();
            print.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addscore = new AddScoreForm();
            addscore.Show();
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avg = new AvgScoreByCourse();
            avg.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm remove = new RemoveScoreForm();
            remove.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manage = new ManageScoreForm();
            manage.Show();
        }

        private void aVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            result.Show();
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm staticresult = new StaticResultForm();
            staticresult.Show();
        }
    }
}
