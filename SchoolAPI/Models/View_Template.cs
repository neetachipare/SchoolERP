namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Template
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TemplateTypeId { get; set; }

        [StringLength(50)]
        public string TemplateType { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TemplateId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Status { get; set; }

        public int? Expr1 { get; set; }
    }
}
