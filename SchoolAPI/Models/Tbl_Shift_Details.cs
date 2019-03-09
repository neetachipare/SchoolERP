namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Shift_Details
    {
        [Key]
        public long ShiftDetailID { get; set; }

        public long? ShiftID { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public TimeSpan? LateMark { get; set; }

        public TimeSpan? EarlyGoing { get; set; }

        public TimeSpan? HalfDayLate { get; set; }

        public TimeSpan? HalfDayEarly { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Status { get; set; }
    }
}
