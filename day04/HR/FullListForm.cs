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
    public partial class FullListForm : Form
    {
        public FullListForm()
        {
            InitializeComponent();
        }
        Group gr = new Group();
        MY_DB mydb = new MY_DB();
        private void FullListForm_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            listBox1.DataSource = gr.getGroups(Globals.GlobalUserId);
            listBox1.DisplayMember = "Group Name";
            listBox1.ValueMember = "Group ID";
            dataGridView1.DataSource = gr.getMyGroups(Globals.GlobalUserId);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows =false;
        }
        Contact co = new Contact();
         private void listBox1_Click(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            int id = (int)listBox1.SelectedValue;
            SqlCommand cmd = new SqlCommand("Select mycontact.Id as 'Contact ID', fname as 'First Name', lname as 'Last Name',  mygroups.Id as 'Group ID', mygroups.name as 'Group', phone, email, address, pic as 'Picture' "
                + "from mycontact inner join mygroups on mycontact.group_id = mygroups.id where "
                +"mycontact.userid=@uid and mycontact.group_id = @groupid", mydb.getConnection);
            cmd.Parameters.Add("@groupid", SqlDbType.Int).Value =id ;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView1.DataSource = co.SelectContactList(cmd);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gr.getMyGroups(Globals.GlobalUserId);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Globals.SetGlobalContactId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            StudentList frm = new StudentList();
            frm.Show(this);
             
        }
    }
}
