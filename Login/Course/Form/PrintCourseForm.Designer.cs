
namespace Login
{
    partial class PrintCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToFileDocxButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.RefeshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(795, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            // 
            // ToFileDocxButton
            // 
            this.ToFileDocxButton.Location = new System.Drawing.Point(83, 327);
            this.ToFileDocxButton.Name = "ToFileDocxButton";
            this.ToFileDocxButton.Size = new System.Drawing.Size(105, 37);
            this.ToFileDocxButton.TabIndex = 1;
            this.ToFileDocxButton.Text = "To File Docx";
            this.ToFileDocxButton.UseVisualStyleBackColor = true;
            this.ToFileDocxButton.Click += new System.EventHandler(this.ToFileDocxButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(260, 327);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(105, 37);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // RefeshButton
            // 
            this.RefeshButton.Location = new System.Drawing.Point(434, 327);
            this.RefeshButton.Name = "RefeshButton";
            this.RefeshButton.Size = new System.Drawing.Size(105, 37);
            this.RefeshButton.TabIndex = 3;
            this.RefeshButton.Text = "Refresh";
            this.RefeshButton.UseVisualStyleBackColor = true;
            this.RefeshButton.Click += new System.EventHandler(this.RefeshButton_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 415);
            this.Controls.Add(this.RefeshButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ToFileDocxButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCourseForm";
            this.Text = "Print Course";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
       //private Database1DataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ToFileDocxButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button RefeshButton;
    }
}