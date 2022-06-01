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
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            DataTable table = score.getAvgByCourse();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                double per = Convert.ToDouble(table.Rows[i].ItemArray[1].ToString());
                ColumnChart.Series["AvgScoreByCourse"].Points.Add(per);
                ColumnChart.Series["AvgScoreByCourse"].Points[i].AxisLabel = table.Rows[i].ItemArray[0].ToString();
                ColumnChart.Series["AvgScoreByCourse"].Points[i].LegendText = table.Rows[i].ItemArray[0].ToString();
                ColumnChart.Series["AvgScoreByCourse"].Points[i].Label = Convert.ToString(per);
            }
            dataGridView1.DataSource = score.getAvgByCourse();
            dataGridView1.Columns[0].HeaderText = "Course Name";
            dataGridView1.Columns[1].HeaderText = "Average Grade";
        }
    }
}
