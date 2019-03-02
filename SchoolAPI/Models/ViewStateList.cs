namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewStateList")]
    public partial class ViewStateList
    {
        [Key]
        public long StateID { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public int? Status { get; set; }
    }
}
