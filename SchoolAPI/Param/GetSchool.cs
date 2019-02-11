using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class GetSchool
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SchoolId { get; set; }
    }
}