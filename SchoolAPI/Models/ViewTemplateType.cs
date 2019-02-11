namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewTemplateType")]
    public partial class ViewTemplateType
    {
        [Key]
        public long TemplateTypeId { get; set; }

        public long? CreatedBy { get; set; }

        [StringLength(50)]
        public string TemplateType { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Status { get; set; }
    }
}
