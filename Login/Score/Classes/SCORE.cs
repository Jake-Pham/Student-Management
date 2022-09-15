using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description) VALUES (@sid,@cid,@scr" + ",@descr)", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
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
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id=@sid AND course_id=@cid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //tinh trung binh
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = "SELECT Course.label as Label, ROUND(AVG(score.student_score),2) As AverageGrade FROM Course, score WHERE Course.Id=" + "score.course_id GROUP BY Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //delete score bang student id va course id
        public bool deleteScore(int studentdID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id=@sid AND course_id=@cid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentdID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
