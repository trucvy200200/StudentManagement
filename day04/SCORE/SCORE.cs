using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand cmd = new SqlCommand("Insert into score(student_id, course_id, student_score, description) values (@sid, @cid, @scr " + ",@descr)", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            cmd.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            cmd.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool studentScoreExist(int studentId, int courseID)
        {
            SqlCommand cmd = new SqlCommand("Select * from score where student_id = @sid and course_id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getAvgByCourse()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "Select Course.label, Round(Avg(score.student_score),2) as AverageGrade from Course, score where Course.Id =" +
                "score.course_id Group by Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand cmd = new SqlCommand("delete from score where student_Id = @sid and course_id=@cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getStudentScore()
        {
            SqlCommand cmd = new SqlCommand("select score.student_id, std.fname, std.lname, score.course_id, course.label, score." +
                "student_score from std inner join score on std.id = score.student_id inner join course on score.course_id = course.id", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchScoreByCourseName(string cname)
        {
            SqlCommand cmd = new SqlCommand("select score.student_id, std.fname, std.lname, score.course_id, course.label, score." +
                "student_score from std inner join score on std.id = score.student_id inner join course on score.course_id = course.id where course.label = @cname", mydb.getConnection);
            cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = cname;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
