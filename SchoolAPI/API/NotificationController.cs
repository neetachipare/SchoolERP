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
    public class NotificationController : ApiController
    {
        [HttpPost]
        public object AddNotificationType([FromBody]NotificationTypeParam obj)
        {
            try
            {
                NotificationBusiness save = new NotificationBusiness();
                var result = save.SaveNotificationType(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetNotificationTypeInfo(UserCredential uc)
        {
            try
            {
                NotificationBusiness events = new NotificationBusiness();
                var Result = events.GetNotificationType(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleNotificationTypeInfo(NotificationTypeUpdateParam b)
        {
            try
            {
                NotificationBusiness type = new NotificationBusiness();
                var Result = type.GetSingleNotificationType(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateNotificationType(NotificationTypeUpdateParam b)
        {
            try
            {
                NotificationBusiness type = new NotificationBusiness();
                var Result = type.NotificationTypeUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteNotificationType([FromBody] NotificationTypeUpdateParam PM)
        {
            try
            {
                NotificationBusiness b = new NotificationBusiness();
                var Result = b.DeleteNotificationType(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
