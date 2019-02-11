angular.module('ERP').controller('SchoolController', SchoolController);

function SchoolController($scope, Service) {
    var form = $(".m-form m-form--label-align-left- m-form--state-");
    $scope.School = {};
    $scope.IsVisible = false;
    $scope.Visible = true;
    $scope.btnupdate = false;
    $scope.btnadd = false;
    $scope.isDisabled = false;
    $scope.isenabled = false;
    $scope.isActive = false;
    $scope.Initialize = function () {
        debugger;     
        Data = {
           Status: $scope.btnactive
        }
       
        Service.Post("SchoolMaster/SchoolInformation", JSON.stringify(Data)).then(function (result) {

           
            $scope.ViewGetStudentInfoes = result.data;
            $scope.Students = result.data.ResultData;
            console.log(result.data.ResultData);

        })

    }
    $scope.ShowHide = function () {
        $scope.IsVisible = true;
        $scope.Visible = false;
        $scope.isDisabled = false;
        $scope.isenabled = true;
    }
    $scope.Add = function () {
        //debugger;
        $scope.isDisabled = true;
        $scope.isenabled = false;
        Info = {
            SchoolName : $scope.SchoolName,
            PhoneNo : $scope.PhoneNo,
            Address : $scope.Address,
            ContactPerson : $scope.ContactPerson,
            ValidityStartDate : $scope.ValidityStartDate,
            ValidityEndDate : $scope.ValidityEndDate,
            PayrollTemplateId : $scope.PayrollTemplateId,
            FeeTemplateId : $scope.FeeTemplateId,
            ExamTemplateId : $scope.ExamTemplateId,
            LoginTemplateId : $scope.LoginTemplateId,
            UserPrefix : $scope.UserPrefix,
            UserName : $scope.UserName,
            Password : $scope.Password,
            BoardId : $scope.BoardId,
            Language : $scope.Language,
            Logo : $scope.Logo,
            Banner: $scope.Banner,
            Designation: $scope.Designation,
            EmailId: $scope.EmailId,
            LandlineNo: $scope.LandlineNo

        };
       
        Service.PostFile("SchoolMaster/AddSchool",Info).then(function (rd) {
            alert('Hii')
            if (rd.data.IsSucess) {
                alert('Success')
                $scope.Initialize();
                $scope.Visible = true;

            }

        })

    }
   
   
    $scope.AddUpdate = function () {
        debugger;
        $scope.IsVisible = true;
        $scope.Visible = false;
        Info = {
            SchoolName: $scope.SchoolName,
            PhoneNo: $scope.PhoneNo,
            Address: $scope.Address,
            ContactPerson: $scope.ContactPerson,
            Designation: $scope.Designation,
            EmailId: $scope.EmailId,
            LandlineNo: $scope.LandlineNo,
            ValidityStartDate: $scope.ValidityStartDate,
            ValidityEndDate: $scope.ValidityEndDate,
            PayrollTemplateId: $scope.PayrollTemplateId,
            FeeTemplateId: $scope.FeeTemplateId,
            ExamTemplateId: $scope.ExamTemplateId,
            LoginTemplateId: $scope.LoginTemplateId,
            UserPrefix: $scope.UserPrefix,
            UserName: $scope.UserName,
            Password: $scope.Password,
            BoardId: $scope.BoardId,
            Language: $scope.Language,
            Logo: $scope.Logo,
            Banner: $scope.Banner,
            SchoolId: $scope.SchoolId
        };
       
        Service.Post("SchoolMaster/UpdateSchool", JSON.stringify(Info)).then(function (rd) {
            alert('Hii')
            if (rd.data.IsSucess) {
                alert('Success')
                $scope.Initialize();
                $scope.Visible = true;
            }

        })

    }
    $scope.GetTemplate = function () {

        Service.Post("api/Grievance/GetUnAssignedGrievanceType").then(function (result) {
            debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            $scope.tbl_grievance_list = result.data;
            $scope.Grievance = result.data.ResultData;
            console.log(result.data);

        })

    }
    
    $scope.Verify = function (SchoolId) {
        debugger;    
        
        var data = {

            SchoolId: SchoolId

        };
        Service.Post("SchoolMaster/GetSingleSchool", JSON.stringify(data)).then(function (rd) {
            alert('getsingle')
            debugger;
            $scope.IsVisible = true;
            $scope.Visible = false;
            $scope.isDisabled = true;
            $scope.btnupdate = false;
            $scope.btnadd = false;
            $scope.SchoolInfo = rd.data.ResultData;
            $scope.SchoolName = rd.data.ResultData.SchoolName;
            $scope.SchoolId = rd.data.ResultData.SchoolId;
            $scope.PhoneNo = rd.data.ResultData.PhoneNo;
            $scope.Address = rd.data.ResultData.Address;
            $scope.Designation = rd.data.ResultData.Designation;
            $scope.EmailId = rd.data.ResultData.EmailId;
            $scope.LandlineNo = rd.data.ResultData.LandlineNo;
            $scope.ContactPerson = rd.data.ResultData.ContactPerson;
            $scope.ValidityStartDate = rd.data.ResultData.ValidityStartDate;
            $scope.ValidityEndDate = rd.data.ResultData.ValidityEndDate;
            $scope.PayrollTemplateId = rd.data.ResultData.PayrollTemplateId;
            $scope.FeeTemplateId = rd.data.ResultData.FeeTemplateId;
            $scope.ExamTemplateId = rd.data.ResultData.ExamTemplateId;
            $scope.LoginTemplateId = rd.data.ResultData.LoginTemplateId;
            $scope.UserPrefix = rd.data.ResultData.UserPrefix;
            $scope.UserName = rd.data.ResultData.UserName;
            $scope.Password = rd.data.ResultData.Password;
            $scope.BoardId = rd.data.ResultData.BoardId;
            $scope.Language = rd.data.ResultData.Language;
            $scope.Logo = rd.data.ResultData.Logo;
            $scope.Banner = rd.data.ResultData.Banner;

        })
    }
    $scope.Delete = function (SchoolId) {
        debugger;

        var data = {

            SchoolId: SchoolId

        };
        Service.Post("SchoolMaster/DeleteSchool", JSON.stringify(data)).then(function (rd) {
            $scope.Initialize()
            if (rd.data.IsSucess) {
                alert('Success')
            }
        })

    }
}
