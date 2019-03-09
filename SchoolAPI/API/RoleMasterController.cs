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
    public class RoleMasterController : ApiController
    {
        [HttpPost]
        public object AddRole([FromBody]RoleMasterParam obj)
        {
            try
            {
                RoleMasterBusiness save = new RoleMasterBusiness();
                var result = save.SaveRole(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetRoleInfo(UserCredential uc)
        {
            try
            {
                RoleMasterBusiness role = new RoleMasterBusiness();
                var Result = role.GetRole(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleRoleInfo(RoleMasterUpdateParam b)
        {
            try
            {
                RoleMasterBusiness role = new RoleMasterBusiness();
                var Result = role.GetSingleRole(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateRole(RoleMasterUpdateParam b)
        {
            try
            {
                RoleMasterBusiness role = new RoleMasterBusiness();
                var Result = role.RoleUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteRole([FromBody] RoleMasterUpdateParam PM)
        {
            try
            {
                RoleMasterBusiness b = new RoleMasterBusiness();
                var Result = b.DeleteRole(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
