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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            //Get panels color
            panTotalColor = PanelTotal.BackColor=Color.White;
            panMaleColor = PanelMale.BackColor=Color.White;
            panFemaleColor = PanelFemale.BackColor=Color.White;
            //Display the value
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            double maleStudentPercentage = (totalMale * (100 / total));
            double femaleStudentPercentage = (totalFemale * (100 / total));
            TotalLabel.Text = ("Total Student:" + total.ToString());
            MaleLabel.Text = ("Male:" + (maleStudentPercentage.ToString("0.00") + "%"));
            FemaleLabel.Text = ("Female:" + (femaleStudentPercentage.ToString("0.00") + "%"));
            fillChart();
        }
        private void fillChart()
        {
            STUDENT student = new STUDENT();
            chart1.Series["Gender"].Points.AddXY("Male", student.totalMaleStudent().ToString());
            chart1.Series["Gender"].Points.AddXY("Female", student.totalFemaleStudent().ToString());
            chart1.Titles.Add("Gender Chart");
        }
    }
}
