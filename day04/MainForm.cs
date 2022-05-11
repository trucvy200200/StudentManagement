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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.Show(this);
        }
        private void rToolStripMenuItem_Click(object sende, EventArgs e)
        {
           
        }

        private void rToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentListForm StdList = new StudentListForm();
            StdList.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm frm = new UpdateDeleteStudentForm();
            frm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm frm = new PrintForm();
            frm.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm frm = new StatisticForm();
            frm.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm frm = new ManageStudentForm();
            frm.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm frm = new AddCourseForm();
            frm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm frm = new RemoveForm();
            frm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm frm = new EditCourseForm();
            frm.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourses frm = new ManageCourses();
            frm.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm frm = new AddScoreForm();
            frm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm frm = new RemoveScoreForm();
            frm.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm frm = new avgScoreByCourseForm();
            frm.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm frm = new ManageScoreForm();
            frm.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm frm = new PrintCourseForm();
            frm.Show(this);
        }

        private void avgScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultForm frm = new AvgResultForm();
            frm.Show(this);
        }

        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticResultForm frm = new StatisticResultForm();
            frm.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm frm = new PrintScoreForm();
            frm.Show(this);
        }
    }
}
