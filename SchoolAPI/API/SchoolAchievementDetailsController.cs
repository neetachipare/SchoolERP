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
    public class SchoolAchievementDetailsController : ApiController
    {
        [HttpGet]
        public object GetAllAchievementTypeMaster()
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.GetAllAchievementTypeMaster();
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
       
        [HttpPost]
        public object GetAllSchoolAchievementDetails(UserCredential UcOBj)
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.GetAllSchoolAchievementDetails(UcOBj);
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }

        [HttpPost]
        public object SaveAchievementDetails([FromBody] SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.SaveAchievementDetails(Pobj);
                return result;
            }
            catch (Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message}; 

            }
        }

        

        [HttpPost]
        public object UpdateAchievementDetails([FromBody] SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.UpdateAchievementDetails(Pobj);
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }
        [HttpPost]
        public object DeleteAchievementDetails([FromBody] SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.DeleteAchievementDetails(Pobj);
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
               
        }
        [HttpPost]
        public object GetSingleAchievementDetails([FromBody] SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                SchoolAchievementDetailsBL ObjBL = new SchoolAchievementDetailsBL();
                var result = ObjBL.GetSingleAchievementDetails(Pobj);
                return result;

            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }
    }
}
