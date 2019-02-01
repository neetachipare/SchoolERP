namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblUserRole")]
    public partial class TblUserRole
    {
        [Key]
        public long UserId { get; set; }

        public long? RoleId { get; set; }

        [StringLength(50)]
        public string AllowInsert { get; set; }

        [StringLength(50)]
        public string AllowEdit { get; set; }

        [StringLength(50)]
        public string AllowDelete { get; set; }

        [StringLength(50)]
        public string AllowView { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long? Status { get; set; }
    }
}
