using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI;
using System.Data.SqlClient;
using SchoolAPI.Param;
using SchoolAPI.BusinessLayer;
using SchoolAPI.ResultModel;
using System.Web;
using Newtonsoft.Json;
using System.IO;

namespace SchoolAPI.API
{
    public class SchoolMasterController : ApiController
    {
        SchoolERPContext db = new SchoolERPContext();

        [HttpPost]
        public object AddSchool()
        {
            try
            {
                School school = new School();
                SchoolBusiness save = new SchoolBusiness();
                var result = save.SaveSchool(school);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetSingleSchool(GetSchool obj)
        {
            try
            {
                SchoolBusiness getinfo = new SchoolBusiness();
                var result = getinfo.GetSchoolInfo(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object SchoolInformation(ActiveParam obj)
        {
            try
            {
                SchoolBusiness getinfo = new SchoolBusiness();
                var result = getinfo.GetSchool(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object DeleteSchool([FromBody] UpdateSchool PR)
        {
            try
            {
                SchoolBusiness Objdelete = new SchoolBusiness();
                var result = Objdelete.Delete(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateSchool(UpdateSchool obj)
        {
            try
            {
                SchoolBusiness update = new SchoolBusiness();
                var result = update.UpdateSchoolInfo(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }
        }
        [HttpPost]
        public object FeeTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetFeeTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object PayrollTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetPayrollTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object LoginTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetLoginTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object ExamTemplateInformation()
        {
            try
            {
                SchoolBusiness template = new SchoolBusiness();
                var Result = template.GetExamTemplate();

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }

        [HttpPost]
        public object AddBoard([FromBody]BoardParam obj)
        {
            try
            {
                SchoolBusiness save = new SchoolBusiness();
                var result = save.SaveBoard(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetBoardInfo(UserCredential uc)
        {
            try
            {
                SchoolBusiness board = new SchoolBusiness();
                var Result = board.GetBoard(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleBoardInfo(BoardParam b)
        {
            try
            {
                SchoolBusiness board = new SchoolBusiness();
                var Result = board.GetSingleBoard(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateBoard(BoardParam b)
        {
            try
            {
                SchoolBusiness board = new SchoolBusiness();
                var Result = board.BoardUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteBoard([FromBody] BoardParam PM)
        {
            try
            {
                SchoolBusiness b = new SchoolBusiness();
                var Result = b.DeleteBoard(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object AddLanguage([FromBody]LanguageParam obj)
        {
            try
            {
                SchoolBusiness save = new SchoolBusiness();
                var result = save.SaveLanguage(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetLanguageInfo(UserCredential uc)
        {
            try
            {
                SchoolBusiness language = new SchoolBusiness();
                var Result = language.GetLanguage(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleLanuageInfo(LanguageParam b)
        {
            try
            {
                SchoolBusiness language = new SchoolBusiness();
                var Result = language.GetSingleLanguage(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateLanguage(LanguageParam b)
        {
            try
            {
                SchoolBusiness board = new SchoolBusiness();
                var Result = board.LanguageUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteLanguage([FromBody] LanguageParam PM)
        {
            try
            {
                SchoolBusiness b = new SchoolBusiness();
                var Result = b.DeleteLanguage(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

    }
}
