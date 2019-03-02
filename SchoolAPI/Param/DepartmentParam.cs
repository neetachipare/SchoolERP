using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class DepartmentParam
    {
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }
        public string BtnStatus { get; set; }
    }
}