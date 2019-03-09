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
    public class SMTPController : ApiController
    {
        [HttpPost]
        public object AddSMTP([FromBody]SMTPParam obj)
        {
            try
            {
                SMTPBusiness save = new SMTPBusiness();
                var result = save.SaveSMTP(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetSMTPInfo(UserCredential uc)
        {
            try
            {
                SMTPBusiness smtp = new SMTPBusiness();
                var Result = smtp.GetSMTP(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleSMTPInfo(SMTPUpdatePram b)
        {
            try
            {
                SMTPBusiness smtp = new SMTPBusiness();
                var Result = smtp.GetSingleSMTP(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateSMTP(SMTPUpdatePram b)
        {
            try
            {
                SMTPBusiness smtp = new SMTPBusiness();
                var Result = smtp.SMTPUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteSMTP([FromBody] SMTPUpdatePram PM)
        {
            try
            {
                SMTPBusiness b = new SMTPBusiness();
                var Result = b.DeleteSMTP(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
