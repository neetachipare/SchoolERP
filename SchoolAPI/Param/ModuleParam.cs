using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class ModuleParam
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int ModuleOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }

        public string ActionName { get; set; }

        public string BtnStatus { get; set; }
    }
}