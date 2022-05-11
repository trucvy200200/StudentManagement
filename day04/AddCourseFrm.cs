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
    public partial class AddCourseFrm : Form
    {
        public AddCourseFrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddCourseFrm_Load(object sender, EventArgs e)
        {
            comboBoxSemester.Items.Add(1);
            comboBoxSemester.Items.Add(2);
            comboBoxSemester.Items.Add(3);
        }
        COURSE co = new COURSE();
        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int se = (int)comboBoxSemester.SelectedItem;
            listBoxAvailble.DataSource = co.getCourseBySemeter(se);
            listBoxAvailble.DisplayMember = "label";
            listBoxAvailble.ValueMember = "Id";
        }
    }
}
