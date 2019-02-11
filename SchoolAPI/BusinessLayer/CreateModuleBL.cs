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
                string msg = "";
                if (MP.BtnStatus == "Save")
                {
                    var usercode = db.TblModuleMasters.Where(r => r.ModuleName == MP.ModuleName.ToUpper()).FirstOrDefault();
                    if (usercode != null)
                    {
                        return new Error() { IsError = true, Message = "Module Name Already Exists!" };
                    }
                    TblModuleMaster objModule = new TblModuleMaster();

                    objModule.ModuleName = MP.ModuleName.ToUpper();
                    objModule.ModuleOrder = MP.ModuleOrder;
                    objModule.CreatedBy = MP.CreatedBy;
                    objModule.CreatedDate = DateTime.Now;
                    objModule.ParentModuleId = 0;
                    objModule.Status =1;
                    db.TblModuleMasters.Add(objModule);
                    db.SaveChanges();
                    msg = "Module Saved Successfully!";
                   
                }
                else
                {
                    TblModuleMaster objModule = db.TblModuleMasters.Where(r => r.ModuleId == MP.ModuleId).FirstOrDefault();

                    objModule.ModuleName = MP.ModuleName.ToUpper();
                    objModule.ModuleOrder = MP.ModuleOrder;
                    objModule.ModifiedDate = DateTime.Now;
                    objModule.ModuleId = MP.ModuleId;
                    db.SaveChanges();
                    msg = "Module Updated Successfully!";
                }

                return new Result() { IsSucess = true, ResultData = msg };


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

        public object GetSingleModule(ModuleParam objgr)
        {
            try
            {
                var SingleModulelist = db.ViewModuleMasters.Where(r => r.ModuleId == objgr.ModuleId).FirstOrDefault();
                return SingleModulelist;
            }
            catch (Exception E)
            {
                return new Error() { IsError = true, Message = E.Message };
            }
        }

        public object DeleteModule(ModuleParam MP)
        {
            try
            {
                TblModuleMaster objmodule = db.TblModuleMasters.Where(r => r.ModuleId == MP.ModuleId).FirstOrDefault();

                if (objmodule.Status == 1)
                {
                    objmodule.Status = 0;
                }
                else
                {
                    objmodule.Status = 1;
                }

                db.SaveChanges();

                return new Result() { IsSucess = true, ResultData = "Module Updated Successfully!" };
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }


    }
}