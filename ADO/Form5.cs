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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection Con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Con.Open();
                cmd.Connection = Con;
                cmd.CommandText = @"select count(*) from Employees";
                richTextBox1.Text = "Connection opened" +
                    "\n Kết nối lệnh với Connection hiện hữu" +
                    "\n \t " + cmd.CommandText;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                Con.Close();
            }
        }
    }
}
