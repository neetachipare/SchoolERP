using SchoolAPI.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolAPI.Models;
using SchoolAPI.ResultModel;

namespace SchoolAPI.BusinessLayer
{
    public class SchoolAchievementDetailsBL
    {
        SchoolAdminContext db = new SchoolAdminContext();
        string msg = "";



        public object GetAllAchievementTypeMaster()
        {
            try
            {
                var AchievementType = db.TblAchievementTypeMasters.Where(R => R.Status == 1).ToList();
                if (AchievementType.Count() == 0)
                {
                    return new Error() { IsError = true, Message = "Achievement Type Not Found." };
                }
                else
                {
                    return new Result() { IsSucess = true, ResultData = AchievementType };
                }
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
        public object GetAllSchoolAchievementDetails(UserCredential UcOBj)
        {
            // inner join of - TblAchievementTypeMaster and TblSchoolAchievementDetails to get AchievementType
            try
            {
                List<ViewSchoolAchievementDetail> ViewSchoolAchievementDetailList = null;
                if (UcOBj.Status == "0")
                {
                    ViewSchoolAchievementDetailList = db.ViewSchoolAchievementDetails.Where(r => r.Status == 0).ToList();
                }
                else
                {
                    ViewSchoolAchievementDetailList = db.ViewSchoolAchievementDetails.Where(r => r.Status == 1).ToList();
                }
                if (UcOBj.Status == null)
                {
                    ViewSchoolAchievementDetailList = db.ViewSchoolAchievementDetails.Where(r => r.Status == 1).ToList();

                }
                if (ViewSchoolAchievementDetailList == null)
                {
                    return new Error() { IsError = true, Message = "No Records Found !!" };
                }
                return ViewSchoolAchievementDetailList;
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
        }

        public object SaveAchievementDetails(SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                var AchievementData = db.TblSchoolAchievementDetails.Where(r => r.Achievement == Pobj.Achievement && r.AchievementTypeID==Pobj.AchievementTypeID).FirstOrDefault();
                if (AchievementData != null)
                {
                    return new Error() { IsError = true, Message = "Achievement Details Already Exists!" };
                }
                TblSchoolAchievementDetail objAchievementDetails = new TblSchoolAchievementDetail();

                objAchievementDetails.Achievement = Pobj.Achievement;
                objAchievementDetails.AchievementTypeID = Pobj.AchievementTypeID;
                objAchievementDetails.Date = Pobj.Date;
                objAchievementDetails.CreatedBy = Pobj.CreatedBy;
                objAchievementDetails.CreatedDate = DateTime.Now;
                objAchievementDetails.Status = 1;
                db.TblSchoolAchievementDetails.Add(objAchievementDetails);
                db.SaveChanges();
                msg = "Achievement Details Saved Successfully";

                return new Result() { IsSucess = true, ResultData = msg };
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }

        public object UpdateAchievementDetails(SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                msg = "";
                var result = db.TblSchoolAchievementDetails.Where(r => r.Achievement == Pobj.Achievement && r.AchievementTypeID==Pobj.AchievementTypeID).FirstOrDefault();
                if (result != null)
                {
                    return new Error { IsError = true, Message = "Achievement Details Already Exists!" };
                }
                else
                {
                    TblSchoolAchievementDetail objTbl = db.TblSchoolAchievementDetails.Where(r => r.AchievementDID == Pobj.AchievementDID).FirstOrDefault();
                    objTbl.AchievementDID = Pobj.AchievementDID;
                    objTbl.AchievementTypeID = Pobj.AchievementTypeID;
                    objTbl.Achievement = Pobj.Achievement;
                    objTbl.Date = Pobj.Date;
                    objTbl.ModifiedBy = Pobj.ModifiedBy;
                    objTbl.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    msg = "Achievement Details Updated Successfully!";
                }
            }
            catch (Exception ex)
            {
                return new Error { IsError = true, Message = ex.Message };
            }
            return new Result { IsSucess = true, ResultData = msg };
        }

        public object DeleteAchievementDetails(SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                TblSchoolAchievementDetail result = db.TblSchoolAchievementDetails.Where(r => r.AchievementDID == Pobj.AchievementDID).FirstOrDefault();

                if (result.Status == 1)
                {
                    result.Status = 0;
                }
                else
                {
                    result.Status = 1;
                }
                db.SaveChanges();
                return new Result { IsSucess = true, ResultData = "Achievement Details Updated Successfully!" };

            }
            catch (Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }

        public object GetSingleAchievementDetails(SchoolAchievementDetailsParam Pobj)
        {
            try
            {
                var result = db.ViewSchoolAchievementDetails.Where(r => r.AchievementDID == Pobj.AchievementDID).FirstOrDefault();
               
                return result;
            }
            catch(Exception ex)
            {
                return new Error { IsError=true,Message=ex.Message};
            }
        }
    }
}