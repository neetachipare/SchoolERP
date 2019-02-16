using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class TemplateMasterParam
    {
        public long TemplateId { get; set; }

        public string Name { get; set; }

        public long TemplateTypeId { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Status { get; set; }

        public string BtnStatus { get; set; }

        //[NotMapped]
        public string MenuListIds { get; set; }
    }
}