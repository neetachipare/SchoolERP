namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewAcademicYearList")]
    public partial class ViewAcademicYearList
    {
        [StringLength(20)]
        public string Type { get; set; }

        [Key]
        public long AcademicID { get; set; }

        [StringLength(30)]
        public string StartDate { get; set; }

        [StringLength(30)]
        public string EndDate { get; set; }

        public int? Status { get; set; }
    }
}
