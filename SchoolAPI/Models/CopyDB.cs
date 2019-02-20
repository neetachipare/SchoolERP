using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace New_project.Models
{
    public class CopyDB
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SchoolERPContext"].ConnectionString);

        public void Copydata(string name)
        {
            SqlCommand cmd = new SqlCommand("SPCOPYERPDB", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DBNAME", name);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
        }
    }

}