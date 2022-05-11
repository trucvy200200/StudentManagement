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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        void getTable(string strSQL)
        {
            string strCon = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            listView1.Clear();
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL,Con);
            listView1.Columns.Add("ID", 70, 0);
            listView1.Columns.Add("User Name", 150, 0);
            listView1.Columns.Add("Password", 200, 0);
            listView1.View = View.Details;
            ListViewItem item1;
            try
            {
                SqlDataReader dr;
                Con.Open();
                dr = Com.ExecuteReader();
                while (dr.Read())
                {
                    item1 = new ListViewItem(dr[0].ToString());
                    item1.SubItems.Add(dr[1].ToString());
                    item1.SubItems.Add(dr[2].ToString());
                    item1.SubItems.Add(dr.GetString(2));
                    listView1.Items.Add(item1);
                }
                dr.Close();
                dr.Dispose();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
            }
            finally
            {
                Con.Dispose();
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string SQL = "select * from ";
            SQL += "login";
            getTable(SQL);
        }
    }
}
