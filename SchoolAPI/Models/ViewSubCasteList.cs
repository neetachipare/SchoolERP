namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewSubCasteList")]
    public partial class ViewSubCasteList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SubCasteID { get; set; }

        public long? CasteID { get; set; }

        [StringLength(50)]
        public string SubCasteName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string CasteName { get; set; }
    }
}
