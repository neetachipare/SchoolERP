namespace SchoolAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SchoolAPI.Models;

    public partial class SchoolAdminContext : DbContext
    {
        public SchoolAdminContext()
            : base("name=SchoolAdminContext1")
        {
        }

        public virtual DbSet<Tbl_District> Tbl_District { get; set; }
        public virtual DbSet<Tbl_State> Tbl_State { get; set; }
        public virtual DbSet<Tbl_Taluka> Tbl_Taluka { get; set; }
        public virtual DbSet<ViewDistrictList> ViewDistrictLists { get; set; }
        public virtual DbSet<ViewStateList> ViewStateLists { get; set; }
        public virtual DbSet<ViewTalukaList> ViewTalukaLists { get; set; }
        public virtual DbSet<Tbl_AcademicYear_Master> Tbl_AcademicYear_Master { get; set; }
        public virtual DbSet<ViewAcademicYearList> ViewAcademicYearLists { get; set; }
        public virtual DbSet<Tbl_Term_Master> Tbl_Term_Master { get; set; }
        public virtual DbSet<ViewTermList> ViewTermLists { get; set; }
        public virtual DbSet<Tbl_Unit_Master> Tbl_Unit_Master { get; set; }
        public virtual DbSet<ViewUnitList> ViewUnitLists { get; set; }
        public virtual DbSet<Tbl_Board_Master> Tbl_Board_Master { get; set; }
        public virtual DbSet<Tbl_TermCommencementDate> Tbl_TermCommencementDate { get; set; }
        public virtual DbSet<ViewTermCommencementList> ViewTermCommencementLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
