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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        Contact co = new Contact();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select id, fname, lname, group_id from mycontact where userid = @userid");
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserId;
            DataTable table = co.SelectContactList(cmd);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Contact ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Group";
      
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}
