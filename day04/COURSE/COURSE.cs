using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(int Id, string courseName, int hoursNumber, string description, int semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description, semester)" +
                "VALUES (@id, @name, @period, @desc, @semester)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@period", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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

        public bool EditCourse(int courseID, string courseName, int hoursNumber, string description, int semester)
        {
            SqlCommand command = new SqlCommand("Update Course set label=@name, period=@hrs, description=@descr, semester=@semester where id=@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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
        public bool RemoveCourse(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from Course where id=@id", mydb.getConnection);
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
        public bool checkCourseName(string courseName, int courseID = 0)
        {
            SqlCommand cmd = new SqlCommand("Select * From Course Where label=@Name and id<>@id", mydb.getConnection);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = courseID;
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
        public DataTable getAllCourse()
        {
            SqlCommand cmd = new SqlCommand("select * from Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourse(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseByID(int courseID)
        {
            SqlCommand cmd = new SqlCommand("Select * from Course where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourses()
        {
            return execCount("Select count(*) from Course");
        }
        public DataTable getCourseBySemeter(int se)
        {
            SqlCommand cmd = new SqlCommand("Select * from Course where semester=@se", mydb.getConnection);
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = se;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }   
}
