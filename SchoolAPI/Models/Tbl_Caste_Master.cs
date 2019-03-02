namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Caste_Master
    {
        [Key]
        public long CasteID { get; set; }

        public long? ReligionID { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(50)]
        public string CasteName { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Status { get; set; }
    }
}
