
namespace Login
{
    partial class ManageCourseForm
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
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.HoursNumberLabel = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.TotalCourseLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(167, 185);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(203, 95);
            this.DescriptionTextBox.TabIndex = 18;
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Location = new System.Drawing.Point(167, 88);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(203, 26);
            this.LabelTextBox.TabIndex = 16;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(167, 40);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(203, 26);
            this.IDTextBox.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Lime;
            this.AddButton.Location = new System.Drawing.Point(12, 418);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 48);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(67, 185);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description:";
            // 
            // HoursNumberLabel
            // 
            this.HoursNumberLabel.AutoSize = true;
            this.HoursNumberLabel.Location = new System.Drawing.Point(36, 132);
            this.HoursNumberLabel.Name = "HoursNumberLabel";
            this.HoursNumberLabel.Size = new System.Drawing.Size(116, 20);
            this.HoursNumberLabel.TabIndex = 12;
            this.HoursNumberLabel.Text = "Hours Number:";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(100, 88);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(52, 20);
            this.LabelLabel.TabIndex = 11;
            this.LabelLabel.Text = "Label:";
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Location = new System.Drawing.Point(67, 46);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(85, 20);
            this.CourseIDLabel.TabIndex = 10;
            this.CourseIDLabel.Text = "Course ID:";
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 20;
            this.CourseListBox.Location = new System.Drawing.Point(572, 40);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(310, 324);
            this.CourseListBox.TabIndex = 19;
            this.CourseListBox.Click += new System.EventHandler(this.CourseListBox_Click);
            // 
            // TotalCourseLabel
            // 
            this.TotalCourseLabel.AutoSize = true;
            this.TotalCourseLabel.Location = new System.Drawing.Point(720, 384);
            this.TotalCourseLabel.Name = "TotalCourseLabel";
            this.TotalCourseLabel.Size = new System.Drawing.Size(111, 20);
            this.TotalCourseLabel.TabIndex = 20;
            this.TotalCourseLabel.Text = "Total Courses:";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Lime;
            this.EditButton.Location = new System.Drawing.Point(187, 418);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(143, 48);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Location = new System.Drawing.Point(372, 418);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(143, 48);
            this.RemoveButton.TabIndex = 22;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstButton.Location = new System.Drawing.Point(40, 356);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(86, 33);
            this.FirstButton.TabIndex = 24;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastButton.Location = new System.Drawing.Point(417, 356);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(81, 33);
            this.LastButton.TabIndex = 25;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.Location = new System.Drawing.Point(298, 356);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(84, 33);
            this.PreviousButton.TabIndex = 26;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(167, 356);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 33);
            this.NextButton.TabIndex = 27;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // HoursNumericUpDown
            // 
            this.HoursNumericUpDown.Location = new System.Drawing.Point(167, 132);
            this.HoursNumericUpDown.Name = "HoursNumericUpDown";
            this.HoursNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.HoursNumericUpDown.TabIndex = 28;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 542);
            this.Controls.Add(this.HoursNumericUpDown);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TotalCourseLabel);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LabelTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HoursNumberLabel);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.CourseIDLabel);
            this.Name = "ManageCourseForm";
            this.Text = "Manage Course";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label HoursNumberLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Label TotalCourseLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.NumericUpDown HoursNumericUpDown;
    }
}