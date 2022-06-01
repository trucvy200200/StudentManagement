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
            listBoxAvailable.DataSource = co.getCourseBySemeter(se);
            listBoxAvailable.DisplayMember = "label";
            listBoxAvailable.ValueMember = "Id";
        }
        MY_DB mydb = new MY_DB();
        void reloadListBoxData(int sid)
        {
            SqlCommand command = new SqlCommand("Select a.Course_Id, b.label from SelectedCourse a inner join Course b on a.Course_Id = b.Id where Student_Id=@sid");
            command.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            listBoxSelected.DataSource = table;
            listBoxSelected.ValueMember = "Course_id";
            listBoxSelected.DisplayMember = "label";
            listBoxSelected.SelectedItem = null;
        }
        STUDENT std = new STUDENT();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = int.Parse(textBoxStudentID.Text);
                int cid = Convert.ToInt32(listBoxAvailable.SelectedValue);
                if (co.checkDuplicateCourse(sid, cid) == true && std.checkStudentID(sid)==false)
                {
                    if (co.insertSelectedCourseByID(sid, cid) == true)
                    {
                        MessageBox.Show("Course Added!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData(sid);
                    }
                }
                else if (co.checkDuplicateCourse(sid, cid) == false)
                {
                    MessageBox.Show("Course Already Exist", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (std.checkStudentID(sid) == true)
                {
                    MessageBox.Show("Student ID is invalid", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Student ID must be mumeric", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = Convert.ToInt32(textBoxStudentID.Text);
                int cid = (int)listBoxSelected.SelectedValue;
                if (std.checkStudentID(sid) == false)
                {
                    if (co.RemoveSelectedCourseByID(sid, cid) == true)
                    {
                        MessageBox.Show("Course Deleted!", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData(sid);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Exist", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(std.checkStudentID(sid) == true)
                {
                    MessageBox.Show("Student ID is invalid");
                }
            }
            catch
            {
                MessageBox.Show("Student ID must be mumeric", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
