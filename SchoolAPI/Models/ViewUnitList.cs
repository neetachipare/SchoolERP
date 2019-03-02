namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewUnitList")]
    public partial class ViewUnitList
    {
        [StringLength(50)]
        public string TermName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UnitID { get; set; }

        public long? TermID { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        public int? Status { get; set; }
    }
}
