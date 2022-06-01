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
    public partial class CreateNewAccountForm : Form
    {
        public CreateNewAccountForm()
        {
            InitializeComponent();
        }
        User user = new User();
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (verif()==true)
            {
                int hid = Convert.ToInt32(textBoxID.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                string username = textBoxUsername.Text;
                string pass = textBoxPassword.Text;
                MemoryStream pic = new MemoryStream();
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                if (user.checkID(hid) == true)
                {
                    if (!user.usernameExist(username, "register", hid))
                    {
                        if (user.insertUser(hid, fname, lname, username, pass, pic) == true)
                        {
                            MessageBox.Show("Registration completed successfully");
                        }
                        else
                        {
                            MessageBox.Show("Something wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This username already exists");
                    }
                }
                else
                {
                    MessageBox.Show("This ID already exists");
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Error");
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "")
                   || (textBoxUsername.Text.Trim() == "")
                   || (textBoxPassword.Text.Trim() == "")
                   || (pictureBox.Image == null|| textBoxID.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lb_Have_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(this);
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
