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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            try
            {
                int courseID = Convert.ToInt32(TextBoxCourseID.Text);
                if ((MessageBox.Show("Are you sure want to delete this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.RemoveCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
