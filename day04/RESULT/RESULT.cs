using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class RESULT
    {
        MY_DB mydb = new MY_DB();
        public string getResult(double result )
        {
            if (result >= 8 && result <= 10)
            {
                return "A";
            }
            else if (result >= 6.5 && result <8)
            {
                return "B";
            }
            else if (result >= 5 && result < 6.5)
            {
                return "C";
            }
            else 
            {
                return "D";
            }
        }
        public DataTable getAvgScoreByStudent()
        {
            DataColumn dc = new DataColumn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "Select std.Id, std.fname, std.lname, Round(Avg(score.student_score),2) as AverageGrade from score inner join std on score.student_id = std.Id" +
                " Group by std.Id, std.fname, std.lname";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns.Add(dc);
            dc.ColumnName = "Result";
            dc.DataType = System.Type.GetType("System.String");
            return table;
        }
       
        public DataTable getAvgScoreByStudentID(int id)
        {
            DataColumn dc = new DataColumn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "Select Round(Avg(score.student_score),2) as AverageGrade from score inner join std on score.student_id = std.Id" +
                " Group by std.Id, std.fname, std.lname Having std.Id="+id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns.Add(dc);
            dc.ColumnName = "Result";
            dc.DataType = System.Type.GetType("System.String");
            return table;
        }
        public DataTable getData(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); 
            return table;
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
            return execCount("Select Count(a.student_id) from (select distinct student_id from score) a ");
        }
        public string totalA()
        {
            return execCount("Select Count(*) from (Select Score.student_id, Round(Avg(score.student_score),2) as AverageGrade from score Group by Score.student_id) a where AverageGrade between 8 and 10");
        }
        public string totalB()
        {
            return execCount("Select Count(*) from (Select Score.student_id, Round(Avg(score.student_score),2) as AverageGrade from score Group by Score.student_id) a where AverageGrade < 8 and AverageGrade>=6.5 ");
        }
        public string totalC()
        {
            return execCount("Select Count(*) from (Select Score.student_id, Round(Avg(score.student_score),2) as AverageGrade from score Group by Score.student_id) a where AverageGrade < 6.5 and AverageGrade>=5 ");
        }
        public string totalD()
        {
            return execCount("Select Count(*) from (Select Score.student_id, Round(Avg(score.student_score),2) as AverageGrade from score Group by Score.student_id) a where AverageGrade < 5 ");
        }
    }
}
