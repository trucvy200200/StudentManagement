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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string strSql = @"select count(*) from login";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql,conn);
            label1.Text = "Command được tạo và kết nối";
            try
            {
                conn.Open();
         
                cmd.CommandText = @"select count(*) from login";
                label2.Text = "Connecition opened" + "\n Number of rows: " +
                    "\n\t " + cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                label4.Text = "Connection closed";

            }

        }
    }
}
