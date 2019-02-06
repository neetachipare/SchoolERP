using SchoolAPI.Models;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.BusinessLayer
{
    public class CreateModuleBL
    {
        SchoolERPContext db = new SchoolERPContext();
        public object SaveModule(ModuleParam MP)
        {
            try
            {
                var usercode = db.TblModuleMasters.Where(r => r.ModuleName == MP.ModuleName).FirstOrDefault();
                if (usercode != null)
                {
                    return new Error() { IsError = true, Message = "Module Name Already Exists!" };
                }
                TblModuleMaster objModule = new TblModuleMaster();

                objModule.ModuleName = MP.ModuleName;
                objModule.ModuleOrder = MP.ModuleOrder;
                objModule.CreatedBy = MP.CreatedBy;
                objModule.CreatedDate = DateTime.Now;
                db.TblModuleMasters.Add(objModule);
                db.SaveChanges();

                return new Result() { IsSucess = true, ResultData = "Module Saved Successfully!" };


            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }


        public object GetModuleList(int status)
        {
            try
            {
                List<SchoolAPI.Models.ViewModuleMaster> GetModule = null;

                if (status == 0)
                {
                    GetModule = db.ViewModuleMasters.Where(r => r.Status != 1).ToList();
                }
                else

                {
                    GetModule = db.ViewModuleMasters.Where(r => r.Status == 1).ToList();

                }

                if (GetModule == null)
                {
                    return new Error { IsError = true, Message = "Module Not Found." };
                }
                else
                {
                    return new Result { IsSucess = true, ResultData = GetModule };
                }
            }
            catch (Exception E)
            {
                return new Error() { IsError = true, Message = E.Message };
            }
        }

    }
}