namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewSchoolAchievementDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AchievementDID { get; set; }

        public long? AchievementTypeID { get; set; }

        [StringLength(500)]
        public string Achievement { get; set; }

        public DateTime? Date { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string AchievementType { get; set; }
    }
}
