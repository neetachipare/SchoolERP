using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class SchoolAchievementDetailsParam
    {
        public long AchievementDID { get; set; }

        public long AchievementTypeID { get; set; }

       
        public string Achievement { get; set; }

        public DateTime Date { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }
    }
}