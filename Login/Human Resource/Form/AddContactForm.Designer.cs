
namespace Login
{
    partial class AddContactForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.UploadPicButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(245, 496);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(151, 36);
            this.CancelButton.TabIndex = 44;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackColor = System.Drawing.Color.Lime;
            this.AddContactButton.Location = new System.Drawing.Point(24, 496);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(151, 36);
            this.AddContactButton.TabIndex = 43;
            this.AddContactButton.Text = "Add Contact";
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // UploadPicButton
            // 
            this.UploadPicButton.BackColor = System.Drawing.Color.Cyan;
            this.UploadPicButton.Location = new System.Drawing.Point(152, 412);
            this.UploadPicButton.Name = "UploadPicButton";
            this.UploadPicButton.Size = new System.Drawing.Size(151, 36);
            this.UploadPicButton.TabIndex = 42;
            this.UploadPicButton.Text = "Upload Pic";
            this.UploadPicButton.UseVisualStyleBackColor = false;
            this.UploadPicButton.Click += new System.EventHandler(this.UploadPicButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(152, 156);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(267, 26);
            this.PhoneTextBox.TabIndex = 40;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(152, 66);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.LastNameTextBox.TabIndex = 39;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(152, 21);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.FirstNameTextBox.TabIndex = 37;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(152, 202);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(267, 26);
            this.EmailTextBox.TabIndex = 36;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(39, 156);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(59, 20);
            this.PhoneLabel.TabIndex = 35;
            this.PhoneLabel.Text = "Phone:";
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(36, 300);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(62, 20);
            this.PictureLabel.TabIndex = 34;
            this.PictureLabel.Text = "Picture:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(40, 110);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(58, 20);
            this.GroupLabel.TabIndex = 33;
            this.GroupLabel.Text = "Group:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 66);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LastNameLabel.TabIndex = 32;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 21);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FirstNameLabel.TabIndex = 31;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(46, 208);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(52, 20);
            this.EmailLabel.TabIndex = 30;
            this.EmailLabel.Text = "Email:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(26, 256);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(72, 20);
            this.AddressLabel.TabIndex = 45;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(152, 250);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(267, 26);
            this.AddressTextBox.TabIndex = 46;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(508, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 20);
            this.IDLabel.TabIndex = 47;
            this.IDLabel.Text = "ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(544, 18);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(161, 26);
            this.IDTextBox.TabIndex = 48;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(152, 107);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(267, 28);
            this.GroupComboBox.TabIndex = 49;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.UploadPicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Name = "AddContactForm";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button AddContactButton;
        public System.Windows.Forms.Button UploadPicButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.Label PhoneLabel;
        public System.Windows.Forms.Label PictureLabel;
        public System.Windows.Forms.Label GroupLabel;
        public System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.Label FirstNameLabel;
        public System.Windows.Forms.Label EmailLabel;
        public System.Windows.Forms.Label AddressLabel;
        public System.Windows.Forms.TextBox AddressTextBox;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
    }
}