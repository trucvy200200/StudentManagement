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
            
            dataGridView1.DataSource = score.getAvgByCourse();
            dataGridView1.Columns[0].HeaderText = "Course Name";
            dataGridView1.Columns[1].HeaderText = "Average Grade";
        }
    }
}
