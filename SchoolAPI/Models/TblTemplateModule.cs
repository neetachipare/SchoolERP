namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTemplateModule")]
    public partial class TblTemplateModule
    {
        [Key]
        public long TemplateModuleId { get; set; }

        public long? TemplateId { get; set; }

        public long? ModuleId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long? Status { get; set; }
    }
}
