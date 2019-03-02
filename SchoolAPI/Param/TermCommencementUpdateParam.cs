using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class TermCommencementUpdateParam
    {
        public long TermCommID { get; set; }
        public long TermID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }
    }
}