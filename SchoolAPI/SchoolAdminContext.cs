
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

         //public virtual DbSet<Tbl_District> Tbl_District { get; set; }
        //public virtual DbSet<Tbl_State> Tbl_State { get; set; }
        //public virtual DbSet<Tbl_Taluka> Tbl_Taluka { get; set; }
        public virtual DbSet<Tbl_Religion_Master> TblReligionMasters { get; set; }
        public virtual DbSet<ViewReligionList> ViewReligionLists { get; set; }
        public virtual DbSet<Tbl_Category_Master> Tbl_Category_Master { get; set; }
        public virtual DbSet<ViewCategoryList> ViewCategoryLists { get; set; }
        public virtual DbSet<Tbl_Minority_Master> Tbl_Minority_Master { get; set; }
        public virtual DbSet<ViewMinorityList> ViewMinorityLists { get; set; }
        public virtual DbSet<Tbl_Caste_Master> Tbl_Caste_Master { get; set; }
        public virtual DbSet<Tbl_Sub_Caste_Master> Tbl_Sub_Caste_Master { get; set; }
        public virtual DbSet<ViewCasteList> ViewCasteLists { get; set; }
        public virtual DbSet<ViewSubCasteList> ViewSubCasteLists { get; set; }
        public virtual DbSet<Tbl_Department_Master> Tbl_Department_Master { get; set; }
        public virtual DbSet<Tbl_Designation_Master> Tbl_Designation_Master { get; set; }
        public virtual DbSet<ViewDepartmentList> ViewDepartmentLists { get; set; }
        public virtual DbSet<ViewDesignationList> ViewDesignationLists { get; set; }
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
