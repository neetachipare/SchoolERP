namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewDepartmentList")]
    public partial class ViewDepartmentList
    {
        [Key]
        public long DepartmentID { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }
    }
}
