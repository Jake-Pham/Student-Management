using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();
        public bool checkCourseName(string courseName, int courseID = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName and id <> @cID", mydb.GetConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if((table.Rows.Count > 0))
            {
                //neu phat hien 1 dong toan tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkCourseID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
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
        public bool insertCourse(int id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course(Id, label,period,description)" + "VALUES(@id,@label,@period,@description,@semester)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            mydb.openConnection();
            if(command.ExecuteNonQuery()==1)
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
        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course",mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse(int id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label=@label, period=@period, description=@description WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
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
        public int totalCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course ");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
    }
}
