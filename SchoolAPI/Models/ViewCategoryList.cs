namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewCategoryList")]
    public partial class ViewCategoryList
    {
        [Key]
        public long CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }
    }
}
