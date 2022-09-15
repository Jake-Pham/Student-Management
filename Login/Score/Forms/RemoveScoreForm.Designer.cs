
namespace Login
{
    partial class RemoveScoreForm
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
            this.RemoveScoreButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // RemoveScoreButton
            // 
            this.RemoveScoreButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveScoreButton.Location = new System.Drawing.Point(43, 388);
            this.RemoveScoreButton.Name = "RemoveScoreButton";
            this.RemoveScoreButton.Size = new System.Drawing.Size(122, 35);
            this.RemoveScoreButton.TabIndex = 1;
            this.RemoveScoreButton.Text = "Remove Score";
            this.RemoveScoreButton.UseVisualStyleBackColor = false;
            this.RemoveScoreButton.Click += new System.EventHandler(this.RemoveScoreButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Lime;
            this.RefreshButton.Location = new System.Drawing.Point(347, 388);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(122, 35);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RemoveScoreButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreFrom";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveScoreButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}