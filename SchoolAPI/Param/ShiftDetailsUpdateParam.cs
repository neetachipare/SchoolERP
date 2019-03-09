using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class ShiftDetailsUpdateParam
    {
        public long ShiftDetailID { get; set; }
        public long ShiftID { get; set; }

        public string InTime { get; set; }

        public string OutTime { get; set; }

        public string LateMark { get; set; }

        public string EarlyGoing { get; set; }

        public string HalfDayLate { get; set; }

        public string HalfDayEarly { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }
    }
}