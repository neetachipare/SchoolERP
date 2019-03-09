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
    public class EventMasterController : ApiController
    {
        //Event Type
        [HttpPost]
        public object AddEventType([FromBody]EventTypeParam obj)
        {
            try
            {
                EventTypeBusiness save = new EventTypeBusiness();
                var result = save.SaveEventType(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetEventTypeInfo(UserCredential uc)
        {
            try
            {
                EventTypeBusiness events = new EventTypeBusiness();
                var Result = events.GetEventType(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleEventTypeInfo(EventTypeUpdateParam b)
        {
            try
            {
                EventTypeBusiness type = new EventTypeBusiness();
                var Result = type.GetSingleEventType(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateEventType(EventTypeUpdateParam b)
        {
            try
            {
                EventTypeBusiness type = new EventTypeBusiness();
                var Result = type.EventTypeUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteEventType([FromBody] EventTypeUpdateParam PM)
        {
            try
            {
                EventTypeBusiness b = new EventTypeBusiness();
                var Result = b.DeleteEventType(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //Event Master
        [HttpPost]
        public object AddEvent([FromBody]EventMasterParam obj)
        {
            try
            {
                EventTypeBusiness save = new EventTypeBusiness();
                var result = save.SaveEvent(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetEventInfo(UserCredential uc)
        {
            try
            {
                EventTypeBusiness events = new EventTypeBusiness();
                var Result = events.GetEvent(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleEventInfo(EventMasterUpdateParam b)
        {
            try
            {
                EventTypeBusiness type = new EventTypeBusiness();
                var Result = type.GetSingleEvent(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateEvent(EventMasterUpdateParam b)
        {
            try
            {
                EventTypeBusiness type = new EventTypeBusiness();
                var Result = type.EventUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteEvent([FromBody] EventMasterUpdateParam PM)
        {
            try
            {
                EventTypeBusiness b = new EventTypeBusiness();
                var Result = b.DeleteEvent(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

    }
}
