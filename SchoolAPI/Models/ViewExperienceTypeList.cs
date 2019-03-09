namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewExperienceTypeList")]
    public partial class ViewExperienceTypeList
    {
        [Key]
        public long ExprienceTypeID { get; set; }

        [StringLength(50)]
        public string ExprienceType { get; set; }

        public int? Status { get; set; }
    }
}
