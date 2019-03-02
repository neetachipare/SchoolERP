namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewMinorityList")]
    public partial class ViewMinorityList
    {
        [Key]
        public long MinorityID { get; set; }

        [StringLength(50)]
        public string MinorityName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }
    }
}
