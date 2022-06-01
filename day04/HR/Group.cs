using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class Group
    {
        MY_DB mydb = new MY_DB();
        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand cmd = new SqlCommand("Insert into mygroups(id, name, userid ) values(@id,@gn, @uid)", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = userid;
           
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
        public bool updateGroup(int id, string gname)
        {
            SqlCommand cmd = new SqlCommand("update mygroups set name=@gname where id = @id", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@gname", SqlDbType.VarChar).Value = gname;
  

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
        public bool deleteGroup(int groupid)
        {
            SqlCommand cmd = new SqlCommand("delete from mygroups where id = @id", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
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
        public DataTable getGroups(int userid)
        {
            SqlCommand cmd = new SqlCommand("Select Id as 'Group ID', name as 'Group Name', userid as 'User ID' from mygroups where userid=@uid", mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getMyGroups(int userid)
        {
            SqlCommand cmd = new SqlCommand("Select mycontact.Id as 'Contact ID', fname as 'First Name', lname as 'Last Name', mygroups.Id as 'Group ID' , mygroups.name as 'Group', phone, email, address, pic as 'Picture' from mycontact inner join mygroups on mycontact.group_id = mygroups.id where mycontact.userid=@uid", mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool groupExist(string name, string operation, int groupid=0)
        {
            string query = "";
            SqlCommand cmd = new SqlCommand();
            if (operation == "add")
            {
                query = "Select * from mygroups where name = @name";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            }
            else if(operation == "edit")
            {
                query = "Select * from mygroups where name = @name and id <>@gid";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                
                cmd.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        public DataTable getStudentListByTeacher(int contactid)
        {
            SqlCommand cmd = new SqlCommand("Select distinct std.Id as 'Student ID', std.fname as 'First Name', std.lname as 'Last Name', std.bdate as 'Birthdate', std.gender as 'Gender', std.phone as 'Phone', std.address as 'Address' "
                + "from course inner join Score on course.Id = score.course_id inner join std on score.student_id = std.Id "
                + "where course.teacher=@conid", mydb.getConnection);
            cmd.Parameters.Add("@conid", SqlDbType.Int).Value = contactid;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
