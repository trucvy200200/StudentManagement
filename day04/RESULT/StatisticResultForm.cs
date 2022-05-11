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
    public partial class StatisticResultForm : Form
    {
        public StatisticResultForm()
        {
            InitializeComponent();
        }
        SCORE sc = new SCORE();
        RESULT re = new RESULT();
        COURSE co = new COURSE();
        private void StatisticResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = sc.getAvgByCourse();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                double per = Convert.ToDouble(table.Rows[i].ItemArray[1].ToString());
                ColumnChart.Series["AvgScoreByCourse"].Points.Add(per);
                ColumnChart.Series["AvgScoreByCourse"].Points[i].AxisLabel = table.Rows[i].ItemArray[0].ToString();
                ColumnChart.Series["AvgScoreByCourse"].Points[i].LegendText = table.Rows[i].ItemArray[0].ToString();
                ColumnChart.Series["AvgScoreByCourse"].Points[i].Label = Convert.ToString(per);
            }

            double total = Convert.ToDouble(re.TotalStudent());
            double totalA = Convert.ToDouble(re.totalA());
            double totalB = Convert.ToDouble(re.totalB());
            double totalC = Convert.ToDouble(re.totalC());
            double totalD = Convert.ToDouble(re.totalD());
            double Aper = Math.Round((totalA / total) * 100, 2);
            double Bper = Math.Round((totalB / total) * 100, 2);
            double Cper = Math.Round((totalC / total) * 100, 2);
            double Dper = Math.Round((totalD / total) * 100, 2);
            







            PieChart.Series["PieChart"].Points.Add(Aper);
            PieChart.Series["PieChart"].Points[0].AxisLabel = "A";
            PieChart.Series["PieChart"].Points[0].LegendText = "A";
            PieChart.Series["PieChart"].Points[0].Label = Convert.ToString(Aper);


            PieChart.Series["PieChart"].Points.Add(Bper);
            PieChart.Series["PieChart"].Points[1].AxisLabel = "B";
            PieChart.Series["PieChart"].Points[1].LegendText = "B";
            PieChart.Series["PieChart"].Points[1].Label = Convert.ToString(Bper);



            PieChart.Series["PieChart"].Points.Add(Cper);
            PieChart.Series["PieChart"].Points[2].AxisLabel = "C";
            PieChart.Series["PieChart"].Points[2].LegendText = "C";
            PieChart.Series["PieChart"].Points[2].Label = Convert.ToString(Cper);


            PieChart.Series["PieChart"].Points.Add(Dper);
            PieChart.Series["PieChart"].Points[3].AxisLabel = "D";
            PieChart.Series["PieChart"].Points[3].LegendText = "D";
            PieChart.Series["PieChart"].Points[3].Label = Convert.ToString(Dper);

        }
    }
}
