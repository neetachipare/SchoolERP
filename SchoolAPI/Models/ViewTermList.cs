namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewTermList")]
    public partial class ViewTermList
    {
        public int? Status { get; set; }

        [StringLength(50)]
        public string TermName { get; set; }

        [Key]
        public long TermID { get; set; }
    }
}
