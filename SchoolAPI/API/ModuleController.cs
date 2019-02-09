using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI.BusinessLayer;
using SchoolAPI.Param;
using SchoolAPI.Param.SchoolAPI.Param;
using SchoolAPI.ResultModel;

namespace SchoolAPI.API
{
    public class ModuleController : ApiController
    {
        [HttpPost]
        public object SaveUpdate([FromBody] ModuleParam PM)
        {
            try
            {
                ModuleMasterBL MB = new ModuleMasterBL();
                var Result = MB.SaveMenu(PM);
                return Result;
            }
            catch(Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

       

        [HttpPost]
        public object DeleteMenu([FromBody] ModuleParam PM)
        {
            try
            {
                ModuleMasterBL MB = new ModuleMasterBL();
                var Result = MB.DeleteMenu(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object GetAllMenu(UserCredential UC)
        {
            try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetAllMenus(UC);
                return result;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

       

         [HttpPost]
        public object GetMenuModuleName()
        {
            try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetModuleNames();
                return result;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetChildMenuNames()
        {
            try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetChildMenu();
                return result;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetMenuUnderModule([FromBody] ModuleParam P)
        {
            try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetModuleWiseMenu(P);
                return result;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleMenu([FromBody]ModuleParam MP)
        {
            try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetSingleMenuBL(MP);
                return result;
            }
            catch(Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };

            }

        }

        [HttpPost]
        public object GetChildMenuName([FromBody]ModuleParam M)
        {
        try
            {
                ModuleMasterBL obj = new ModuleMasterBL();
                var result = obj.GetMenuNames(M);
                return result;
            }
            catch(Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }


    }
}
