
namespace Login
{
    partial class ManageScoreForm
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
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.SelectCourseLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.ShowStudentsButton = new System.Windows.Forms.Button();
            this.ShowScoresButton = new System.Windows.Forms.Button();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(152, 28);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.StudentIDTextBox.TabIndex = 0;
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(152, 127);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(100, 26);
            this.ScoreTextBox.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(152, 186);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(46, 28);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(91, 20);
            this.StudentIDLabel.TabIndex = 4;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // SelectCourseLabel
            // 
            this.SelectCourseLabel.AutoSize = true;
            this.SelectCourseLabel.Location = new System.Drawing.Point(24, 78);
            this.SelectCourseLabel.Name = "SelectCourseLabel";
            this.SelectCourseLabel.Size = new System.Drawing.Size(113, 20);
            this.SelectCourseLabel.TabIndex = 5;
            this.SelectCourseLabel.Text = "Select Course:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(86, 127);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(55, 20);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(44, 186);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 371);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Lime;
            this.AddButton.Location = new System.Drawing.Point(28, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 39);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Location = new System.Drawing.Point(171, 285);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(91, 39);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(28, 357);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(234, 39);
            this.AverageButton.TabIndex = 11;
            this.AverageButton.Text = "Average Score By Course";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // ShowStudentsButton
            // 
            this.ShowStudentsButton.Location = new System.Drawing.Point(383, 15);
            this.ShowStudentsButton.Name = "ShowStudentsButton";
            this.ShowStudentsButton.Size = new System.Drawing.Size(299, 39);
            this.ShowStudentsButton.TabIndex = 12;
            this.ShowStudentsButton.Text = "Show Students";
            this.ShowStudentsButton.UseVisualStyleBackColor = true;
            this.ShowStudentsButton.Click += new System.EventHandler(this.ShowStudentsButton_Click);
            // 
            // ShowScoresButton
            // 
            this.ShowScoresButton.Location = new System.Drawing.Point(710, 12);
            this.ShowScoresButton.Name = "ShowScoresButton";
            this.ShowScoresButton.Size = new System.Drawing.Size(313, 39);
            this.ShowScoresButton.TabIndex = 13;
            this.ShowScoresButton.Text = "Show Scores";
            this.ShowScoresButton.UseVisualStyleBackColor = true;
            this.ShowScoresButton.Click += new System.EventHandler(this.ShowScoresButton_Click);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(152, 75);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(121, 28);
            this.CourseComboBox.TabIndex = 14;
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1760, 450);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.ShowScoresButton);
            this.Controls.Add(this.ShowStudentsButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SelectCourseLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label SelectCourseLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button ShowStudentsButton;
        private System.Windows.Forms.Button ShowScoresButton;
        private System.Windows.Forms.ComboBox CourseComboBox;
    }
}