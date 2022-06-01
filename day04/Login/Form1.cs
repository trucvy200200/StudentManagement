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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        private void bt_Login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            if (verif())
            {
                if (radioButton_student.Checked)
                {

                    command = new SqlCommand("SELECT * FROM login WHERE username=@User AND password=@Pass", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                   
                    if (table.Rows.Count > 0)
                    {
                        int id = Globals.GlobalUserId;
                        int x = Convert.ToInt32(table.Rows[0][0]);
                        Globals.SetGlobalUserId(x);
                        MainForm mainfrm = new MainForm();
                        mainfrm.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                else if (radioButtonHuman.Checked)
                {
                    command = new SqlCommand("SELECT * FROM hr WHERE uname=@User AND pwd=@Pass", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                   
                    if (table.Rows.Count > 0)
                    {
                        int id = Globals.GlobalUserId;
                        int x = Convert.ToInt32(table.Rows[0][0]);
                        Globals.SetGlobalUserId(x);
                        ContactForm mainfrm = new ContactForm();
                        mainfrm.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((TextBoxUsername.Text.Trim() == "") || (TextBoxPassword.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Form frm = new RegisterForm();
            frm.Show(this);
        }

        private void btn_ForgotPassWord_Click(object sender, EventArgs e)
        {
            Form frm = new ForgotPasswordForm();
            frm.Show(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm frm = new CreateNewAccountForm();
            frm.Show(this);
        }
    }
}
