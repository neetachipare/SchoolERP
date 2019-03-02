namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Taluka
    {
        [Key]
        public long TalukaID { get; set; }

        public long? DistrictID { get; set; }

        [StringLength(50)]
        public string Taluka { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Status { get; set; }

        public virtual Tbl_District Tbl_District { get; set; }
    }
}
