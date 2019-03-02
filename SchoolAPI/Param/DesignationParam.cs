using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class DesignationParam
    {
        public int DesignationID { get; set; }
        public string Designation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }
        public string BtnStatus { get; set; }
    }
}