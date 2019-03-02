namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewReligionList")]
    public partial class ViewReligionList
    {
        [Key]
        public long ReligionID { get; set; }

        [StringLength(50)]
        public string ReligionName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }
    }
}
