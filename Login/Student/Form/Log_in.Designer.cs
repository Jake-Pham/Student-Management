
namespace Login
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.accountloginLabel = new System.Windows.Forms.Label();
            this.TextBoxUserNameLabel = new System.Windows.Forms.Label();
            this.TextBoxPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.StudentRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanResourceRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(199, 108);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(212, 26);
            this.TextBoxUserName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.TextBoxUserName, "Tên Đăng Nhập");
            this.TextBoxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUserName_Validating);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(199, 180);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(212, 26);
            this.TextBoxPassword.TabIndex = 1;
            this.toolTip2.SetToolTip(this.TextBoxPassword, "Mật Khẩu");
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(71, 258);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(184, 59);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Login.Location = new System.Drawing.Point(329, 258);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 59);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // accountloginLabel
            // 
            this.accountloginLabel.AutoSize = true;
            this.accountloginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountloginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountloginLabel.Location = new System.Drawing.Point(192, 23);
            this.accountloginLabel.Name = "accountloginLabel";
            this.accountloginLabel.Size = new System.Drawing.Size(222, 37);
            this.accountloginLabel.TabIndex = 4;
            this.accountloginLabel.Text = "Account Login";
            // 
            // TextBoxUserNameLabel
            // 
            this.TextBoxUserNameLabel.AutoSize = true;
            this.TextBoxUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxUserNameLabel.Location = new System.Drawing.Point(85, 107);
            this.TextBoxUserNameLabel.Name = "TextBoxUserNameLabel";
            this.TextBoxUserNameLabel.Size = new System.Drawing.Size(108, 25);
            this.TextBoxUserNameLabel.TabIndex = 5;
            this.TextBoxUserNameLabel.Text = "Username:";
            // 
            // TextBoxPasswordLabel
            // 
            this.TextBoxPasswordLabel.AutoSize = true;
            this.TextBoxPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxPasswordLabel.Location = new System.Drawing.Point(85, 180);
            this.TextBoxPasswordLabel.Name = "TextBoxPasswordLabel";
            this.TextBoxPasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.TextBoxPasswordLabel.TabIndex = 6;
            this.TextBoxPasswordLabel.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateLabel.Location = new System.Drawing.Point(12, 400);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(120, 20);
            this.CreateLabel.TabIndex = 9;
            this.CreateLabel.Text = "Create Account";
            this.CreateLabel.DoubleClick += new System.EventHandler(this.CreateLabel_DoubleClick);
            // 
            // StudentRadioButton
            // 
            this.StudentRadioButton.AutoSize = true;
            this.StudentRadioButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentRadioButton.Location = new System.Drawing.Point(199, 228);
            this.StudentRadioButton.Name = "StudentRadioButton";
            this.StudentRadioButton.Size = new System.Drawing.Size(91, 24);
            this.StudentRadioButton.TabIndex = 10;
            this.StudentRadioButton.TabStop = true;
            this.StudentRadioButton.Text = "Student";
            this.StudentRadioButton.UseVisualStyleBackColor = false;
            // 
            // HumanResourceRadioButton
            // 
            this.HumanResourceRadioButton.AutoSize = true;
            this.HumanResourceRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HumanResourceRadioButton.Location = new System.Drawing.Point(351, 228);
            this.HumanResourceRadioButton.Name = "HumanResourceRadioButton";
            this.HumanResourceRadioButton.Size = new System.Drawing.Size(159, 24);
            this.HumanResourceRadioButton.TabIndex = 11;
            this.HumanResourceRadioButton.TabStop = true;
            this.HumanResourceRadioButton.Text = "Human Resource";
            this.HumanResourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.HumanResourceRadioButton);
            this.Controls.Add(this.StudentRadioButton);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxPasswordLabel);
            this.Controls.Add(this.TextBoxUserNameLabel);
            this.Controls.Add(this.accountloginLabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Name = "Log_in";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.MaskedTextBox TextBoxPassword;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label accountloginLabel;
        private System.Windows.Forms.Label TextBoxUserNameLabel;
        private System.Windows.Forms.Label TextBoxPasswordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.RadioButton StudentRadioButton;
        private System.Windows.Forms.RadioButton HumanResourceRadioButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

