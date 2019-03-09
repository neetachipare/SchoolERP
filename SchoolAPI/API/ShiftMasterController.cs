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
    public class ShiftMasterController : ApiController
    {
        [HttpPost]
        public object AddShift([FromBody] ShiftMasterParam obj)
        {
            try
            {
                ShiftBusiness save = new ShiftBusiness();
                var result = save.SaveShift(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetShiftInfo(UserCredential uc)
        {
            try
            {
                ShiftBusiness data = new ShiftBusiness();
                var Result = data.GetShift(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleShiftInfo(ShiftMasterUpdateParam b)
        {
            try
            {
                ShiftBusiness type = new ShiftBusiness();
                var Result = type.GetSingleShift(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateShift(ShiftMasterUpdateParam b)
        {
            try
            {
                ShiftBusiness type = new ShiftBusiness();
                var Result = type.ShiftUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteShift([FromBody] ShiftMasterUpdateParam PM)
        {
            try
            {
                ShiftBusiness b = new ShiftBusiness();
                var Result = b.DeleteShift(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //Shift Master Details

        [HttpPost]
        public object AddShiftDetails([FromBody] ShiftDetailsParam obj)
        {
            try
            {
                ShiftBusiness save = new ShiftBusiness();
                var result = save.SaveShiftDetails(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetShiftDetailsInfo(UserCredential uc)
        {
            try
            {
                ShiftBusiness data = new ShiftBusiness();
                var Result = data.GetShiftDetails(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleShiftDetailsInfo(ShiftDetailsUpdateParam b)
        {
            try
            {
                ShiftBusiness type = new ShiftBusiness();
                var Result = type.GetSingleShiftDetails(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateShiftDetails(ShiftDetailsUpdateParam b)
        {
            try
            {
                ShiftBusiness type = new ShiftBusiness();
                var Result = type.ShiftDetailsUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteShiftDetails([FromBody] ShiftDetailsUpdateParam PM)
        {
            try
            {
                ShiftBusiness b = new ShiftBusiness();
                var Result = b.DeleteShiftDetails(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

    }
}
