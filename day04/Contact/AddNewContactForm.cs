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
    public partial class AddNewContactForm : Form
    {
        public AddNewContactForm()
        {
            InitializeComponent();
        }
        Contact co = new Contact();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    string fname = textBoxFname.Text;
                    string lname = textBoxLname.Text;
                    string email = textBoxEmail.Text;
                    string phone = textBoxPhone.Text;
                    string adrs = textBoxAddress.Text;
                    int gr = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString());
                    MemoryStream pic = new MemoryStream();
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);


                    if (co.insertContact(fname, lname, phone, adrs, email, id, gr, pic))
                    {
                        MessageBox.Show("New contact added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ID is duplicated");
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "")
                   || (textBoxAddress.Text.Trim() == "")
                   || (textBoxPhone.Text.Trim() == "")
                   || (pictureBox1.Image == null) || (textBoxEmail.Text.Trim() == "")
                   || (comboBoxGroup.SelectedItem==null)|| (textBoxID.Text.Trim()==""))
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
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        MY_DB mydb = new MY_DB();
        private void AddNewContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from mygroups where userid=@id",mydb.getConnection );
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxGroup.DataSource = table;
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
