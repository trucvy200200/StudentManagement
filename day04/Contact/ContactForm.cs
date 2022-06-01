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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void lb_edit_Click(object sender, EventArgs e)
        {
            EditMyInfoForm frm = new EditMyInfoForm();
            frm.Show(this);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddNewContactForm frm = new AddNewContactForm();
            frm.Show(this);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditContactForm frm = new EditContactForm();
            frm.Show(this);
        }
        MY_DB mydb = new MY_DB();
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from hr where Id = @uid", mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                lb_name.Text = "Welcome (" + table.Rows[0]["uname"].ToString() + ")";
            }
        }
      
        private void ContactForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            comboBoxSelectGroup.DataSource = gr.getGroups(Globals.GlobalUserId);
            comboBoxSelectGroup.DisplayMember = "Group Name";
            comboBoxSelectGroup.ValueMember = "Group ID";
            comboBoxSelectGroup2.DataSource = gr.getGroups(Globals.GlobalUserId);
            comboBoxSelectGroup2.DisplayMember = "Group Name";
            comboBoxSelectGroup2.ValueMember = "Group ID";
        }
        Contact co = new Contact();
        private void btn_SelectContact_Click(object sender, EventArgs e)
        {
            SelectContactForm frm = new SelectContactForm();
            frm.Show(this);


        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxContact.Text);
                if (co.deleteContact(id))
                {
                    MessageBox.Show("Contact deleted");
                }
                else
                {
                    MessageBox.Show("Contact ID is invalid");
                }
            }
            catch
            {
                MessageBox.Show("Empty Field");
            }
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            FullListForm frm = new FullListForm();
            frm.Show(this);
        }
        Group gr = new Group();
        private void btn_AddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEnterGroupName.Text != "" && textBoxIDGroup.Text != "")
                {
                    string gname = textBoxEnterGroupName.Text;
                    int gid = Convert.ToInt32(textBoxIDGroup.Text);
                    if (gr.groupExist(textBoxEnterGroupName.Text, "add",  gid)==false)
                    {
                        if (gr.insertGroup(gid, gname, Globals.GlobalUserId))
                        {
                            MessageBox.Show("New group added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reloadForm();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Group Name already exists", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong");
            }
        }

        private void btn_EditGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSelectGroup.SelectedValue !=null && textBoxEnterNewName.Text != "")
                {
                    int gid = Convert.ToInt32(comboBoxSelectGroup.SelectedValue);
                    string gname = textBoxEnterNewName.Text;
                    if (gr.groupExist(gname, "edit",  gid)==false)
                    {
                        if (gr.updateGroup(gid, gname))
                        {
                            reloadForm();
                            MessageBox.Show("Group edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group Name already exists", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                else
                {
                    MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong");
            }
        }
        public void reloadForm()
        {
            comboBoxSelectGroup.DataSource = gr.getGroups(Globals.GlobalUserId);
            comboBoxSelectGroup.DisplayMember = "Group Name";
            comboBoxSelectGroup.ValueMember = "Group ID";
            comboBoxSelectGroup2.DataSource = gr.getGroups(Globals.GlobalUserId);
            comboBoxSelectGroup2.DisplayMember = "Group Name";
            comboBoxSelectGroup2.ValueMember = "Group ID";
        }
        private void btn_RemoveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(comboBoxSelectGroup2.SelectedValue);
                if ((MessageBox.Show("Are you sure want to delete this group", "Remove group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (gr.deleteGroup(ID))
                    {
                        reloadForm();
                        MessageBox.Show("Group Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        MessageBox.Show("Error", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Choose one to remove", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lb_Refresh_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
