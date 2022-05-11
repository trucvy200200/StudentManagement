using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void btn_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("Select * from std where id= " + id);
            DataTable table = student.getStudenst(command);
            if (table.Rows.Count > 0)
            {
                TextBoxFirstName.Text = table.Rows[0]["fname"].ToString();
                TextBoxLastName.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString().Trim() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBox.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            StudentListForm std = new StudentListForm();
            string lname = TextBoxSearch.Text.Trim();
            SqlCommand command = new SqlCommand("Select * from std where lname=@lname ");
            command.Parameters.Add("@lname", SqlDbType.Char).Value = lname;
            std.Show();
            std.DataGridView1.DataSource = student.getStudenst(command);
            if (std.DataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Result found!");
            }
            else
            {
                MessageBox.Show("No result");
            }
}

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            int id = Convert.ToInt32(TextBoxID.Text);
            string fname = TextBoxFirstName.Text;
            string lname = TextBoxLastName.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student Age must be between 10 and 100 year", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                PictureBox.Image.Save(pic, PictureBox.Image.RawFormat);
                if (student.EditStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("Edited");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((TextBoxFirstName.Text.Trim() == "") || (TextBoxLastName.Text.Trim() == "")
                   || (TextBoxAddress.Text.Trim() == "")
                   || (TextBoxPhone.Text.Trim() == "")
                   || (PictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
    }

    

    private void btn_Remove_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.RemoveStudent(int.Parse(TextBoxID.Text)))
                    {
                        MessageBox.Show("Removed");
                    }
                    else
                    {
                        MessageBox.Show("Not be deleted", "Delete Student",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std");
            DataTable table = student.getStudenst(command);
            TextBoxID.Text = table.Rows[0]["id"].ToString();
            TextBoxFirstName.Text = table.Rows[0]["fname"].ToString();
            TextBoxLastName.Text = table.Rows[0]["lname"].ToString();
            DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
            if (table.Rows[0]["gender"].ToString().Trim() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
            TextBoxAddress.Text = table.Rows[0]["address"].ToString();
            byte[] pic = (byte[])table.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);
            PictureBox.Image = Image.FromStream(picture);
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std");
            DataTable table = student.getStudenst(command);
            int n = table.Rows.Count-1;
            TextBoxID.Text = table.Rows[n]["id"].ToString();
            TextBoxFirstName.Text = table.Rows[n]["fname"].ToString();
            TextBoxLastName.Text = table.Rows[n]["lname"].ToString();
            DateTimePicker1.Value = (DateTime)table.Rows[n]["bdate"];
            if (table.Rows[n]["gender"].ToString().Trim() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = table.Rows[n]["phone"].ToString();
            TextBoxAddress.Text = table.Rows[n]["address"].ToString();
            byte[] pic = (byte[])table.Rows[n]["picture"];
            MemoryStream picture = new MemoryStream(pic);
            PictureBox.Image = Image.FromStream(picture);
        }
        private int GetIndex()
        {
            int n = -1;
            SqlCommand command = new SqlCommand("Select * from std");
            DataTable table = student.getStudenst(command);
            StudentListForm data = new StudentListForm();
            foreach(DataRow Row in table.Rows)
            {
                if (TextBoxID.Text==Row["id"].ToString().Trim())
                {
                   n = table.Rows.IndexOf(Row);
                    break;
                }   
            }
            return n;
        }
        private void btn_Previous_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std");
            DataTable table = student.getStudenst(command);
            StudentListForm data = new StudentListForm();
            int n = GetIndex();
            //TextBoxSearch.Text = Convert.ToString(n);
            if ( n> 0 && table.Rows.Count > 0)
                {
                    TextBoxID.Text = table.Rows[n-1]["id"].ToString();
                    TextBoxFirstName.Text = table.Rows[n-1]["fname"].ToString();
                    TextBoxLastName.Text = table.Rows[n-1]["lname"].ToString();
                    DateTimePicker1.Value = (DateTime)table.Rows[n-1]["bdate"];
                    if (table.Rows[n-1]["gender"].ToString().Trim() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[n-1]["phone"].ToString();
                    TextBoxAddress.Text = table.Rows[n-1]["address"].ToString();
                    byte[] pic = (byte[])table.Rows[n-1]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBox.Image = Image.FromStream(picture);
                }
                else if (n <=0)
                {
                    MessageBox.Show("This is the first item");
                }
                else
                {
                    MessageBox.Show("No item found");
                }
            
         
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std");
            DataTable table = student.getStudenst(command);
            StudentListForm data = new StudentListForm();
            int n = GetIndex();
            //TextBoxSearch.Text = Convert.ToString(n);
            if (n >= 0 && n< table.Rows.Count-1 && table.Rows.Count > 0)
            {
                TextBoxID.Text = table.Rows[n + 1]["id"].ToString();
                TextBoxFirstName.Text = table.Rows[n + 1]["fname"].ToString();
                TextBoxLastName.Text = table.Rows[n + 1]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[n + 1]["bdate"];
                if (table.Rows[n + 1]["gender"].ToString().Trim() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                TextBoxPhone.Text = table.Rows[n + 1]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[n + 1]["address"].ToString();
                byte[] pic = (byte[])table.Rows[n + 1]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBox.Image = Image.FromStream(picture);
            }
            else if (n >= table.Rows.Count-1)
            {
                MessageBox.Show("This is the last item");
            }
            else
            {
                MessageBox.Show("No item found");
            }
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            AddCourseFrm frm = new AddCourseFrm();
            frm.Show(this);
        }
    }
}
