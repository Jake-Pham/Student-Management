using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Login
{
    class GROUP
    {
        MY_DB mydb = new MY_DB();
        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroups(id, name, userid) VALUES (@id, @gn, @uid)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
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
        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET name=@name WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
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
            SqlCommand command = new SqlCommand("DELETE FROM mygroups WHERE Id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        //Chức năng này quan trọng, xác định group cho userId nó
        public DataTable getGroups(int userId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid=@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //phan nay ktra xem grp co ton tai hay chua,copy tu phan truoc, thay doi de ktra id trong muc Add Contact 
        public bool groupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if(operation == "add")
            {
                query = "SELECT * FROM mygroups WHERE name=@name AND userid=@uid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM mygroups WHERE name=@name AND userid =@uid AND id <> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid; ;
                command.Parameters.Add("@gid",SqlDbType.Int).Value=groupid;
            }
            command.Connection = mydb.GetConnection;
            command.CommandText = query;
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
    }
}
