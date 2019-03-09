namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewSMTPList")]
    public partial class ViewSMTPList
    {
        [Key]
        public long ConfigurationID { get; set; }

        public int? Port { get; set; }

        [StringLength(5)]
        public string Secure { get; set; }

        [StringLength(50)]
        public string Host { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? Status { get; set; }
    }
}
