using SchoolAPI.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolAPI.Models;
using SchoolAPI.ResultModel;

namespace SchoolAPI.BusinessLayer
{
    public class AchievementTypeMasterBL
    {
        SchoolERPContext db = new SchoolERPContext();
        string msg = "";
        public object AddAchievementTypeMaster(AchievementTypeMasterParam obj)
        {
            try
            {
                msg = "";
                var result = db.ViewAchievementTypeMasters.Where(r => r.AchievementType == obj.AchievementType).FirstOrDefault();
                if (result == null)
                {
                    TblAchievementTypeMaster objTbl = new TblAchievementTypeMaster();
                    objTbl.AchievementType = obj.AchievementType;
                    objTbl.CreatedBy = obj.CreatedBy;
                    objTbl.CreatedDate = DateTime.Now;
                    objTbl.Status = 1;
                    db.TblAchievementTypeMasters.Add(objTbl);
                    db.SaveChanges();
                    msg = "Achievement Type Added Successfully!";

                }
                else
                {
                    return new Error() { IsError = true, Message = "Achievement Type Is Already Exists!" };
                }
                return new Result { IsSucess = true, ResultData = msg };
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.ToString() };
            }

        }

        public object UpdateAchievementTypeMaster(AchievementTypeMasterParam obj)
        {
            try
            {
                msg = "";
                var result = db.TblAchievementTypeMasters.Where(r=>r.AchievementType==obj.AchievementType).FirstOrDefault();
                if (result != null)
                {
                    return new Error { IsError=true,Message= "Achievement Type Is Already Exists!" };
                }
                else
                {
                    TblAchievementTypeMaster objTbl = db.TblAchievementTypeMasters.Where(r => r.AchievementTypeID == obj.AchievementTypeID).FirstOrDefault();
                    objTbl.AchievementTypeID = obj.AchievementTypeID;
                    objTbl.AchievementType = obj.AchievementType;
                    objTbl.ModifiedBy = obj.ModifiedBy;
                    objTbl.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    msg = "Achievement Type Updated Successfully!";
                }
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
            return new Result { IsSucess = true, ResultData = msg };
        }

        public object DeleteAchievementTypeMaster(AchievementTypeMasterParam obj)
        {
            try
            {
                TblAchievementTypeMaster result = db.TblAchievementTypeMasters.Where(r => r.AchievementTypeID == obj.AchievementTypeID).FirstOrDefault();

                if (result.Status == 1)
                {
                    result.Status = 0;
                }
                else
                {
                    result.Status = 1;
                }
                db.SaveChanges();
                return new Result { IsSucess = true, ResultData = "Achievement Type Updated Successfully!" };
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }

        public object GetSingleAchievementTypeMaster(AchievementTypeMasterParam obj)
        {
            try
            {
                var result = db.ViewAchievementTypeMasters.Where(r => r.AchievementTypeID == obj.AchievementTypeID).FirstOrDefault();

                return result;

            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }

        public object GetAllAchievementTypeMaster(UserCredential UcOBj)
        {
            try
            {
                List<ViewAchievementTypeMaster> AchievementTypeMasterList = null;
                if (UcOBj.Status == "0")
                {
                    AchievementTypeMasterList = db.ViewAchievementTypeMasters.Where(r => r.Status == 0).ToList();
                }
                else
                {
                    AchievementTypeMasterList = db.ViewAchievementTypeMasters.Where(r => r.Status == 1).ToList();
                }
                if (UcOBj.Status == null)
                {
                    AchievementTypeMasterList = db.ViewAchievementTypeMasters.Where(r => r.Status == 1).ToList();

                }
                if (AchievementTypeMasterList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return AchievementTypeMasterList;
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }
    }
}