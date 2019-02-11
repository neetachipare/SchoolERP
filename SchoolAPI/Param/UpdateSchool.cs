using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class UpdateSchool
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }


        public string PhoneNo { get; set; }


        public string Address { get; set; }


        public string ContactPerson { get; set; }

 
        public int PayrollTemplateId { get; set; }

        public int FeeTemplateId { get; set; }

        public int ExamTemplateId { get; set; }

        public int LoginTemplateId { get; set; }

    

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        public string UserPrefix { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }

        public int BoardId { get; set; }

        public int Language { get; set; }

        public string Logo { get; set; }

        public string Banner { get; set; }
        public string LandlineNo { get; set; }
        public string Designation { get; set; }
        public string EmailId { get; set; }
    }
}