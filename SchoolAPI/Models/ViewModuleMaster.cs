namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewModuleMaster")]
    public partial class ViewModuleMaster
    {
        [Key]
        [Column(Order = 0)]
        public long ModuleId { get; set; }

        [StringLength(100)]
        public string ModuleName { get; set; }

        public long? ModuleOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ParentModuleId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int Status { get; set; }
    }
}
