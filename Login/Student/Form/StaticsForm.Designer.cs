
namespace Login
{
    partial class StaticsForm
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.MaleLabel = new System.Windows.Forms.Label();
            this.FemaleLabel = new System.Windows.Forms.Label();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelTotal.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(301, 33);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(93, 32);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "label1";
            // 
            // MaleLabel
            // 
            this.MaleLabel.AutoSize = true;
            this.MaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleLabel.Location = new System.Drawing.Point(97, 55);
            this.MaleLabel.Name = "MaleLabel";
            this.MaleLabel.Size = new System.Drawing.Size(93, 32);
            this.MaleLabel.TabIndex = 1;
            this.MaleLabel.Text = "label2";
            // 
            // FemaleLabel
            // 
            this.FemaleLabel.AutoSize = true;
            this.FemaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleLabel.Location = new System.Drawing.Point(101, 55);
            this.FemaleLabel.Name = "FemaleLabel";
            this.FemaleLabel.Size = new System.Drawing.Size(93, 32);
            this.FemaleLabel.TabIndex = 2;
            this.FemaleLabel.Text = "label3";
            // 
            // PanelTotal
            // 
            this.PanelTotal.Controls.Add(this.TotalLabel);
            this.PanelTotal.Location = new System.Drawing.Point(1, 1);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(800, 108);
            this.PanelTotal.TabIndex = 3;
            // 
            // PanelMale
            // 
            this.PanelMale.Controls.Add(this.MaleLabel);
            this.PanelMale.Location = new System.Drawing.Point(1, 115);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(394, 138);
            this.PanelMale.TabIndex = 4;
            // 
            // PanelFemale
            // 
            this.PanelFemale.Controls.Add(this.FemaleLabel);
            this.PanelFemale.Location = new System.Drawing.Point(401, 115);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(400, 138);
            this.PanelFemale.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(228, 271);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.PanelMale.ResumeLayout(false);
            this.PanelMale.PerformLayout();
            this.PanelFemale.ResumeLayout(false);
            this.PanelFemale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label MaleLabel;
        private System.Windows.Forms.Label FemaleLabel;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}