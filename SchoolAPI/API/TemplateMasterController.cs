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
    public class TemplateMasterController : ApiController
    {

        [HttpGet]
        public object GetTemplateType()
        {
            try
            {
                TemplateMasterBL GT = new TemplateMasterBL();
                var GrType = GT.GetTemplateType();
                return GrType;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpGet]
        public object GetMenu()
        {
            try
            {
                TemplateMasterBL GT = new TemplateMasterBL();
                var GrType = GT.GetMenuList();
                return GrType;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object SaveTemplateMaster([FromBody] TemplateMasterParam PR)
        {
            try
            {
                TemplateMasterBL OBJSAVE = new TemplateMasterBL();
                var result = OBJSAVE.SaveTemplateMaster(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        //public object GetModuleMaster([FromBody]ModuleParam objid)

        public object GetTemplateMaster([FromBody]TemplateMasterParam objid)
        {
            try
            {
                var status = objid.Status;
                TemplateMasterBL obj = new TemplateMasterBL();
                var ERPModule = obj.GetTemplateMasterList(status);
                return ERPModule;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleTemplateMasterInfo([FromBody]TemplateMasterParam OBJGR)
        {
            try
            {
                TemplateMasterBL obj = new TemplateMasterBL();
                var SingleGR = obj.GetSingleTemplateMaster(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }


        [HttpPost]
        public object DeleteTemplateMaster([FromBody] TemplateMasterParam MP)
        {
            try
            {
                TemplateMasterBL obj = new TemplateMasterBL();
                var result = obj.DeleteTemplateMaster(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
    }
}
