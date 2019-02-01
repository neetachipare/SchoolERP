using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using SchoolAPI.Models;
using _3___DAL;

namespace SchoolAPI.BusinessLayer
{
    public class UserBusiness
    {
        SchoolERPContext db = new SchoolERPContext();
        public object IsValidUser( User user)
        {
            var Password =CryptIt.Encrypt(user.Password);
            var data = db.TblUserLogins.FirstOrDefault(r => r.UserName == user.UserName
                      && r.Password == Password);

            if (data == null)
            {
                return new Error() { IsError = true, Message = "Incorrect User Or Password.." };
            }
            else
            {
                //user.code = Convert.ToInt32(HttpContext.Current.Session["Code"]);
                return new Result() { IsSucess = true, ResultData = user};


            }
           
        }
    }
}