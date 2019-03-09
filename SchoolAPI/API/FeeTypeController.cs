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
    public class FeeTypeController : ApiController
    {
        [HttpPost]
        public object AddFeeType([FromBody]FeeTypeParam obj)
        {
            try
            {
                FeeTypeBussiness save = new FeeTypeBussiness();
                var result = save.SaveFeeType(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetFeeTypeInfo(UserCredential uc)
        {
            try
            {
                FeeTypeBussiness board = new FeeTypeBussiness();
                var Result = board.GetFeeType(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleFeeTypeInfo(FeeTypeUpdateParam b)
        {
            try
            {
                FeeTypeBussiness type = new FeeTypeBussiness();
                var Result = type.GetSingleFeeType(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateFeeType(FeeTypeUpdateParam b)
        {
            try
            {
                FeeTypeBussiness type = new FeeTypeBussiness();
                var Result = type.FeeTypeUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteFeeType([FromBody] FeeTypeUpdateParam PM)
        {
            try
            {
                FeeTypeBussiness b = new FeeTypeBussiness();
                var Result = b.DeleteFeeType(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
