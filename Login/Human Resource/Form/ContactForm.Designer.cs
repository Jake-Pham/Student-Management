
namespace Login
{
    partial class ContactForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RefreshLabel = new System.Windows.Forms.Label();
            this.EditLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.EnterContactTextBox = new System.Windows.Forms.TextBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.ShowListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IDGroupTextBox = new System.Windows.Forms.TextBox();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterGroup = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemoveGroupButton = new System.Windows.Forms.Button();
            this.SelectComboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EditGroupButton = new System.Windows.Forms.Button();
            this.SelectComboBox1 = new System.Windows.Forms.ComboBox();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.SelectGroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(153, 9);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 20);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "label1";
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.AutoSize = true;
            this.RefreshLabel.Location = new System.Drawing.Point(255, 68);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(66, 20);
            this.RefreshLabel.TabIndex = 2;
            this.RefreshLabel.Text = "Refresh";
            this.RefreshLabel.Click += new System.EventHandler(this.RefreshLabel_Click);
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Location = new System.Drawing.Point(153, 68);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(93, 20);
            this.EditLabel.TabIndex = 3;
            this.EditLabel.Text = "Edit My Info";
            this.EditLabel.Click += new System.EventHandler(this.EditLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RefreshLabel);
            this.panel1.Controls.Add(this.EditLabel);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 100);
            this.panel1.TabIndex = 4;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(12, 123);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(150, 32);
            this.ContactLabel.TabIndex = 5;
            this.ContactLabel.Text = "CONTACT";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.Location = new System.Drawing.Point(40, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 36);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditButton.Location = new System.Drawing.Point(40, 235);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 36);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.SelectButton);
            this.panel2.Controls.Add(this.EnterContactTextBox);
            this.panel2.Controls.Add(this.EnterLabel);
            this.panel2.Location = new System.Drawing.Point(3, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 100);
            this.panel2.TabIndex = 8;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(3, 58);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(463, 39);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(288, 12);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(178, 40);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Select Contact";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // EnterContactTextBox
            // 
            this.EnterContactTextBox.Location = new System.Drawing.Point(150, 18);
            this.EnterContactTextBox.Name = "EnterContactTextBox";
            this.EnterContactTextBox.Size = new System.Drawing.Size(125, 26);
            this.EnterContactTextBox.TabIndex = 3;
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Location = new System.Drawing.Point(11, 18);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(133, 20);
            this.EnterLabel.TabIndex = 2;
            this.EnterLabel.Text = "Enter Contact ID:";
            // 
            // ShowListButton
            // 
            this.ShowListButton.BackColor = System.Drawing.Color.Cyan;
            this.ShowListButton.Location = new System.Drawing.Point(76, 466);
            this.ShowListButton.Name = "ShowListButton";
            this.ShowListButton.Size = new System.Drawing.Size(309, 53);
            this.ShowListButton.TabIndex = 9;
            this.ShowListButton.Text = "Show Full List";
            this.ShowListButton.UseVisualStyleBackColor = false;
            this.ShowListButton.Click += new System.EventHandler(this.ShowListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "GROUP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.IDGroupTextBox);
            this.panel3.Controls.Add(this.AddGroupButton);
            this.panel3.Controls.Add(this.GroupNameTextBox);
            this.panel3.Controls.Add(this.EnterGroup);
            this.panel3.Location = new System.Drawing.Point(730, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 100);
            this.panel3.TabIndex = 11;
            // 
            // IDGroupTextBox
            // 
            this.IDGroupTextBox.Location = new System.Drawing.Point(302, 10);
            this.IDGroupTextBox.Name = "IDGroupTextBox";
            this.IDGroupTextBox.Size = new System.Drawing.Size(140, 26);
            this.IDGroupTextBox.TabIndex = 15;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddGroupButton.Location = new System.Drawing.Point(117, 60);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(179, 36);
            this.AddGroupButton.TabIndex = 13;
            this.AddGroupButton.Text = "Add";
            this.AddGroupButton.UseVisualStyleBackColor = false;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(156, 10);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(140, 26);
            this.GroupNameTextBox.TabIndex = 14;
            // 
            // EnterGroup
            // 
            this.EnterGroup.AutoSize = true;
            this.EnterGroup.Location = new System.Drawing.Point(3, 16);
            this.EnterGroup.Name = "EnterGroup";
            this.EnterGroup.Size = new System.Drawing.Size(147, 20);
            this.EnterGroup.TabIndex = 13;
            this.EnterGroup.Text = "Enter Group Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RemoveGroupButton);
            this.panel4.Controls.Add(this.SelectComboBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(730, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 106);
            this.panel4.TabIndex = 12;
            // 
            // RemoveGroupButton
            // 
            this.RemoveGroupButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveGroupButton.Location = new System.Drawing.Point(117, 64);
            this.RemoveGroupButton.Name = "RemoveGroupButton";
            this.RemoveGroupButton.Size = new System.Drawing.Size(179, 39);
            this.RemoveGroupButton.TabIndex = 18;
            this.RemoveGroupButton.Text = "Remove";
            this.RemoveGroupButton.UseVisualStyleBackColor = false;
            this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
            // 
            // SelectComboBox2
            // 
            this.SelectComboBox2.FormattingEnabled = true;
            this.SelectComboBox2.Location = new System.Drawing.Point(156, 13);
            this.SelectComboBox2.Name = "SelectComboBox2";
            this.SelectComboBox2.Size = new System.Drawing.Size(228, 28);
            this.SelectComboBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Group:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.EditGroupButton);
            this.panel5.Controls.Add(this.SelectComboBox1);
            this.panel5.Controls.Add(this.NewNameTextBox);
            this.panel5.Controls.Add(this.NewNameLabel);
            this.panel5.Controls.Add(this.SelectGroupLabel);
            this.panel5.Location = new System.Drawing.Point(730, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 119);
            this.panel5.TabIndex = 12;
            // 
            // EditGroupButton
            // 
            this.EditGroupButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditGroupButton.Location = new System.Drawing.Point(117, 80);
            this.EditGroupButton.Name = "EditGroupButton";
            this.EditGroupButton.Size = new System.Drawing.Size(179, 36);
            this.EditGroupButton.TabIndex = 17;
            this.EditGroupButton.Text = "Edit";
            this.EditGroupButton.UseVisualStyleBackColor = false;
            this.EditGroupButton.Click += new System.EventHandler(this.EditGroupButton_Click);
            // 
            // SelectComboBox1
            // 
            this.SelectComboBox1.FormattingEnabled = true;
            this.SelectComboBox1.Location = new System.Drawing.Point(156, 13);
            this.SelectComboBox1.Name = "SelectComboBox1";
            this.SelectComboBox1.Size = new System.Drawing.Size(228, 28);
            this.SelectComboBox1.TabIndex = 16;
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(156, 45);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(228, 26);
            this.NewNameTextBox.TabIndex = 15;
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(3, 45);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(133, 20);
            this.NewNameLabel.TabIndex = 13;
            this.NewNameLabel.Text = "Enter New Name:";
            // 
            // SelectGroupLabel
            // 
            this.SelectGroupLabel.AutoSize = true;
            this.SelectGroupLabel.Location = new System.Drawing.Point(29, 16);
            this.SelectGroupLabel.Name = "SelectGroupLabel";
            this.SelectGroupLabel.Size = new System.Drawing.Size(107, 20);
            this.SelectGroupLabel.TabIndex = 14;
            this.SelectGroupLabel.Text = "Select Group:";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1293, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowListButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ContactForm";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RefreshLabel;
        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TextBox EnterContactTextBox;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Button ShowListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.Label EnterGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.Label SelectGroupLabel;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.Button RemoveGroupButton;
        private System.Windows.Forms.ComboBox SelectComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditGroupButton;
        private System.Windows.Forms.ComboBox SelectComboBox1;
        private System.Windows.Forms.TextBox IDGroupTextBox;
    }
}