using SchoolAPI.BusinessLayer;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolAPI.API
{
    public class ModuleController : ApiController
    {
        [HttpPost]
        public object SaveModule([FromBody] ModuleParam PR)
        {
            try
            {
                CreateModuleBL OBJSAVE = new CreateModuleBL();
                var result = OBJSAVE.SaveModule(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        //public object GetModuleMaster([FromBody]ModuleParam objid)

        public object GetModuleMaster([FromBody]ModuleParam objid)
        {
            try
            {
                //var status = objid.Status;
                CreateModuleBL obj = new CreateModuleBL();
                var ERPModule = obj.GetModuleList(1);
                return ERPModule;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

    }
}
