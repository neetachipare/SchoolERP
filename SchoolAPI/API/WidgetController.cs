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
    public class WidgetController : ApiController
    {
        [HttpPost]
        public object AddWidget([FromBody]WidgetParam obj)
        {
            try
            {
                WidgetBusiness save = new WidgetBusiness();
                var result = save.SaveWidget(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetWidgetInfo(UserCredential uc)
        {
            try
            {
                WidgetBusiness widget = new WidgetBusiness();
                var Result = widget.GetWidget(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleWidgetInfo(WidgetUpdateParam b)
        {
            try
            {
                WidgetBusiness type = new WidgetBusiness();
                var Result = type.GetSingleWidget(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateWidget(WidgetUpdateParam b)
        {
            try
            {
                WidgetBusiness type = new WidgetBusiness();
                var Result = type.WidgetUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteWidget([FromBody] WidgetUpdateParam PM)
        {
            try
            {
                WidgetBusiness b = new WidgetBusiness();
                var Result = b.DeleteWidget(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
