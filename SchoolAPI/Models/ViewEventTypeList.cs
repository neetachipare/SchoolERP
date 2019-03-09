namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewEventTypeList")]
    public partial class ViewEventTypeList
    {
        [Key]
        public long EventTypeID { get; set; }

        [StringLength(50)]
        public string EventType { get; set; }

        public int? Status { get; set; }
    }
}
