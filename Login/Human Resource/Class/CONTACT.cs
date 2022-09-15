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
    class CONTACT
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(int id,string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mycontacts(id, fname, lname, group_id, phone, email, address, pic, userid)" + "VALUES(@id,@fn, @ln, @grp, @phn, @mail, @adrs, @pic, @uid)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
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
        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email,int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontacts SET fname=@fn, lname=@ln, group_id=@gid, phone=@phn, email=@mail,address=@adrs,userid=@uid, pic=@pic WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontacts WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getContactById(int contactid)
        {
            SqlCommand command = new SqlCommand("SELECT Id,fname, lname, group_id, phone, email, address, pic, userid FROM mycontacts WHERE Id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkIdContact(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mycontacts WHERE ID = @id", mydb.GetConnection);
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
    }
}
