namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewNotificationTypeList")]
    public partial class ViewNotificationTypeList
    {
        [Key]
        public long NotificationTypeID { get; set; }

        [StringLength(50)]
        public string Notification { get; set; }

        public int? Status { get; set; }
    }
}
