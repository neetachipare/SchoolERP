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
    public class TemplateTypeController : ApiController
    {
        [HttpPost]
        public object SaveTemplateType([FromBody] TemplateTypeParam PR)
        {
            try
            {
                TemplateTypeBL OBJSAVE = new TemplateTypeBL();
                var result = OBJSAVE.SaveTemplateType(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        //public object GetModuleMaster([FromBody]ModuleParam objid)

        public object GetTemplateTypeMaster([FromBody]TemplateTypeParam objid)
        {
            try
            {
                var status = objid.Status;
                TemplateTypeBL obj = new TemplateTypeBL();
                var ERPModule = obj.GetTemplateTypeList(status);
                return ERPModule;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleTemplateTypeInfo([FromBody]TemplateTypeParam OBJGR)
        {
            try
            {
                TemplateTypeBL obj = new TemplateTypeBL();
                var SingleGR = obj.GetSingleTemplateType(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }


        [HttpPost]
        public object DeleteTemplateType([FromBody] TemplateTypeParam MP)
        {
            try
            {
                TemplateTypeBL obj = new TemplateTypeBL();
                var result = obj.DeleteTemplateType(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
    }
}
