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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }
        Group g = new Group();
        private void StudentList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = g.getStudentListByTeacher(Globals.GlobalContactId);
        }
    }
}
