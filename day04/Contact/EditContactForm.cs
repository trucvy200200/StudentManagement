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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        private void btn_SelectContact_Click(object sender, EventArgs e)
        {
            SelectContactForm frm = new SelectContactForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*gif)|*.jpg;*png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Contact co = new Contact();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int gr = Convert.ToInt32(comboBoxGroup.SelectedValue);
                    int id = Convert.ToInt32(textBoxID.Text);
                    string fname = textBoxFname.Text;
                    string lname = textBoxLname.Text;
                    string email = textBoxEmail.Text;
                    string phone = textBoxPhone.Text;
                    string adrs = textBoxAddress.Text;
                    
                    MemoryStream pic = new MemoryStream();
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                    if (co.updateContact(fname, lname, phone, adrs, email, id, gr, pic))
                    {
                        MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            catch 
            {
                MessageBox.Show("Group ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "")
                   || (textBoxAddress.Text.Trim() == "")
                   || (textBoxPhone.Text.Trim() == "")
                   || (pictureBox1.Image == null) || (textBoxEmail.Text.Trim() == "")
                   || (comboBoxGroup.Text == "") || (textBoxID.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        MY_DB mydb = new MY_DB();

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from mygroups where userid=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxGroup.DataSource = table;
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
        }
    }
}
