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
    public class AcademicYearController : ApiController
    {
        [HttpPost]
        public object AddAcademic([FromBody]AcademicParam obj)
        {
            try
            {
                AcademicYearBussiness save = new AcademicYearBussiness();
                var result = save.SaveAcademic(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetAcademicYearInfo(UserCredential uc)
        {
            try
            {
                AcademicYearBussiness year = new AcademicYearBussiness();
                var Result = year.GetAcademicList(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleAcademicInfo(UpdateAcademicYear b)
        {
            try
            {
                AcademicYearBussiness data = new AcademicYearBussiness();
                var Result = data.GetSingleYear(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateAcademic(UpdateAcademicYear b)
        {
            try
            {
                AcademicYearBussiness data = new AcademicYearBussiness();
                var Result = data.AcademicUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteAcademic([FromBody] UpdateAcademicYear PM)
        {
            try
            {
                AcademicYearBussiness b = new AcademicYearBussiness();
                var Result = b.DeleteAcademic(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
