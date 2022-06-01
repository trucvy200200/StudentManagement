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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                COURSE course = new COURSE();
                int id = Convert.ToInt32(CourseID.Text);
                string name = Label.Text;
                int hrs = Convert.ToInt32(Period.Text);
                string desc = Description.Text;
                int se = (int)comboBoxSemester.SelectedItem;
                int te = Convert.ToInt32(comboBoxTeacher.SelectedValue);
                if (course.checkExistCourseID(id))
                {
                    if (name.Trim() == "")
                    {
                        MessageBox.Show("Add a course name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.checkCourseName(name))
                    {
                        if (course.insertCourse(id, name, hrs, desc, se, te))
                        {
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
                else
                {
                    MessageBox.Show("ID exist");
                }
            }
            catch
            {
                MessageBox.Show("Error Format");
            }

        }
        Contact co = new Contact();
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxSemester.Items.Add(1);
            comboBoxSemester.Items.Add(2);
            comboBoxSemester.Items.Add(3);
            SqlCommand cmd = new SqlCommand("Select Id from mycontact");
            comboBoxTeacher.DataSource = co.SelectContactList(cmd);
            comboBoxTeacher.DisplayMember = "Id";
            comboBoxTeacher.ValueMember = "Id";
        }
    }
}
