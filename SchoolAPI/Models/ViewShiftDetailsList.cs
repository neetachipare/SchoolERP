namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewShiftDetailsList")]
    public partial class ViewShiftDetailsList
    {
        public long? ShiftID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ShiftDetailID { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public TimeSpan? LateMark { get; set; }

        public TimeSpan? EarlyGoing { get; set; }

        public TimeSpan? HalfDayLate { get; set; }

        public TimeSpan? HalfDayEarly { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string ShiftName { get; set; }
    }
}
