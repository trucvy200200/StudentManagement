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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxLabel.Text);
            int hrs = (int)NumericUpDownHours.Value;
            string desc = Description.Text;
            int id = (int)ComboBoxCourse.SelectedValue;
            int se = (int)comboBoxSemester.SelectedItem;
            int te = Convert.ToInt32(comboBoxTeacher.SelectedValue);

            if (!course.checkCourseName(name, Convert.ToInt32(ComboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.EditCourse(id,name,hrs,desc,se, te))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                textBoxLabel.Text= table.Rows[0][1].ToString();
                NumericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                Description.Text = table.Rows[0][3].ToString();
                comboBoxSemester.Text = table.Rows[0][4].ToString();
                comboBoxTeacher.Text= table.Rows[0][5].ToString();
            }
            catch
            { }
        }
        public void fillCombo(int index)
        {
            ComboBoxCourse.DataSource = course.getAllCourse();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedIndex = index;
        }
        Contact co = new Contact();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            ComboBoxCourse.DataSource = course.getAllCourse();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedItem = null;
            comboBoxSemester.Items.Add(1);
            comboBoxSemester.Items.Add(2);
            comboBoxSemester.Items.Add(3);
            SqlCommand cmd = new SqlCommand("Select Id from mycontact");
            comboBoxTeacher.DataSource = co.SelectContactList(cmd);
            comboBoxTeacher.DisplayMember = "Id";
            comboBoxTeacher.ValueMember= "Id";
        }

        private void NumericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
