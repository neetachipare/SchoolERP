namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewTermCommencementList")]
    public partial class ViewTermCommencementList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TermCommID { get; set; }

        public long? TermID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string TermName { get; set; }
    }
}
