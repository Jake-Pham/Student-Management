
namespace Login
{
    partial class Print
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Check = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdate2 = new System.Windows.Forms.DateTimePicker();
            this.bdate1 = new System.Windows.Forms.DateTimePicker();
            this.AndLabel = new System.Windows.Forms.Label();
            this.BirthDateBetweenLabel = new System.Windows.Forms.Label();
            this.UseDateRangeLabel = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.RadioButton();
            this.YES = new System.Windows.Forms.RadioButton();
            this.SaveToTextFile = new System.Windows.Forms.Button();
            this.ToPrinter = new System.Windows.Forms.Button();
            this.SaveToDocFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Check);
            this.panel1.Controls.Add(this.All);
            this.panel1.Controls.Add(this.Female);
            this.panel1.Controls.Add(this.Male);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 121);
            this.panel1.TabIndex = 1;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(1060, 33);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(125, 46);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(12, 66);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(51, 24);
            this.All.TabIndex = 0;
            this.All.TabStop = true;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(287, 66);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(87, 24);
            this.Female.TabIndex = 2;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(144, 66);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(68, 24);
            this.Male.TabIndex = 1;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bdate2);
            this.panel2.Controls.Add(this.bdate1);
            this.panel2.Controls.Add(this.AndLabel);
            this.panel2.Controls.Add(this.BirthDateBetweenLabel);
            this.panel2.Controls.Add(this.UseDateRangeLabel);
            this.panel2.Controls.Add(this.NO);
            this.panel2.Controls.Add(this.YES);
            this.panel2.Location = new System.Drawing.Point(414, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 92);
            this.panel2.TabIndex = 0;
            // 
            // bdate2
            // 
            this.bdate2.Location = new System.Drawing.Point(398, 51);
            this.bdate2.Name = "bdate2";
            this.bdate2.Size = new System.Drawing.Size(200, 26);
            this.bdate2.TabIndex = 6;
            // 
            // bdate1
            // 
            this.bdate1.Location = new System.Drawing.Point(148, 50);
            this.bdate1.Name = "bdate1";
            this.bdate1.Size = new System.Drawing.Size(200, 26);
            this.bdate1.TabIndex = 5;
            // 
            // AndLabel
            // 
            this.AndLabel.AutoSize = true;
            this.AndLabel.Location = new System.Drawing.Point(354, 54);
            this.AndLabel.Name = "AndLabel";
            this.AndLabel.Size = new System.Drawing.Size(38, 20);
            this.AndLabel.TabIndex = 4;
            this.AndLabel.Text = "And";
            // 
            // BirthDateBetweenLabel
            // 
            this.BirthDateBetweenLabel.AutoSize = true;
            this.BirthDateBetweenLabel.Location = new System.Drawing.Point(3, 56);
            this.BirthDateBetweenLabel.Name = "BirthDateBetweenLabel";
            this.BirthDateBetweenLabel.Size = new System.Drawing.Size(148, 20);
            this.BirthDateBetweenLabel.TabIndex = 3;
            this.BirthDateBetweenLabel.Text = "BirthDate Between:";
            // 
            // UseDateRangeLabel
            // 
            this.UseDateRangeLabel.AutoSize = true;
            this.UseDateRangeLabel.Location = new System.Drawing.Point(3, 21);
            this.UseDateRangeLabel.Name = "UseDateRangeLabel";
            this.UseDateRangeLabel.Size = new System.Drawing.Size(133, 20);
            this.UseDateRangeLabel.TabIndex = 2;
            this.UseDateRangeLabel.Text = "Use Date Range:";
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(310, 17);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(57, 24);
            this.NO.TabIndex = 1;
            this.NO.TabStop = true;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // YES
            // 
            this.YES.AutoSize = true;
            this.YES.Location = new System.Drawing.Point(164, 17);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(67, 24);
            this.YES.TabIndex = 0;
            this.YES.TabStop = true;
            this.YES.Text = "YES";
            this.YES.UseVisualStyleBackColor = true;
            // 
            // SaveToTextFile
            // 
            this.SaveToTextFile.Location = new System.Drawing.Point(528, 487);
            this.SaveToTextFile.Name = "SaveToTextFile";
            this.SaveToTextFile.Size = new System.Drawing.Size(151, 62);
            this.SaveToTextFile.TabIndex = 2;
            this.SaveToTextFile.Text = "Save To Text File";
            this.SaveToTextFile.UseVisualStyleBackColor = true;
            this.SaveToTextFile.Click += new System.EventHandler(this.SaveToTextFile_Click);
            // 
            // ToPrinter
            // 
            this.ToPrinter.Location = new System.Drawing.Point(907, 487);
            this.ToPrinter.Name = "ToPrinter";
            this.ToPrinter.Size = new System.Drawing.Size(151, 62);
            this.ToPrinter.TabIndex = 3;
            this.ToPrinter.Text = "To Printer";
            this.ToPrinter.UseVisualStyleBackColor = true;
            this.ToPrinter.Click += new System.EventHandler(this.ToPrinter_Click);
            // 
            // SaveToDocFileButton
            // 
            this.SaveToDocFileButton.Location = new System.Drawing.Point(213, 487);
            this.SaveToDocFileButton.Name = "SaveToDocFileButton";
            this.SaveToDocFileButton.Size = new System.Drawing.Size(151, 62);
            this.SaveToDocFileButton.TabIndex = 4;
            this.SaveToDocFileButton.Text = "Save To Doc File";
            this.SaveToDocFileButton.UseVisualStyleBackColor = true;
            this.SaveToDocFileButton.Click += new System.EventHandler(this.SaveToDocFileButton_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1310, 622);
            this.Controls.Add(this.SaveToDocFileButton);
            this.Controls.Add(this.ToPrinter);
            this.Controls.Add(this.SaveToTextFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker bdate2;
        private System.Windows.Forms.DateTimePicker bdate1;
        private System.Windows.Forms.Label AndLabel;
        private System.Windows.Forms.Label BirthDateBetweenLabel;
        private System.Windows.Forms.Label UseDateRangeLabel;
        private System.Windows.Forms.RadioButton NO;
        private System.Windows.Forms.RadioButton YES;
        private System.Windows.Forms.Button SaveToTextFile;
        private System.Windows.Forms.Button ToPrinter;
        private System.Windows.Forms.Button SaveToDocFileButton;
    }
}