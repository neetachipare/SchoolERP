using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class MenuSubMenuParam
    {
        public Int64 ModuleId
        {
            get;set;
        }
        public Int64 CreatedBy
        {
            get;set;
        }
        public DateTime CreatedDate
        {
            get; set;
        }
        public Int64 ModifiedBy
        {
            get; set;
        }
        public DateTime ModifiedDate
        {
            get; set;
        }
        public string Role
        {
            get;set;
        }
        public string AllowInsert
        { get; set; }
      

        public string AllowEdit { get; set; }
        public string AllowDelete { get; set; }
        public string AllowView { get; set; }
        public string selectedid { get; set; }
        public string Unselectedid { get; set; }
        public Int32 RoleId { get; set; }




    }
}