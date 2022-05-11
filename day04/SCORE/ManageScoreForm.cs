using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(TextBoxID.Text);
                int courseId = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(TextBoxScore.Text);
                string description = TextBoxDescription.Text;
                if (!score.studentScoreExist(studentId, courseId))
                {
                    if (score.insertScore(studentId, courseId, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Have score already!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(DataGridViewScore.CurrentRow.Cells["student_Id"].Value.ToString());
                int courseID = Convert.ToInt32(DataGridViewScore.CurrentRow.Cells["course_id"].Value.ToString());
                if ((MessageBox.Show("Are you sure want to delete this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridViewScore.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            } 
           catch
           {
                MessageBox.Show("Choose one to remove", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void btn_ShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            DataGridViewScore.DataSource = score.getStudentScore(); 
            DataGridViewScore.Columns[0].HeaderText = "Student ID";
            DataGridViewScore.Columns[1].HeaderText = "First Name";
            DataGridViewScore.Columns[2].HeaderText = "Last Name";
            DataGridViewScore.Columns[3].HeaderText = "Course ID";
            DataGridViewScore.Columns[4].HeaderText = "Score";
      
        }
        STUDENT std = new STUDENT();
        string data = "std";
        void getDataFromDatagridview()
        {
            if (data=="std")
            {
                TextBoxID.Text = DataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data=="score")
            {
                TextBoxID.Text= DataGridViewScore.CurrentRow.Cells[0].Value.ToString();
                ComboBoxCourse.SelectedValue = DataGridViewScore.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void btn_ShowStudent_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand cmd = new SqlCommand("Select * from std");
            DataGridViewScore.DataSource = std.getStudenst(cmd);
            DataGridViewScore.Columns[0].HeaderText = "Student ID";
            DataGridViewScore.Columns[1].HeaderText = "First Name";
            DataGridViewScore.Columns[2].HeaderText = "Last Name";
            DataGridViewScore.Columns[3].HeaderText = "Birth Date";
            DataGridViewScore.Columns[4].HeaderText = "Gender";
            DataGridViewScore.Columns[5].HeaderText = "Phone";
            DataGridViewScore.Columns[6].HeaderText = "Address";
            DataGridViewScore.Columns[7].HeaderText = "Picture";
        }

        private void btn_Average_Click(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = score.getAvgByCourse();
            DataGridViewScore.Columns[0].HeaderText = "Course Name";
            DataGridViewScore.Columns[1].HeaderText = "Average Grade";
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        COURSE course = new COURSE();
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = score.getStudentScore();
            ComboBoxCourse.DataSource = course.getAllCourse();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
        }

        private void DataGridViewScore_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = DataGridViewScore.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridViewScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridview();
        }
    }
}
