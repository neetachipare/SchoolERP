namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewTalukaList")]
    public partial class ViewTalukaList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TalukaID { get; set; }

        public long? DistrictID { get; set; }

        public long? StateID { get; set; }

        [StringLength(50)]
        public string Taluka { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string District { get; set; }
    }
}
