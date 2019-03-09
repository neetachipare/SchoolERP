namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewCommitteMasterList")]
    public partial class ViewCommitteMasterList
    {
        [StringLength(50)]
        public string CommitteeType { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CommitteeID { get; set; }

        public long? CommitteeTypeID { get; set; }

        public int? Status { get; set; }
    }
}
