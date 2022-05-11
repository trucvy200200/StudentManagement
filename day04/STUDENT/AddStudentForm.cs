using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day04
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = birthday.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";
            if (student.checkStudentID(id) == true)
            {
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = birthday.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The student Age must be between 10 and 100 year", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
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
            else if (student.checkStudentID(id)==false)
            {
                MessageBox.Show("Student ID is duplicated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         bool verif()
          {
             if ((TextBoxFname.Text.Trim() == "") || (TextBoxLname.Text.Trim() == "")
                    || (TextBoxAddress.Text.Trim()=="")
                    || (TextBoxPhone.Text.Trim() == "")
                    || (PictureBoxStudentImage.Image==null))
                {
                    return false; 
                }
                else
                {
                    return true;
                }
          }
        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*gif)|*.jpg;*png;*.gif";
            if ((opf.ShowDialog()==DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
