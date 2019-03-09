using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using SchoolAPI;
using SchoolAPI.ResultModel;

namespace New_project.Models
{
    public class CopyDB
    {
        SchoolERPContext db = new SchoolERPContext();
        public void Copydata(string name)
        {
            var results = db.Database.SqlQuery<Result>("SPCOPYERPDB @DBNAME", new SqlParameter("@DBNAME", name)).ToList();
           
        }
    }

}