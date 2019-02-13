namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblBoard")]
    public partial class TblBoard
    {
        [Key]
        public long BoardId { get; set; }

        [StringLength(50)]
        public string BoardName { get; set; }

        public int? Status { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
