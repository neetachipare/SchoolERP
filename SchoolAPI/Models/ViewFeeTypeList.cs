namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewFeeTypeList")]
    public partial class ViewFeeTypeList
    {
        public int? Status { get; set; }

        [Key]
        public long FeeTypeID { get; set; }

        [StringLength(50)]
        public string FeetType { get; set; }
    }
}
