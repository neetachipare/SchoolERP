namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblSchool")]
    public partial class TblSchool
    {
        [Key]
        public long SchoolId { get; set; }

        [StringLength(100)]
        public string SchoolName { get; set; }

        [StringLength(50)]
        public string PhoneNo { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        public DateTime? ValidityStartDate { get; set; }

        public DateTime? ValidityEndDate { get; set; }

        public long? PayrollTemplateId { get; set; }

        public long? FeeTemplate { get; set; }

        public long? ExamTemplate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long? Status { get; set; }
    }
}
