using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void label_Total_Click(object sender, EventArgs e)
        {

        }
        //Color panTotalColor;
        //Color panMaleColor;
        //Color panFemaleColor;
        private void StatisticForm_Load(object sender, EventArgs e)
        {
            //panTotalColor = pnTotal.BackColor;
            //panMaleColor = panel_Male.BackColor;
            //panFemaleColor = panel_Female.BackColor;
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.TotalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            double malePer = Math.Round((totalMale * (100 / total)),2);
            double FemalePer = Math.Round((totalFemale * (100 / total)));
            //label_Total.Text = ("Total Student: " + total.ToString());
            //label_Male.Text = ("Male: " + malePer.ToString()+"%");
            //label_Female.Text = ("Female: " + FemalePer.ToString()+"%");
            ColumnChart.Series["ColumnChart"].Points.Add(malePer);
            ColumnChart.Series["ColumnChart"].Points[0].Color=Color.Red;
            ColumnChart.Series["ColumnChart"].Points[0].AxisLabel="Male";
            ColumnChart.Series["ColumnChart"].Points[0].LegendText = "Male";
            ColumnChart.Series["ColumnChart"].Points[0].Label = Convert.ToString(malePer);
            
            ColumnChart.Series["ColumnChart"].Points.Add(FemalePer);
            ColumnChart.Series["ColumnChart"].Points[1].Color = Color.Green;
            ColumnChart.Series["ColumnChart"].Points[1].AxisLabel = "Female";
            ColumnChart.Series["ColumnChart"].Points[1].LegendText = "Female";
            ColumnChart.Series["ColumnChart"].Points[1].Label = Convert.ToString(FemalePer);

            PieChart.Series["PieChart"].Points.Add(malePer);
            PieChart.Series["PieChart"].Points[0].AxisLabel = "Male";
            PieChart.Series["PieChart"].Points[0].LegendText = "Male";
            PieChart.Series["PieChart"].Points[0].Label = Convert.ToString(malePer);

            PieChart.Series["PieChart"].Points.Add(FemalePer);
            PieChart.Series["PieChart"].Points[1].AxisLabel = "Female";
            PieChart.Series["PieChart"].Points[1].LegendText = "Female";
            PieChart.Series["PieChart"].Points[1].Label = Convert.ToString(FemalePer);
        }

        private void ColumnChart_Click(object sender, EventArgs e)
        {

        }


        //private void label_Total_MouseEnter(object sender, EventArgs e)
        //{
        //    label_Total.ForeColor = panTotalColor;
        //    pnTotal.BackColor = Color.White;
        //}

        //private void label_Total_MouseLeave(object sender, EventArgs e)
        //{
        //    label_Total.ForeColor = Color.White;
        //    pnTotal.BackColor = panTotalColor;
        //}

        //private void label_Male_MouseEnter(object sender, EventArgs e)
        //{
        //    label_Male.ForeColor = panMaleColor;
        //    panel_Male.BackColor = Color.White;
        //}

        //private void label_Male_MouseLeave(object sender, EventArgs e)
        //{
        //    label_Male.ForeColor = Color.White;
        //    panel_Male.BackColor = panMaleColor;
        //}

        //private void label_Female_MouseEnter(object sender, EventArgs e)
        //{
        //    label_Female.ForeColor = panFemaleColor;
        //    panel_Female.BackColor = Color.White;
        //}

        //private void label_Female_MouseLeave(object sender, EventArgs e)
        //{
        //    label_Female.ForeColor = Color.White;
        //    panel_Female.BackColor = panFemaleColor;
        //}
    }
}
