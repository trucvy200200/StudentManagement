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

namespace ADO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
                richTextBox1.Text = "Connection opend" +
                    "\n Connection Properties: " +
                    "\n\t " + conn.ConnectionString +
                    "\n\t " + conn.Database +
                    "\n\t " + conn.DataSource +
                    "\n\t " + conn.State +
                    "\n\t " + conn.WorkstationId;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error; " + ex.Message);
            }
            finally
            {
                conn.Close();
                label1.Text = "Connection closed";
            }
        }
    }
}
