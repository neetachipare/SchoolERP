namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewDesignationList")]
    public partial class ViewDesignationList
    {
        [Key]
        public long DesignationID { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }
    }
}
