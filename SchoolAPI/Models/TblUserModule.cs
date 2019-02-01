namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblUserModule")]
    public partial class TblUserModule
    {
        [Key]
        public long UserModuleId { get; set; }

        public long? UserId { get; set; }

        public long? RoleId { get; set; }

        public long? ModuleId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long? Status { get; set; }
    }
}
