using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Login
{
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            ResultForm avg = new ResultForm();
            SqlCommand command = new SqlCommand("Select Id, fname as 'First Name', 'lname as'Last Name from std", mydb.GetConnection);
            avg.fillgrid(command);
            SqlCommand command2 = new SqlCommand("Select label from course", mydb.GetConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            adapter.Fill(table);
            for(int i=0; i<table.Rows.Count; i++)
            {
                int dem = 0;
                double tong = 0;
                for(int j=0; j<avg.dataGridView1.Rows.Count; j++)
                {
                    if(avg.dataGridView1.Rows[j].Cells[3+i].Value.ToString() != "N/A")
                    {
                        tong += Convert.ToDouble(avg.dataGridView1.Rows[j].Cells[3 + i].Value.ToString());
                        dem++;
                    }
                }
                double diemtong = Math.Round(tong / dem, 2);
                richTextBox1.Text += table.Rows[i][0].ToString() + ":" + diemtong.ToString() + "\n";
            }
            int dau = 0;
            int rot = 0;
            int unknow = 0;
            for (int i = 0; i < avg.dataGridView1.Rows.Count; i++)
            {
                if (avg.dataGridView1.Rows[i].Cells[3 + table.Rows.Count].Value != "NaN")
                {
                    if (Convert.ToDouble(avg.dataGridView1.Rows[i].Cells[3 + table.Rows.Count].Value.ToString()) >= 5)
                    {
                        dau++;
                    }
                    else
                        rot++;
                }
                else unknow++;
            }
            double tiledau = Math.Round((Convert.ToDouble(dau) / (avg.dataGridView1.Rows.Count-unknow)) * 100, 2);
            double tilerot = Math.Round((Convert.ToDouble(rot) / (avg.dataGridView1.Rows.Count-unknow)) * 100, 2);
            PassLabel.Text += tiledau.ToString() + "%";
            FailLabel.Text += tilerot.ToString() + "%";
            if (tiledau == 100)
            {
                chart1.Series["Result"].Points.AddXY("Pass", tiledau.ToString());
            }
            else if (tilerot == 100)
            {
                chart1.Series["Result"].Points.AddXY("Fail", tilerot.ToString());
            }
            else
            {
                chart1.Series["Result"].Points.AddXY("Pass", tiledau.ToString());
                chart1.Series["Result"].Points.AddXY("Fail", tilerot.ToString());
            }
        }
    }
}
