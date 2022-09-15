
namespace Login
{
    partial class EditCourseForm
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
            this.SelectCourseLabel = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCourseLabel
            // 
            this.SelectCourseLabel.AutoSize = true;
            this.SelectCourseLabel.Location = new System.Drawing.Point(147, 79);
            this.SelectCourseLabel.Name = "SelectCourseLabel";
            this.SelectCourseLabel.Size = new System.Drawing.Size(113, 20);
            this.SelectCourseLabel.TabIndex = 0;
            this.SelectCourseLabel.Text = "Select Course:";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(147, 137);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(52, 20);
            this.LabelLabel.TabIndex = 1;
            this.LabelLabel.Text = "Label:";
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(147, 194);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(58, 20);
            this.PeriodLabel.TabIndex = 2;
            this.PeriodLabel.Text = "Period:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(147, 250);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(287, 71);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(206, 28);
            this.CourseComboBox.TabIndex = 4;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Location = new System.Drawing.Point(287, 131);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(206, 26);
            this.LabelTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(287, 244);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(206, 92);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // PeriodNumericUpDown
            // 
            this.PeriodNumericUpDown.Location = new System.Drawing.Point(287, 188);
            this.PeriodNumericUpDown.Name = "PeriodNumericUpDown";
            this.PeriodNumericUpDown.Size = new System.Drawing.Size(92, 26);
            this.PeriodNumericUpDown.TabIndex = 7;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.LawnGreen;
            this.EditButton.Location = new System.Drawing.Point(211, 423);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(282, 51);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PeriodNumericUpDown);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LabelTextBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PeriodLabel);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.SelectCourseLabel);
            this.Name = "EditCourseForm";
            this.Text = "Edit Course";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectCourseLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.NumericUpDown PeriodNumericUpDown;
        private System.Windows.Forms.Button EditButton;
    }
}