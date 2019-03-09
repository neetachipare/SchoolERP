namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewEventMasterList
    {
        [StringLength(50)]
        public string EventType { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EventID { get; set; }

        public long? EventTypeID { get; set; }

        [StringLength(50)]
        public string EventName { get; set; }

        [StringLength(30)]
        public string StartDate { get; set; }

        [StringLength(30)]
        public string EndDate { get; set; }

        public int? Status { get; set; }
    }
}
