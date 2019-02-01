using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using SchoolAPI.BusinessLayer;
using _3___DAL;

namespace SchoolAPI.Controllers
{
    public class LoginController : ApiController
    {
       
        [HttpPost]
        public object ValidateUserLogin(User user)
        {
            try
            {
                UserBusiness Validuser = new UserBusiness();
                var result = Validuser.IsValidUser(user);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object ForgetPassword(ForgetPassword obj)
        {
            //if (obj.ContactNumber == null)
            //{
            //    return new Error() { IsError = true, Message = "Contact Number Required" };
            //}
            //SchoolERPContext db = new SchoolERPContext();
            //string res = "";
            //var user = db.TblUserLogins.Where(r => 9156779856 == obj.ContactNumber).FirstOrDefault();
            //if (user == null)
            //{
            //    return new Error() { IsError = true, Message = "Contact Number Not Found" };
            //}
            //if (user.name.Length > 0)
            //{
            //    res = "Dear <b>" + user.name + "</b> your User Name is <b>" + user.name + "</b> and Password is <b>" +user.password + "</b>.";

            //}
            //else
            //{
            //    res = "Sorry we didn't find you in our system.";
            //    return res;
            //}
            //try
            //{
            //    Email objemail = new Email();
            //    bool IsDelete;
            //    if (user.email.Length > 0)
            //    {
            //        //IsDelete = objSMS.SMSSend(MobNo, res);
            //        IsDelete = objemail.SendEmail(user.email, res, "Forgot Password", "", "", "", "");
            //        res = "User Name and Password Is Send On Your Registred Email ID. ";
            //    }
            //    else
            //    {
            //        res = "Sorry we didn't find your Email ID in our system.";
            //    }
            //    return res;
            //}
            //catch (Exception e)
            //{
            //    return new Error() { IsError = true, Message = e.Message };

            //}
            return null;

        }
    }
}
