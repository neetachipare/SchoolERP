namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewCasteList")]
    public partial class ViewCasteList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CasteID { get; set; }

        public long? ReligionID { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(50)]
        public string CasteName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string ReligionName { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
