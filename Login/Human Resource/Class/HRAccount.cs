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
    class HRAccount
    {
        MY_DB mydb = new MY_DB();
        public bool insertAccount(int id, string firstname, string lastname, string username, string password, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HR_Log_in(Id, f_name, l_name, uname, pwd, fig)" + "VALUES (@Id, @f_name, @l_name, @uname, @pwd, @fig)", mydb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("f_name", SqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("l_name", SqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fig", SqlDbType.Image).Value = pic.ToArray();
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
    }
}
