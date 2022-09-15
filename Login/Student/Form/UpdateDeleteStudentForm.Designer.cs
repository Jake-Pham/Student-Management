
namespace Login
{
    partial class UpdateDeleteStudentForm
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
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.PictureBoxStudentImage1 = new System.Windows.Forms.PictureBox();
            this.IDLable = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.BirthDateLable = new System.Windows.Forms.Label();
            this.GenderLable = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.AddressLable = new System.Windows.Forms.Label();
            this.PictureLable = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.UploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(180, 12);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(136, 26);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtxt_KeyPress);
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(180, 44);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(270, 26);
            this.FirstNametxt.TabIndex = 1;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(681, 12);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(207, 26);
            this.Addresstxt.TabIndex = 2;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(180, 170);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(270, 26);
            this.Phonetxt.TabIndex = 3;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(180, 76);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(270, 26);
            this.LastNametxt.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(180, 140);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(68, 24);
            this.Male.TabIndex = 6;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(355, 140);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(87, 24);
            this.Female.TabIndex = 7;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // PictureBoxStudentImage1
            // 
            this.PictureBoxStudentImage1.Location = new System.Drawing.Point(681, 44);
            this.PictureBoxStudentImage1.Name = "PictureBoxStudentImage1";
            this.PictureBoxStudentImage1.Size = new System.Drawing.Size(207, 152);
            this.PictureBoxStudentImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxStudentImage1.TabIndex = 8;
            this.PictureBoxStudentImage1.TabStop = false;
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(136, 12);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(26, 20);
            this.IDLable.TabIndex = 9;
            this.IDLable.Text = "ID";
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.Location = new System.Drawing.Point(76, 50);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLable.TabIndex = 10;
            this.FirstNameLable.Text = "First Name";
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(76, 82);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(86, 20);
            this.LastNameLable.TabIndex = 11;
            this.LastNameLable.Text = "Last Name";
            // 
            // BirthDateLable
            // 
            this.BirthDateLable.AutoSize = true;
            this.BirthDateLable.Location = new System.Drawing.Point(76, 114);
            this.BirthDateLable.Name = "BirthDateLable";
            this.BirthDateLable.Size = new System.Drawing.Size(77, 20);
            this.BirthDateLable.TabIndex = 12;
            this.BirthDateLable.Text = "BirthDate";
            // 
            // GenderLable
            // 
            this.GenderLable.AutoSize = true;
            this.GenderLable.Location = new System.Drawing.Point(90, 144);
            this.GenderLable.Name = "GenderLable";
            this.GenderLable.Size = new System.Drawing.Size(63, 20);
            this.GenderLable.TabIndex = 13;
            this.GenderLable.Text = "Gender";
            // 
            // PhoneLable
            // 
            this.PhoneLable.AutoSize = true;
            this.PhoneLable.Location = new System.Drawing.Point(98, 176);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(55, 20);
            this.PhoneLable.TabIndex = 14;
            this.PhoneLable.Text = "Phone";
            // 
            // AddressLable
            // 
            this.AddressLable.AutoSize = true;
            this.AddressLable.Location = new System.Drawing.Point(609, 18);
            this.AddressLable.Name = "AddressLable";
            this.AddressLable.Size = new System.Drawing.Size(68, 20);
            this.AddressLable.TabIndex = 15;
            this.AddressLable.Text = "Address";
            // 
            // PictureLable
            // 
            this.PictureLable.AutoSize = true;
            this.PictureLable.Location = new System.Drawing.Point(609, 44);
            this.PictureLable.Name = "PictureLable";
            this.PictureLable.Size = new System.Drawing.Size(58, 20);
            this.PictureLable.TabIndex = 16;
            this.PictureLable.Text = "Picture";
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Find.Location = new System.Drawing.Point(331, 8);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(119, 30);
            this.Find.TabIndex = 17;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Blue;
            this.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit.Location = new System.Drawing.Point(298, 313);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(152, 44);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Edit\r\n";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Red;
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove.Location = new System.Drawing.Point(553, 313);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(152, 44);
            this.Remove.TabIndex = 19;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // UploadImage
            // 
            this.UploadImage.Location = new System.Drawing.Point(681, 208);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(207, 31);
            this.UploadImage.TabIndex = 20;
            this.UploadImage.Text = "Uload Image";
            this.UploadImage.UseVisualStyleBackColor = true;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.PictureLable);
            this.Controls.Add(this.AddressLable);
            this.Controls.Add(this.PhoneLable);
            this.Controls.Add(this.GenderLable);
            this.Controls.Add(this.BirthDateLable);
            this.Controls.Add(this.LastNameLable);
            this.Controls.Add(this.FirstNameLable);
            this.Controls.Add(this.IDLable);
            this.Controls.Add(this.PictureBoxStudentImage1);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LastNametxt);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.FirstNametxt);
            this.Controls.Add(this.IDtxt);
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateDeleteStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox IDtxt;
        public System.Windows.Forms.TextBox FirstNametxt;
        public System.Windows.Forms.TextBox Addresstxt;
        public System.Windows.Forms.TextBox Phonetxt;
        public System.Windows.Forms.TextBox LastNametxt;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RadioButton Male;
        public System.Windows.Forms.RadioButton Female;
        public System.Windows.Forms.PictureBox PictureBoxStudentImage1;
        public System.Windows.Forms.Label IDLable;
        public System.Windows.Forms.Label FirstNameLable;
        public System.Windows.Forms.Label LastNameLable;
        public System.Windows.Forms.Label BirthDateLable;
        public System.Windows.Forms.Label GenderLable;
        public System.Windows.Forms.Label PhoneLable;
        public System.Windows.Forms.Label AddressLable;
        public System.Windows.Forms.Label PictureLable;
        public System.Windows.Forms.Button Find;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button Remove;
        public System.Windows.Forms.Button UploadImage;
    }
}