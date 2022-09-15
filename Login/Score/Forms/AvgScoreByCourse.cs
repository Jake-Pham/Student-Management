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
    public partial class AvgScoreByCourse : Form
    {
        public AvgScoreByCourse()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();

        private void AvgScoreByCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = score.getAvgScoreByCourse();
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                chart1.Series["Diem"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value, Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));

            }
        }

    }
}
