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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            ComboBoxCourse.DataSource = course.getAllCourse();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            SqlCommand cmd = new SqlCommand("Select id, fname, lname from std");
            dataGridViewStudent.DataSource = student.getStudenst(cmd);
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(TextBoxID.Text);
                int courseId = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(TextBoxScore.Text);
                string description = TextBoxDescription.Text;
                if (scoreValue > 10 || scoreValue < 0)
                {
                    MessageBox.Show("Score must be between 0-10","Add Score");
                }
                else
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
