namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewShiftList")]
    public partial class ViewShiftList
    {
        [Key]
        public long ShiftID { get; set; }

        [StringLength(50)]
        public string ShiftName { get; set; }

        public int? Status { get; set; }
    }
}
