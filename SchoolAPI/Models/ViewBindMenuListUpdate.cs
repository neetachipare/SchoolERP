namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewBindMenuListUpdate")]
    public partial class ViewBindMenuListUpdate
    {
        public long? TemplateId { get; set; }

        public long? ModuleId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Expr1 { get; set; }

        [StringLength(100)]
        public string ModuleName { get; set; }
    }
}
