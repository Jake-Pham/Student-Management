using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Login
{ 
    class USER
    {
        MY_DB db = new MY_DB();
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT *  FROM HR_Log_in WHERE Id=@uid", db.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        //function to insert a new user
        public bool insertUser(string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HR_Log_in (f_name, l_name, uname, pwd, fig) VALUES (@fn, @ln, @un, @pass, @pic)", db.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            db.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        //kiem tra ton tai, lam theo kieu flag, van con sai
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if(operation == "register")
            {
                query = "SELECT * FROM HR_Log_in WHERE uname=@un";
            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM HR_Log_in WHERE uname = @un AND id <> @uid";
            }
            SqlCommand command=new SqlCommand(query, db.GetConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Update, nhu trong Student
        public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE HR_Log_in SET f_name=@fn, l_name=@ln, uname=@un, pwd=@pass, fig=@pic WHERE  id=@uid", db.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            db.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
