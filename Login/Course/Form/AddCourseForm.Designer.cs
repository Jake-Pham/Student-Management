
namespace Login
{
    partial class AddCourseForm
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
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Location = new System.Drawing.Point(103, 80);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(85, 20);
            this.CourseIDLabel.TabIndex = 0;
            this.CourseIDLabel.Text = "Course ID:";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(103, 128);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(52, 20);
            this.LabelLabel.TabIndex = 1;
            this.LabelLabel.Text = "Label:";
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(103, 172);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(58, 20);
            this.PeriodLabel.TabIndex = 2;
            this.PeriodLabel.Text = "Period:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(103, 225);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddButton.Location = new System.Drawing.Point(216, 341);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 48);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(203, 74);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(203, 26);
            this.IDTextBox.TabIndex = 6;
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Location = new System.Drawing.Point(203, 122);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(203, 26);
            this.LabelTextBox.TabIndex = 7;
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(203, 166);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(203, 26);
            this.PeriodTextBox.TabIndex = 8;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(203, 219);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(203, 95);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.LabelTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.PeriodLabel);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.CourseIDLabel);
            this.Name = "AddCourseForm";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
    }
}