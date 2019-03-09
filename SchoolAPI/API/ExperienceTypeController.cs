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
    public class ExperienceTypeController : ApiController
    {
        [HttpPost]
        public object AddExperienceType([FromBody]ExperienceTypeParam obj)
        {
            try
            {
                ExperienceTypeBussiness save = new ExperienceTypeBussiness();
                var result = save.SaveExperienceType(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetExprienceTypeInfo(UserCredential uc)
        {
            try
            {
                ExperienceTypeBussiness data = new ExperienceTypeBussiness();
                var Result = data.GetExprienceType(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleExprienceTypeInfo(ExperienceTypeUpdateParam b)
        {
            try
            {
                ExperienceTypeBussiness type = new ExperienceTypeBussiness();
                var Result = type.GetSingleExprienceType(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateExprienceType(ExperienceTypeUpdateParam b)
        {
            try
            {
                ExperienceTypeBussiness type = new ExperienceTypeBussiness();
                var Result = type.ExprienceTypeUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteExprienceType([FromBody] ExperienceTypeUpdateParam PM)
        {
            try
            {
                ExperienceTypeBussiness b = new ExperienceTypeBussiness();
                var Result = b.DeleteExprienceType(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
