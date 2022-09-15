
namespace Login
{
    partial class StaticResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StaticByCourseLabel = new System.Windows.Forms.Label();
            this.StacticByResultLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaticByCourseLabel
            // 
            this.StaticByCourseLabel.AutoSize = true;
            this.StaticByCourseLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticByCourseLabel.Location = new System.Drawing.Point(67, 48);
            this.StaticByCourseLabel.Name = "StaticByCourseLabel";
            this.StaticByCourseLabel.Size = new System.Drawing.Size(216, 27);
            this.StaticByCourseLabel.TabIndex = 0;
            this.StaticByCourseLabel.Text = "Static By Course";
            // 
            // StacticByResultLabel
            // 
            this.StacticByResultLabel.AutoSize = true;
            this.StacticByResultLabel.Font = new System.Drawing.Font("Lucida Bright", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StacticByResultLabel.Location = new System.Drawing.Point(466, 48);
            this.StacticByResultLabel.Name = "StacticByResultLabel";
            this.StacticByResultLabel.Size = new System.Drawing.Size(229, 31);
            this.StacticByResultLabel.TabIndex = 1;
            this.StacticByResultLabel.Text = "Static By Result";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(466, 108);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(48, 20);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Pass:";
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Location = new System.Drawing.Point(466, 153);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(38, 20);
            this.FailLabel.TabIndex = 3;
            this.FailLabel.Text = "Fail:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 339);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(470, 208);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Result";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // StaticResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.StacticByResultLabel);
            this.Controls.Add(this.StaticByCourseLabel);
            this.Name = "StaticResultForm";
            this.Text = "Static Result";
            this.Load += new System.EventHandler(this.StaticResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticByCourseLabel;
        private System.Windows.Forms.Label StacticByResultLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}