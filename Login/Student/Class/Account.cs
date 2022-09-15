using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class Account
    {
        public bool insertAccount(string username, string password)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("INSERT INTO Log_in(username,pass)" + "VALUES (@User,@Pass)", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
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
    }
}
