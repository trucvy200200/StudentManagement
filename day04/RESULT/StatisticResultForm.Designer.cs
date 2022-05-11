namespace day04
{
    partial class StatisticResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ColumnChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ColumnChart.Legends.Add(legend3);
            this.ColumnChart.Location = new System.Drawing.Point(42, 86);
            this.ColumnChart.Name = "ColumnChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "AvgScoreByCourse";
            this.ColumnChart.Series.Add(series3);
            this.ColumnChart.Size = new System.Drawing.Size(618, 424);
            this.ColumnChart.TabIndex = 0;
            this.ColumnChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Red;
            title3.Name = "Title1";
            title3.Text = "Statistic By Course";
            this.ColumnChart.Titles.Add(title3);
            // 
            // PieChart
            // 
            chartArea4.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PieChart.Legends.Add(legend4);
            this.PieChart.Location = new System.Drawing.Point(732, 105);
            this.PieChart.Name = "PieChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "PieChart";
            this.PieChart.Series.Add(series4);
            this.PieChart.Size = new System.Drawing.Size(472, 405);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "chart2";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Red;
            title4.Name = "title0";
            title4.Text = "Statistic By Result";
            this.PieChart.Titles.Add(title4);
            // 
            // StatisticResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 703);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.ColumnChart);
            this.Name = "StatisticResultForm";
            this.Text = "StatisticResultForm";
            this.Load += new System.EventHandler(this.StatisticResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}