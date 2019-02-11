using SchoolAPI.Models;
using SchoolAPI.Param;
using SchoolAPI.Param.SchoolAPI.Param;
using SchoolAPI.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.BusinessLayer
{
    public class ModuleMasterBL
    {
        SchoolERPContext db = new SchoolERPContext();
        public object SaveMenu(ModuleParam PM)
        {
            try
            {

                if (PM.BtnStatus == "Save")
                {
                    if (PM.ModuleName == null)
                    {
                        return new Error() { IsError = true, Message = "Please Enter Menu Name !!" };
                    }
                   
                    TblModuleMaster objuser = new TblModuleMaster();
                    var result = db.TblModuleMasters.FirstOrDefault(r => r.ModuleName == PM.ModuleName.ToUpper());
                    if (result != null)
                    {
                        return new Error() { IsError = true, Message = "Menu with Same Name Already Exists !!" };
                    }

                    if (PM.ParentMenuId == 0)
                    {
                        objuser.ParentModuleId = PM.ModuleId;
                    }
                    else
                    {
                        objuser.ParentModuleId = PM.ParentMenuId;
                    }
                        objuser.ModuleName = PM.ModuleName.ToUpper();
                        objuser.ModuleOrder = Convert.ToInt64(PM.ModuleOrder);
                        objuser.Status = 1;
                        objuser.ActionName = PM.ActionName;
                        objuser.CreatedDate = DateTime.Now;                      
                 
                    
                        db.TblModuleMasters.Add(objuser);
                    db.SaveChanges();

                    return new Result() { IsSucess = true, ResultData = "Menu Added Successfully." };

                }

                else
                {
                    TblModuleMaster obGR = db.TblModuleMasters.Where(r => r.ModuleId == PM.ModuleId).FirstOrDefault();

                    obGR.ModuleName = PM.ModuleName;
                    obGR.ParentModuleId = PM.ParentMenuId;                  
                    obGR.ModuleOrder = Convert.ToInt64(PM.ModuleOrder);
                    obGR.ActionName = PM.ActionName;
                    obGR.ModifiedBy = PM.ModifiedBy;
                    obGR.ModifiedDate = DateTime.Now;
                    db.SaveChanges();

                    return new Result() { IsSucess = true, ResultData = "Menu Updated Successfully." };

                }

            }
            catch(Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }

        public object GetSingleMenuBL(ModuleParam Param)
        {
            try
            {
                var res = db.TblModuleMasters.Where(r => r.ModuleId == Param.ModuleId).FirstOrDefault();
                if(res==null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };

                }
                return res;
            }
            catch(Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }

        public object DeleteMenu(ModuleParam PM)
        {
            try
            {


                TblModuleMaster obGR = db.TblModuleMasters.Where(r => r.ModuleId == PM.ModuleId).FirstOrDefault();

                
               if(obGR.Status==1)
                {
                    obGR.Status = 0;
                }
               else
                {
                    obGR.Status = 1;
                }

                db.SaveChanges();

                return new Result() { IsSucess = true, ResultData = "Menu Deactivated Successfully." };
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }

        public object GetAllMenus(UserCredential obj)
        {
            try
            {
                List<View_MenuList> MenuList = null;

                if (obj.Status == "0")
                {
                     MenuList = db.View_MenuList.Where(r=>r.Status==0).ToList();
                }
                else
                {

                    MenuList = db.View_MenuList.Where(r => r.Status == 1).ToList();

                }
                if (obj.Status==null)
                {
                    MenuList = db.View_MenuList.Where(r => r.Status == 1).ToList();

                }
                
                if (MenuList==null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return MenuList;

            }
            catch(Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }

        public object GetMenuNames(ModuleParam obj)
        {
            try
            {
                /// ParentModuleId=0 is Module.Hence the menus do not have parentid=0
                var MenuList = db.TblModuleMasters.Where(r => r.Status == 1 && r.ParentModuleId==obj.ParentMenuId).ToList();
                if (MenuList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return MenuList;

            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }

        public object GetChildMenu()
        {
            try
            {
                /// ParentModuleId=0 is Module.Hence the menus do not have parentid=0
                var MenuList = db.TblModuleMasters.Where(r => r.Status == 1 && r.ParentModuleId !=0 ).ToList();
                if (MenuList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return MenuList;

            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }

        public object GetModuleWiseMenu(ModuleParam obj)
        {
            try
            {
                /// ParentModuleId=0 is Module.Hence the menus do not have parentid=0
                var MenuList = db.TblModuleMasters.Where(r => r.Status == 1 && r.ParentModuleId == obj.ParentMenuId ).ToList();
                if (MenuList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return MenuList;

            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }

        public object GetModuleNames()
        {
            try
            {
                /// ParentModuleId=0 is Module.Hence Only Modules
                var MenuList = db.TblModuleMasters.Where(r => r.Status == 1 && r.ParentModuleId == 0).ToList();
                if (MenuList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return MenuList;

            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
    }
}