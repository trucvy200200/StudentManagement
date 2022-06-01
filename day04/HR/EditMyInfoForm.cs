using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class EditMyInfoForm : Form
    {
        public EditMyInfoForm()
        {
            InitializeComponent();
        }
        User u = new User();
        private void EditMyInfoForm_Load(object sender, EventArgs e)
        {
            DataTable table = u.getUserByID(Globals.GlobalUserId);
            textBoxID.Text = table.Rows[0].ItemArray[0].ToString();
            textBoxFname.Text= table.Rows[0].ItemArray[1].ToString();
            textBoxLname.Text = table.Rows[0].ItemArray[2].ToString();
            textBoxPassword.Text = table.Rows[0].ItemArray[4].ToString();
            byte[] pic = (byte[])table.Rows[0]["fig"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(picture);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string pass = textBoxPassword.Text;
            string confirm = textBoxConfirm.Text;
            MemoryStream pic = new MemoryStream();
            
            if (verif())
            {
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                if (pass == confirm)
                {
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (u.updateUser(fname, lname, pass, pic))
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
                    MessageBox.Show("Confirm password again");
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit User Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "")
                   || (textBoxPassword.Text.Trim() == "")
                   || (textBoxConfirm.Text.Trim() == "")
                   || (pictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*gif)|*.jpg;*png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
