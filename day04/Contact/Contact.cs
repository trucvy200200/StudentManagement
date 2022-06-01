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
    class Contact
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(string fname, string lname, string phone, string address, string email, int id, int groupid, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("Insert into mycontact(id, fname, lname, group_id, phone, email, address, pic, userid ) values(@id,@fn, @ln, @gr, @phone, @email, @add, @pic, @uid)", mydb.getConnection);
            SqlCommand command = new SqlCommand("Select max(id) from mycontact", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
       
            cmd.Parameters.Add("@id", SqlDbType.Int).Value =id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gr", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
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
        
        public bool updateContact(string fname, string lname, string phone, string address, string email, int id, int groupid, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("update mycontact set fname=@fn, lname=@ln, group_id=@gr, phone=@phone, email=@email, address=@add, pic=@pic, userid=@uid where id = @id", mydb.getConnection);
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gr", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value =id;
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
        public bool deleteContact(int contactid)
        {
            SqlCommand cmd = new SqlCommand("Delete from mycontact where id=@id",mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetContacById(int contactId)
        {
            SqlCommand cmd = new SqlCommand("select id, fname, lname, group_id, phone, email, address, pic, userid from mycontact where id=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkUserID(int ID)
        {
            SqlCommand cmd = new SqlCommand("Select * From hr Where Id=@id", mydb.getConnection);
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
        public bool checkUserIDinMycontact(int ID)
        {
            SqlCommand cmd = new SqlCommand("Select * From mycontact Where userid=@id", mydb.getConnection);
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
    }
}
