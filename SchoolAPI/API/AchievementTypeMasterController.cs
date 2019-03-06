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
    public class AchievementTypeMasterController : ApiController
    {
        AchievementTypeMasterBL ObjBL = new AchievementTypeMasterBL();

        [HttpPost]
        public object AddAchievementTypeMaster([FromBody]AchievementTypeMasterParam obj)
        {
            try
            {
                var result = ObjBL.AddAchievementTypeMaster(obj);
                return result;
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object UpdateAchievementTypeMaster([FromBody]AchievementTypeMasterParam obj)
        {
            try
            {
                var result = ObjBL.UpdateAchievementTypeMaster(obj);
                return result;
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }

        }

        [HttpPost]
        public object DeleteAchievementTypeMaster([FromBody]AchievementTypeMasterParam obj)
        {
            try
            {
                var result = ObjBL.DeleteAchievementTypeMaster(obj);
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }

        }

        [HttpPost]
        public object GetSingleAchievementTypeMaster([FromBody]AchievementTypeMasterParam obj)
        {
            try
            {
                var result = ObjBL.GetSingleAchievementTypeMaster(obj);
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }
        [HttpPost]
        public object GetAllAchievementTypeMaster(UserCredential UcOBj)
        {
            try
            {
                var result = ObjBL.GetAllAchievementTypeMaster(UcOBj);
                return result;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }
    }
}
