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
using System.Data;

namespace Login
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        RESULT rs = new RESULT();
        STUDENT student = new STUDENT();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Id,fname as 'First Name',lname as 'Last Name' from std where CONCAT(Id,fname,lname) Like'%" + SearchTextBox.Text + "%'", mydb.GetConnection);
            fillgrid(command);
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Id,fname as 'First Name',lname as 'Last Name' from std", mydb.GetConnection);
            fillgrid(command);
        }
        public void fillgrid(SqlCommand comm2)
        {
            SqlCommand comm1 = new SqlCommand("Select label from Course", mydb.GetConnection);
            DataTable tablelable = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(comm1);
            adapter1.Fill(tablelable);
            SqlCommand command2 = new SqlCommand("Select Id,fname as 'First Name',lname as 'Last Name' from std", mydb.GetConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            adapter2.Fill(table);
            for (int i = 0; i < tablelable.Rows.Count; i++)
            {
                table.Columns.Add(tablelable.Rows[i][0].ToString());
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    int id = Convert.ToInt32(table.Rows[j][0].ToString());
                    table.Rows[j][3 + i] = rs.checkid(id, tablelable.Rows[i][0].ToString());
                }
            }
            table.Columns.Add("AverageScore");
            for (int j = 0; j < table.Rows.Count; j++)
            {
                int dem = 0;
                int sum = 0;
                for (int i = 0; i < tablelable.Rows.Count; i++)
                {
                    if ((table.Rows[j][3 + i].ToString()) != "N/A")
                        sum += Convert.ToInt32(table.Rows[j][3 + i].ToString());
                    else
                        dem++;

                }
                table.Rows[j][3 + tablelable.Rows.Count] = Math.Round(Convert.ToDouble(sum) / (tablelable.Rows.Count - dem),2);
            }
            table.Columns.Add("Result");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                double diem = Convert.ToDouble(table.Rows[i][tablelable.Rows.Count + 3].ToString());
                if (diem >= 8)
                {
                    table.Rows[i][tablelable.Rows.Count + 4] = 'A';
                }
                else if (diem >= 6.5)
                {
                    table.Rows[i][tablelable.Rows.Count + 4] = 'B';
                }
                else if (diem >= 5)
                {
                    table.Rows[i][tablelable.Rows.Count + 4] = 'C';
                }
                else if (diem >= 3)
                {
                    table.Rows[i][tablelable.Rows.Count + 4] = 'D';
                }
                else
                {
                    table.Rows[i][tablelable.Rows.Count + 4] = 'F';
                }
            }
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FirstNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            LastNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }
    }
}
