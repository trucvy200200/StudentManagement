using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudenst(command);
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Birth Date";
            dataGridView1.Columns[4].HeaderText = "Gender";
            dataGridView1.Columns[5].HeaderText = "Phone";
            dataGridView1.Columns[6].HeaderText = "Address";
            dataGridView1.Columns[7].HeaderText = "Picture";
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            label_Total.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from std where CONCAT(fname,lname,address) like'%" + TextBoxSearch.Text + "%'");
            fillGrid(cmd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBox.Image = Image.FromStream(picture);
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog()==DialogResult.OK))
            {
                PictureBox.Image = Image.FromFile(opf.FileName);     
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxAddress.Text = "";
            TextBoxPhone.Text = "";
            PictureBox.Image =null;
            radioButtonMale.Checked = true;
            DateTimePicker1.Value = DateTime.Now;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + TextBoxID.Text);
            if (PictureBox.Image==null)
            {
                MessageBox.Show("No image in the PictureBox");
            }    
            else if (svf.ShowDialog()==DialogResult.OK)
            {
                PictureBox.Image.Save(svf.FileName+("."+ImageFormat.Jpeg.ToString()));
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
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
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New student added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Not be deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
