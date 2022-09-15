using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class RESULT
    {
        MY_DB mydb = new MY_DB();
        public string checkid(int stdid, string tenmh)
        {
            SqlCommand comm = new SqlCommand("Select Student_Score from score,Course where Course.Id=score.Course_Id and Student_Id=@id and label=@tmh", mydb.GetConnection);
            comm.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = stdid;
            comm.Parameters.Add("@tmh", System.Data.SqlDbType.NVarChar).Value = tenmh;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0][0].ToString();
            }
            else
                return "N/A";
        }
    }
}
