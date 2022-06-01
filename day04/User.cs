using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class User
    {
        MY_DB mydb = new MY_DB();
        public DataTable getUserByID(Int32 userId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from hr where Id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            return table;
        }
        public bool checkID(int ID)
        {
            SqlCommand cmd = new SqlCommand("Select * From hr Where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public bool insertUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("Insert into hr(Id, f_name, l_name, uname, pwd, fig) values(@id, @fn, @ln, @un, @pass, @pic)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "Select * from hr where uname=@un";
            }
            else if (operation == "edit")
            {
                query = "select * from hr where uname=@un and id <> @uid";
            }
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateUser(string fname, string lname,  string password, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("update hr set f_name=@fn, l_name=@ln, pwd=@pass, fig=@pic where Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
    }
}
