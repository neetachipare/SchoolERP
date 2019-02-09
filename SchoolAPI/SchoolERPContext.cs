namespace SchoolAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SchoolAPI.Models;

    public partial class SchoolERPContext : DbContext
    {
        public SchoolERPContext()
            : base("name=SchoolERPContext")
        {
        }

        public virtual DbSet<TblModuleMaster> TblModuleMasters { get; set; }
        public virtual DbSet<TblRoleMaster> TblRoleMasters { get; set; }
        public virtual DbSet<TblSchool> TblSchools { get; set; }
        public virtual DbSet<TblTemplateModule> TblTemplateModules { get; set; }
        public virtual DbSet<TblTemplatesMaster> TblTemplatesMasters { get; set; }
        public virtual DbSet<TblTemplateTypeMaster> TblTemplateTypeMasters { get; set; }
        public virtual DbSet<TblUserLogin> TblUserLogins { get; set; }
        public virtual DbSet<TblUserModule> TblUserModules { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

        public virtual DbSet<View_MenuList> View_MenuList { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
