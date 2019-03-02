namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewDistrictList")]
    public partial class ViewDistrictList
    {
        [StringLength(50)]
        public string District { get; set; }

        public long? StateID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DistrictID { get; set; }

        public int? Status { get; set; }

       // public int? Expr1 { get; set; }

        [StringLength(50)]
        public string State { get; set; }
    }
}
