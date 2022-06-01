using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Drawing;

namespace day04
{
    class STUDENT
    {
        MY_DB mydb = new MY_DB();
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
                command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery()==1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        public bool checkStudentID(int studentID)
        {
            SqlCommand cmd = new SqlCommand("Select * From std Where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
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
        public bool EditStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("Update std set id= @id, fname =@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, address=@adrs, picture=@pic where id=@id " , mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        public bool insertAccount(string user, string pass, string mail)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (id, username, password, email)" +
                    "VALUES (@id, @user, @pass, @mail)", mydb.getConnection);
            SqlCommand cmd = new SqlCommand("Select max(id) from login");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];

            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dr[0].ToString()) + 1;
            command.Parameters.Add("@user", SqlDbType.Char).Value = user;
            command.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
            command.Parameters.Add("@mail", SqlDbType.Char).Value = mail;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        
        public bool change_account(string user, string pass)
        {
            SqlConnection conn = mydb.getConnection;
            conn.Open();
            string sql = "Update login set password = @pass where username = @user";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            // Thêm và sét đặt giá trị cho tham số.
            cmd.Parameters.Add("@user", SqlDbType.Char).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.Char).Value = pass;


            mydb.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getStudenst(SqlCommand command)
        {
            command.Connection=mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudenst2(SqlCommand command)
        {
            DataColumn dc = new DataColumn();
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns.Add(dc);
            dc.ColumnName = "Selected Course";
            return table;
        }
        public DataTable getSelectedCourse()
        {
            SqlCommand command = new SqlCommand("select a.Course_Id as 'Course ID', b.label as 'Course Name' from SelectedCourse a inner join Course b on a.Course_Id = b.Id where a.Student_Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Globals.GlobalStudentId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
          
        }
        public bool RemoveStudent(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from std where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if ((cmd.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string TotalStudent()
        {
            return execCount("Select Count(*) from std");
        }
        public string totalMaleStudent()
        {
            return execCount("Select Count(*) from std where gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("Select Count(*) from std where gender='Female'");
        }
       public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
    }
}
