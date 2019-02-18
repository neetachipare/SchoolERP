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
        public int SchoolId { get; set; }

        [StringLength(100)]
        public string SchoolName { get; set; }

        [StringLength(15)]
        public string PhoneNo { get; set; }

        [StringLength(15)]
        public string LandlineNo { get; set; }

        [StringLength(100)]
        public string EmailId { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        public DateTime? ValidityStartDate { get; set; }

        public DateTime? ValidityEndDate { get; set; }

        public int? PayrollTemplateId { get; set; }

        public int? FeeTemplateId { get; set; }

        public int? ExamTemplateId { get; set; }

        public int? LoginTemplateId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(5)]
        public string UserPrefix { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public int? BoardId { get; set; }

        public int? Language { get; set; }

        public string Logo { get; set; }

        public string Banner { get; set; }

        public byte? Status { get; set; }
    }
}
