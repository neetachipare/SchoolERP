using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolAPI;
using SchoolAPI.Param;
using SchoolAPI.Models;
using SchoolAPI.ResultModel;
using System.Configuration;

namespace SchoolAPI.BusinessLayer
{
    
    public class SchoolBusiness
    {
        SchoolERPContext db = new SchoolERPContext();
        public object SaveSchool(School school)
        {
           
            if (school.UserName == null)
            {
                return new Error() { IsError = true, Message = "Required Username" };
            }

            TblSchool obj = new TblSchool();
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                string UploadBaseUrl = ConfigurationManager.AppSettings["UploadBaseURL"];
                string fileName = string.Empty;
                var filePath = string.Empty;
                string savePath = string.Empty;
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    fileName = postedFile.FileName;
                    filePath = ConfigurationManager.AppSettings["UploadDir"] + Guid.NewGuid() + fileName;
                    savePath = HttpContext.Current.Server.MapPath(filePath); postedFile.SaveAs(savePath);
                    obj.SchoolName = school.SchoolName;
                    obj.PhoneNo = school.PhoneNo;
                    obj.Address = school.Address;
                    obj.ContactPerson = school.ContactPerson;
                    obj.LandlineNo = school.LandlineNo;
                    obj.EmailId = school.EmailId;
                    obj.Designation = school.Designation;
                    obj.ValidityStartDate = school.ValidityStartDate;
                    obj.ValidityEndDate = school.ValidityEndDate;
                    obj.PayrollTemplateId = school.PayrollTemplateId;
                    obj.FeeTemplateId = school.FeeTemplateId;
                    obj.LoginTemplateId = school.LoginTemplateId;
                    obj.ExamTemplateId = school.ExamTemplateId;
                    obj.CreatedBy = 1;
                    obj.CreatedDate = school.CreatedDate;
                    obj.ModifiedBy = 1;
                    obj.ModifiedDate = school.ModifiedDate;
                    obj.UserPrefix = school.UserPrefix;
                    obj.UserName = school.UserName;
                    obj.Password = school.Password;
                    obj.BoardId = school.BoardId;
                    obj.Language = school.Language;
                    obj.Logo = UploadBaseUrl + filePath.Replace("~/", "");
                    obj.Banner = school.Banner;
                    obj.Status = 1;

                    db.TblSchools.Add(obj);
                    db.SaveChanges();
                }
            }
            //user.code = Convert.ToInt32(HttpContext.Current.Session["Code"]);
            return new Result
            {

                IsSucess = true,
                ResultData = "School Created!"
            };



        }
        public object GetSchoolInfo(GetSchool obj)
        {
            //var data = db.TblSchools.Where(r => r.UserName == obj.UserName && r.Password == obj.Password).FirstOrDefault();
            //if(data==null)
            //{
            //    return new Error() { IsError = true, Message = "Please Check UserName or Password" };
            //}
            try
            {
                var schoolid = db.TblSchools.Where(r => r.SchoolId == obj.SchoolId).FirstOrDefault();
                if (schoolid == null)
                {
                    return new Error() { IsError = true, Message = "School  Not Found" };
                }
                else
                {
                    return new Result() { IsSucess = true, ResultData = schoolid };
                }
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }

        public object UpdateSchoolInfo(UpdateSchool school)
        {

            if (school.SchoolName == null)
            {
                return new Error() { IsError = true, Message = "Requird Name" };
            }
            var data = db.TblSchools.FirstOrDefault(r => r.SchoolId == school.SchoolId);
            if(data==null)
            {
                return new Error() { IsError = true, Message = "Check School Name" };

            }
            else
            {
                data.SchoolId = school.SchoolId;
            data.SchoolName = school.SchoolName;
            data.PhoneNo = school.PhoneNo;
            data.Address = school.Address;
            data.ContactPerson = school.ContactPerson;
            data.PayrollTemplateId = school.PayrollTemplateId;
            data.FeeTemplateId = school.FeeTemplateId;
            data.LoginTemplateId = school.LoginTemplateId;
            data.ExamTemplateId = school.ExamTemplateId;
            data.ModifiedBy = 1;
                data.ModifiedDate = System.DateTime.Today.Date;
            data.UserPrefix = school.UserPrefix;
            data.UserName = school.UserName;
            data.Password = school.Password;
            data.BoardId = school.BoardId;
            data.Language = school.Language;
            data.LandlineNo = school.LandlineNo;
            data.EmailId = school.EmailId;
             data.Designation = school.Designation;
            data.Logo = school.Logo;
            data.Banner = school.Banner;
                data.CreatedBy = data.CreatedBy;
                data.CreatedDate = data.CreatedDate;
           // db.TblSchools.Add(data);
            db.SaveChanges();
            return new Result
            {

                IsSucess = true,
                ResultData = "School Updated!"
            };

            }

        }
        public object GetSchool(ActiveParam s)
        {
            try
            {
                List<TblSchool> StudentData = null;
                if (s.Status == "Deactive")
                {
                    StudentData = db.TblSchools.Where(r => r.Status == 0).ToList();
                }
                else
                {
                    StudentData = db.TblSchools.Where(r => r.Status == 1).ToList();
                }

                if (StudentData == null)
                {
                    return new Error { IsError = true, Message = "School List Not Found." };
                }
                else
                {
                    return new Result { IsSucess = true, ResultData = StudentData };
                }
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }
        
        public object GetFeeTemplate()
        {

            var tem = db.View_Template.Where(r => r.TemplateType=="").ToList();
            return new Result() { IsSucess = true, ResultData = tem };

        }
        public object GetPayrollTemplate()
        {
            var tem1 = db.View_Template.Where(r => r.TemplateType == "").ToList();
            return new Result() { IsSucess = true, ResultData = tem1 };

        }
        public object GetLoginTemplate()
        {
            var tem2 = db.View_Template.Where(r => r.TemplateType == "").ToList();
            return new Result() { IsSucess = true, ResultData = tem2 };

        }
        public object GetExamTemplate()
        {
            var tem2 = db.View_Template.Where(r => r.TemplateType == "").ToList();
            return new Result() { IsSucess = true, ResultData = tem2 };

        }
        public object Delete(UpdateSchool s)
        {
            try
            {
                TblSchool objuser = db.TblSchools.Where(r => r.SchoolId == s.SchoolId).FirstOrDefault();
                if (objuser.Status == 1)
                {
                    objuser.Status = 0;
                }
                else
                {
                    objuser.Status = 1;
                }
                db.SaveChanges();
                return new Result() { IsSucess = true, ResultData = "Deactivted" };

            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

    }
}