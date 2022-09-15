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
using System.IO;
namespace Login
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void studentListForm_Load(object sender, EventArgs e)
        {
            //this.stdTableAdapter.Fill(this.viduDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT Id as ID, fname as FirstName, lname as LastName, bdate as BirthDate, gender as Gender, phone as Phone, address as Address, picture as Picture  FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updatedeleteStdF = new UpdateDeleteStudentForm();
            updatedeleteStdF.IDtxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updatedeleteStdF.FirstNametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updatedeleteStdF.LastNametxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updatedeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if((dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                updatedeleteStdF.Female.Checked = true;
            }
            updatedeleteStdF.Phonetxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updatedeleteStdF.Addresstxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updatedeleteStdF.PictureBoxStudentImage1.Image = Image.FromStream(picture);
            updatedeleteStdF.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true; //Nap lai du lieu len datagridview
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
