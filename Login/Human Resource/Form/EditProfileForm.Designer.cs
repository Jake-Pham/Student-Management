
namespace Login
{
    partial class EditProfileForm
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
            this.UploadPicButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadPicButton
            // 
            this.UploadPicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UploadPicButton.Location = new System.Drawing.Point(154, 326);
            this.UploadPicButton.Name = "UploadPicButton";
            this.UploadPicButton.Size = new System.Drawing.Size(151, 36);
            this.UploadPicButton.TabIndex = 27;
            this.UploadPicButton.Text = "Upload Pic";
            this.UploadPicButton.UseVisualStyleBackColor = false;
            this.UploadPicButton.Click += new System.EventHandler(this.UploadPicButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 92);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(154, 186);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(151, 26);
            this.PasswordTextBox.TabIndex = 25;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(154, 96);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(151, 26);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(154, 140);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(151, 26);
            this.UserNameTextBox.TabIndex = 23;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(154, 51);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(151, 26);
            this.FirstNameTextBox.TabIndex = 22;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(22, 186);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(42, 228);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(62, 20);
            this.PictureLabel.TabIndex = 19;
            this.PictureLabel.Text = "Picture:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(14, 140);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(93, 20);
            this.UserNameLabel.TabIndex = 18;
            this.UserNameLabel.Text = "User Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 96);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LastNameLabel.TabIndex = 17;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 51);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.BackColor = System.Drawing.Color.Lime;
            this.EditProfileButton.Location = new System.Drawing.Point(46, 385);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(151, 36);
            this.EditProfileButton.TabIndex = 28;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(255, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(151, 36);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(74, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 20);
            this.IDLabel.TabIndex = 15;
            this.IDLabel.Text = "ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(154, 9);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 26);
            this.IDTextBox.TabIndex = 21;
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditProfileButton);
            this.Controls.Add(this.UploadPicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "EditProfileForm";
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.EditProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button UploadPicButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox UserNameTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.Label PictureLabel;
        public System.Windows.Forms.Label UserNameLabel;
        public System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.Label FirstNameLabel;
        public System.Windows.Forms.Button EditProfileButton;
        public System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.TextBox IDTextBox;
    }
}