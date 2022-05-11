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
    public partial class ManageCourses : Form
    {
        public ManageCourses()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        int pos;
        private void ManageCourses_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
                comboBoxSemester.Items.Add(1);
                comboBoxSemester.Items.Add(2);
                comboBoxSemester.Items.Add(3);
            }
        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null;
            LabelTotalCourses.Text = ("Total Courses: " + course.totalCourses());

        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            listBoxCourse.SelectedIndex = index;
            TextBoxID.Text = dr.ItemArray[0].ToString();
            TextBoxLabel.Text = dr.ItemArray[1].ToString();
            NumericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
            TextBoxDescription.Text = dr.ItemArray[3].ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int id = Convert.ToInt32(TextBoxID.Text);
            string name = TextBoxLabel.Text;
            int hrs = Convert.ToInt32(NumericUpDownHours.Text);
            string desc = TextBoxDescription.Text;
            int se = (int)comboBoxSemester.SelectedItem;
            if (name.Trim() == "")
            {
                MessageBox.Show("Add a course name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(name))
            {
                if (course.insertCourse(id, name, hrs, desc,se))
                {
                    reloadListBoxData();
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = TextBoxLabel.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string desc = TextBoxDescription.Text;
            int id = int.Parse(TextBoxID.Text);
            int se = (int)comboBoxSemester.SelectedItem;
            if (!course.checkCourseName(name, Convert.ToInt32(TextBoxID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.EditCourse(id, name, hrs, desc, se))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        { 
            try
            {
                int courseID = Convert.ToInt32(TextBoxID.Text);
                if ((MessageBox.Show("Are you sure want to delete this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.RemoveCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxID.Text = "";
                        TextBoxLabel.Text = "";
                        NumericUpDownHours.Value = 10;
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter valid numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pos<(course.getAllCourse().Rows.Count-1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (pos>0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }
    }
}
