namespace day04
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(513, 65);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "PieChart";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(314, 281);
            this.PieChart.TabIndex = 4;
            this.PieChart.Text = "PieChart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "PieChart";
            this.PieChart.Titles.Add(title1);
            // 
            // ColumnChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ColumnChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ColumnChart.Legends.Add(legend2);
            this.ColumnChart.Location = new System.Drawing.Point(30, 65);
            this.ColumnChart.Name = "ColumnChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "ColumnChart";
            this.ColumnChart.Series.Add(series2);
            this.ColumnChart.Size = new System.Drawing.Size(407, 327);
            this.ColumnChart.TabIndex = 5;
            this.ColumnChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Title1";
            title2.Text = "Column Chart";
            this.ColumnChart.Titles.Add(title2);
            this.ColumnChart.Click += new System.EventHandler(this.ColumnChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of males and females";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnChart);
            this.Controls.Add(this.PieChart);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart;
        private System.Windows.Forms.Label label1;
    }
}