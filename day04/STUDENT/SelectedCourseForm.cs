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
    public partial class SelectedCourseForm : Form
    {
        public SelectedCourseForm()
        {
            InitializeComponent();
        }
        STUDENT st = new STUDENT();
        private void SelectedCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = st.getSelectedCourse();
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
