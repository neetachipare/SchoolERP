using SchoolAPI.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI.BusinessLayer;
using SchoolAPI.ResultModel;

namespace SchoolAPI.API
{
    public class TermMasterController : ApiController
    {
        [HttpPost]
        public object AddTerm([FromBody]TermMasterParam obj)
        {
            try
            {
                 TermMasterBussiness save = new TermMasterBussiness();
                var result = save.SaveTerm(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetTermInfo(UserCredential uc)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetTermList(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleTermInfo(TermUpdateParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetSingleTerm(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateTerm(TermUpdateParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.TermUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteTerm([FromBody] TermUpdateParam PM)
        {
            try
            {
                TermMasterBussiness b = new TermMasterBussiness();
                var Result = b.DeleteTerm(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //Unit-Terminal
        [HttpPost]
        public object AddUnit([FromBody]UnitMasterParam obj)
        {
            try
            {
                TermMasterBussiness save = new TermMasterBussiness();
                var result = save.SaveUnit(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetUnitInfo(UserCredential uc)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetUnitList(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleUnitInfo(UpdateUnitParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetSingleUnit(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateUnit(UpdateUnitParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.UnitUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteUnit([FromBody] UpdateUnitParam PM)
        {
            try
            {
                TermMasterBussiness b = new TermMasterBussiness();
                var Result = b.DeleteUnit(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //TermCommencementDate
        [HttpPost]
        public object AddTermCommencement([FromBody]TermCommencementParam obj)
        {
            try
            {
                TermMasterBussiness save = new TermMasterBussiness();
                var result = save.SaveTermCommencement(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetTermCommencementInfo(UserCredential uc)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetTermCommencementList(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleTermCommencementInfo(TermCommencementUpdateParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.GetSingleTermCommencement(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateTermCommencement(TermCommencementUpdateParam b)
        {
            try
            {
                TermMasterBussiness term = new TermMasterBussiness();
                var Result = term.TermCommencementUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteTermCommencement([FromBody] TermCommencementUpdateParam PM)
        {
            try
            {
                TermMasterBussiness b = new TermMasterBussiness();
                var Result = b.DeleteTermCommencement(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
