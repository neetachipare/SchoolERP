using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI.Param;
using SchoolAPI.BusinessLayer;
using SchoolAPI.Models;
using SchoolAPI.ResultModel;

namespace SchoolAPI.API
{
    public class StateMasterController : ApiController
    {
        [HttpPost]
        public object AddState([FromBody]StateParam obj)
        {
            try
            {
                StateBusiness save = new StateBusiness();
                var result = save.SaveState(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetStateInfo(UserCredential uc)
        {
            try
            {
                StateBusiness state = new StateBusiness();
                var Result = state.GetState(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleStateInfo(UpdateState b)
        {
            try
            {
                StateBusiness state = new StateBusiness();
                var Result = state.GetSingleState(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateState(UpdateState b)
        {
            try
            {
                StateBusiness state = new StateBusiness();
                var Result = state.StateUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteState([FromBody] UpdateState PM)
        {
            try
            {
                StateBusiness b = new StateBusiness();
                var Result = b.DeleteState(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //District
        [HttpPost]
        public object AddDistrict([FromBody]DistrictParam obj)
        {
            try
            {
                StateBusiness save = new StateBusiness();
                var result = save.SaveDistrict(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetDistrictInfo([FromBody]UserCredential uc)
        {
            try
            {
                StateBusiness district = new StateBusiness();
                var Result = district.GetDistrict(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleDistrictInfo(DistrictParam b)
        {
            try
            {
                StateBusiness district = new StateBusiness();
                var Result = district.GetSingleDistrict(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateDistrict(DistrictParam b)
        {
            try
            {
                StateBusiness district = new StateBusiness();
                var Result = district.DistrictUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteDistrict([FromBody] DistrictParam PM)
        {
            try
            {
                StateBusiness b = new StateBusiness();
                var Result = b.DeleteDistrict(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        //Taluka
        [HttpPost]
        public object AddTaluka([FromBody]TalukaParam obj)
        {
            try
            {
                StateBusiness save = new StateBusiness();
                var result = save.SaveTaluka(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetTalukaInfo(UserCredential uc)
        {
            try
            {
                StateBusiness taluka = new StateBusiness();
                var Result = taluka.GetTaluka(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleTalukaInfo(TalukaParam b)
        {
            try
            {
                StateBusiness taluka = new StateBusiness();
                var Result = taluka.GetSingleTaluka(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateTaluka(TalukaParam b)
        {
            try
            {
                StateBusiness taluka = new StateBusiness();
                var Result = taluka.TalukaUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteTaluka([FromBody] TalukaParam PM)
        {
            try
            {
                StateBusiness b = new StateBusiness();
                var Result = b.DeleteTaluka(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
        //
        [HttpPost]
        public object GetState()
        {
            try
            {
                StateBusiness state = new StateBusiness();
                var Result = state.GetStateInfo();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetStateUnderTaluka([FromBody] TalukaParam d)
        {
            try
            {
                StateBusiness state = new StateBusiness();
                var Result = state.GetStateunderDistrict(d);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
    }
}
