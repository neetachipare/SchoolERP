namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewCommitteeList")]
    public partial class ViewCommitteeList
    {
        [Key]
        public long CommitteeTypeId { get; set; }

        [StringLength(50)]
        public string CommitteeType { get; set; }

        public int? Status { get; set; }
    }
}
