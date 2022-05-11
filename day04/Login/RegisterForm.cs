using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day04
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool checkUserName(string username)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("Select * From Login Where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
           
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkUserEmail(string email)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("Select * From Login Where email=@email", mydb.getConnection);
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkmail (string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9\.\-]{3,20}@gmail.com(.vn|)$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            STUDENT account = new STUDENT();
            string mail = TextBoxEmail.Text;
            string user = TextBoxUserName.Text;
            string pass = TextBoxPassword.Text;
            string confirmpass = TextBoxConfirmPassword.Text;
            if (verif() && checkUserName(user) == true && checkUserEmail(mail) == true && pass == confirmpass && checkmail(mail) == true)
            {
                if (account.insertAccount(user, pass, mail))
                {
                    MessageBox.Show("New account added", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkmail(mail) == false)
            {
                label_announce.ForeColor = Color.Red;
                label_announce.Text = "Enter correct email format!\nEg: example@gmail.com";
            }
            else if (checkUserName(user) == false || checkUserEmail(mail) == false)
            {
                label_announce.ForeColor = Color.Red;
                label_announce.Text = "Username/Email Existed!";
            }
            else if (pass != confirmpass)
            {
                label_announce.ForeColor = Color.Red;
                label_announce.Text = "Confirm password is wrong!";
            }
            else if (!verif())
            {
                MessageBox.Show("Empty Fields", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        bool verif()
        {
            if ((TextBoxUserName.Text.Trim() == "")
                   || (TextBoxPassword.Text.Trim() == "")
                   ||(TextBoxConfirmPassword.Text.Trim()=="")||
                   (TextBoxEmail.Text.Trim()==""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
 }

