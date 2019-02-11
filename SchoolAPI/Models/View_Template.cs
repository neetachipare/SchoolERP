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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TemplateTypeId { get; set; }

        [StringLength(50)]
        public string TemplateType { get; set; }
    }
}
