namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewRoleList")]
    public partial class ViewRoleList
    {
        [Key]
        public long RoleID { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        public int? Status { get; set; }
    }
}
