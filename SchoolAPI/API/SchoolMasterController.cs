using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI;
using System.Data.SqlClient;
using SchoolAPI.Param;
using SchoolAPI.BusinessLayer;
using SchoolAPI.ResultModel;

namespace SchoolAPI.API
{
    public class SchoolMasterController : ApiController
    {
        SchoolERPContext db = new SchoolERPContext();

        [HttpPost]
        public object AddSchool([FromBody]School obj)
        {
            try
            {
                    SchoolBusiness save = new SchoolBusiness();
                var result = save.SaveSchool(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetSingleSchool(GetSchool obj)
        {
            try
            {
                SchoolBusiness getinfo = new SchoolBusiness();
                var result = getinfo.GetSchoolInfo(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object SchoolInformation(ActiveParam obj)
        {
            try
            {
                SchoolBusiness getinfo = new SchoolBusiness();
                var result = getinfo.GetSchool(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object DeleteSchool([FromBody] UpdateSchool PR)
        {
            try
            {
                SchoolBusiness Objdelete = new SchoolBusiness();
                var result = Objdelete.Delete(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateSchool(UpdateSchool obj)
        {
            try
            {
                SchoolBusiness update = new SchoolBusiness();
                var result = update.UpdateSchoolInfo(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object FeeTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetFeeTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object PayrollTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetPayrollTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object LoginTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetLoginTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object ExamTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetExamTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
    }
}
