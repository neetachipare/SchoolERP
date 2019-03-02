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
    public class CasteController : ApiController
    {
        [HttpPost]
        public object GetReligion()
        {
            try
            {
                CasteBL cb = new CasteBL();
                var GrType = cb.GetReligion();
                return GrType;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object GetCategory()
        {
            try
            {
                CasteBL cb = new CasteBL();
                var GrType = cb.GetCategory();
                return GrType;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object GetCaste()
        {
            try
            {
                CasteBL cb = new CasteBL();
                var castelist = cb.GetCaste();
                return castelist;
            }
            catch(Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetReligionMaster([FromBody]ReligionParam objid)
        {
            try
            {
                var status = objid.Status;
                CasteBL obj = new CasteBL();
                var ERPreligion = obj.GetReligionList(status);
                return ERPreligion;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetCategoryMaster([FromBody]CategoryParam objid)
        {
            try
            {
                var status = objid.Status;
                CasteBL obj = new CasteBL();
                var ERPCategory = obj.GetCategoryList(status);
                return ERPCategory;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetMinorityMaster([FromBody]MinorityParam objid)
        {
            try
            {
                var status = objid.Status;
                CasteBL obj = new CasteBL();
                var ERPMinority = obj.GetMinorityList(status);
                return ERPMinority;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetCasteMaster([FromBody]CasteParam objid)
        {
            try
            {
                var status = objid.Status;
                CasteBL obj = new CasteBL();
                var ERPCaste = obj.GetCasteList(status);
                return ERPCaste;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSubCasteMaster([FromBody]SubCasteParam objid)
        {
            try
            {
                var status = objid.Status;
                CasteBL obj = new CasteBL();
                var ERPSubCaste = obj.GetSubCasteList(status);
                return ERPSubCaste;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleReligionInfo([FromBody]ReligionParam OBJGR)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var SingleGR = obj.GetSingleReligion(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleCategoryInfo([FromBody]CategoryParam OBJGR)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var SingleGR = obj.GetSingleCategory(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleMinorityInfo([FromBody]MinorityParam OBJGR)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var SingleGR = obj.GetSingleMinority(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleCasteInfo([FromBody]CasteParam OBJGR)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var SingleGR = obj.GetSingleCaste(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        [HttpPost]
        public object GetSingleSubCasteInfo([FromBody]SubCasteParam OBJGR)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var SingleGR = obj.GetSingleSubCaste(OBJGR);
                return SingleGR;
            }
            catch (Exception ex)
            {
                return new Error() { IsError = true, Message = ex.Message };
            }
        }

        public object SaveReligion([FromBody] ReligionParam PR)
        {
            try
            {
                CasteBL OBJSAVE = new CasteBL();
                var result = OBJSAVE.SaveReligion(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        public object SaveCategory([FromBody] CategoryParam PR)
        {
            try
            {
                CasteBL OBJSAVE = new CasteBL();
                var result = OBJSAVE.SaveCategory(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        public object SaveMinority([FromBody] MinorityParam PR)
        {
            try
            {
                CasteBL OBJSAVE = new CasteBL();
                var result = OBJSAVE.SaveMinority(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        public object SaveCaste([FromBody] CasteParam PR)
        {
            try
            {
                CasteBL OBJSAVE = new CasteBL();
                var result = OBJSAVE.SaveCaste(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        public object SaveSubCaste([FromBody] SubCasteParam PR)
        {
            try
            {
                CasteBL OBJSAVE = new CasteBL();
                var result = OBJSAVE.SaveSubCaste(PR);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object DeleteReligion([FromBody] ReligionParam MP)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var result = obj.DeleteReligion(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object DeleteCategory([FromBody] CategoryParam MP)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var result = obj.DeleteCategory(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object DeleteMinority([FromBody] MinorityParam MP)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var result = obj.DeleteMinority(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object DeleteCaste([FromBody] CasteParam MP)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var result = obj.DeleteCaste(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }

        [HttpPost]
        public object DeleteSubCaste([FromBody] SubCasteParam MP)
        {
            try
            {
                CasteBL obj = new CasteBL();
                var result = obj.DeleteSubCaste(MP);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
