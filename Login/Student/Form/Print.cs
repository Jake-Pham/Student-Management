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
using Word =Microsoft.Office.Interop.Word;

namespace Login
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        STUDENT student=new STUDENT();
        private void Check_Click(object sender, EventArgs e)
        {
            if(All.Checked == true && YES.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std WHERE bdate>@bdate1 AND bdate<@bdate2", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add("@bdate1", SqlDbType.DateTime).Value = bdate1.Value;
                command.Parameters.Add("@bdate2", SqlDbType.DateTime).Value = bdate2.Value;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            if(All.Checked == true && NO.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            if(Male.Checked == true && YES.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std WHERE bdate>@bdate1 AND bdate<@bdate2 AND gender=@Male", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add("@bdate1", SqlDbType.DateTime).Value = bdate1.Value;
                command.Parameters.Add("@bdate2", SqlDbType.DateTime).Value = bdate2.Value;
                command.Parameters.Add("@Male", SqlDbType.NChar).Value = "Male";
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            if(Male.Checked == true && NO.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std WHERE gender=@Male", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add("@Male", SqlDbType.NChar).Value = "Male";
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            if(Female.Checked == true && YES.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std WHERE bdate>@bdate1 AND bdate<@bdate2 AND gender=@Female", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add("@bdate1", SqlDbType.DateTime).Value = bdate1.Value;
                command.Parameters.Add("@bdate2", SqlDbType.DateTime).Value = bdate2.Value;
                command.Parameters.Add("@Female", SqlDbType.NChar).Value = "Female";
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            if(Female.Checked == true && NO.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT Id,fname as Ten,lname as Ho,bdate as 'Ngay Sinh',gender as 'Gioi Tinh',phone as SDT,address as 'Dia Chi',picture as 'Hinh anh' FROM std WHERE gender=@Female", mydb.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add("@Female", SqlDbType.NChar).Value = "Female";
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void SaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAP Files (.txt)|.txt";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));

                string str = "";
                int row = dataGridView1.Rows.Count;
                int cell = dataGridView1.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cell; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "null";
                        }
                        str += dataGridView1.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                    }
                    str += "\n";
                }
                write.WriteLine(str);

                write.Close();
                write.Dispose();
            }
        }

        private void ToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void SaveToDocFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if(DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new Object[RowCount + 1, ColumnCount + 1];
                // add rows
                int r = 0;
                for(int c = 0; c <= ColumnCount -1; c++)
                {
                    for(r = 0; r <= RowCount -1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }// end row loop
                }//end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //Page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                     Type.Missing, Type.Missing, ref ApplyBorders,
                                     Type.Missing, Type.Missing, Type.Missing,
                                     Type.Missing, Type.Missing, Type.Missing,
                                     Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                //add header row manually
                for(int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach(Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Student list";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save image
                for(r = 0; r <= RowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }
                //save the file
                oDoc.SaveAs(filename);
            }

        }
    }
}
