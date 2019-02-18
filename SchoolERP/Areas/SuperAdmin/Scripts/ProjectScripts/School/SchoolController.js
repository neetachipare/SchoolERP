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
        debugger;
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
            FeeTemplateId: $scope.FeeTemplateId,
            ExamTemplateId : $scope.ExamTemplateId,
            LoginTemplateId : $scope.LoginTemplateId,
            UserPrefix : $scope.UserPrefix,
            UserName : $scope.UserName,
            Password : $scope.Password,
            BoardId : $scope.BoardId,
            Language : $scope.Language,
            Designation: $scope.Designation,
            EmailId: $scope.EmailId,
            LandlineNo: $scope.LandlineNo

        };

        var payload = new FormData();
        payload.append("data", JSON.stringify(Info));
        payload.append("file1", $scope.Logo);
        payload.append("file", $scope.Banner);     

        Service.PostFile("SchoolMaster/AddSchool",payload).then(function (rd) {
            alert('Hii')
            $scope.IsVisible = false;
            $scope.Visible = true;
            if (rd.data.IsSucess) {
                alert(rd.data.ResultData);
                $scope.Close();
                $scope.Initialize();
               

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
             SchoolId: $scope.SchoolId
        };
        var payload = new FormData();
        payload.append("data", JSON.stringify(Info));
        payload.append("logo", $scope.Logo);
        payload.append("banner", $scope.Banner);

        Service.PostFile("SchoolMaster/UpdateSchool",payload).then(function (rd) {
            alert('Hii')
            $scope.IsVisible = false;
            $scope.Visible = true;
            if (rd.data.IsSucess) {
                alert(rd.data.ResultData);
                $scope.Refresh();


            }

        })

    }
    $scope.GetFee = function () {

        Service.Post("SchoolMaster/FeeTemplateInformation").then(function (result) {
            debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            $scope.tbl_Template = result.data;
            $scope.Fee = result.data.ResultData;
            console.log(result.data);

        })

    }
    $scope.GetLogin = function () {

        Service.Post("SchoolMaster/LoginTemplateInformation").then(function (result) {
            debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            $scope.tbl_Template = result.data;
            $scope.Login = result.data.ResultData;
            console.log(result.data);

        })

    }
    $scope.GetPayroll = function () {

        Service.Post("SchoolMaster/PayrollTemplateInformation").then(function (result) {
            debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            $scope.tbl_Template = result.data;
            $scope.Payroll = result.data.ResultData;
            console.log(result.data);

        })

    }
    $scope.GetExam = function () {

        Service.Post("SchoolMaster/ExamTemplateInformation").then(function (result) {
            debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            $scope.tbl_Template = result.data;
            $scope.Exam = result.data.ResultData;
            console.log(result.data);

        })

    }
    $scope.Clear = function () {

        $scope.IsVisible = false;
        $scope.Visible = true;
        $scope.SchoolName = "";
        $scope.PhoneNo = "";
     $scope.SchoolName="";
     $scope.PhoneNo = "";
     $scope.Address = "";
     $scope.ContactPerson = "";
     $scope.Designation = "";
     $scope.EmailId = "";
     $scope.LandlineNo = "";
     $scope.ValidityStartDate = "";
     $scope.ValidityEndDate = "";
     $scope.PayrollTemplateId = "";
     $scope.FeeTemplateId = "";
     $scope.ExamTemplateId = "";
     $scope.LoginTemplateId = "";
     $scope.UserPrefix = "";
     $scope.UserName = "";
     $scope.Password = "";
     $scope.BoardId = "";
     $scope.Language = "";
     $scope.Logo = "";
     $scope.Banner = "";
     $scope.SchoolId = "";
        $scope.Initialize();
       
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
            $scope.ConPassword = rd.data.ResultData.Password;
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
    $scope.GetLanguage = function () {
        debugger;
        $scope.UserCredentialModel = {};
        Service.Post("SchoolMaster/GetLanguageInfo", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.data = result.data;
            //console.log(result.data);

        })
    }
    $scope.GetBoard = function () {
        //debugger;
        $scope.UserCredentialModel = {};
        Service.Post("SchoolMaster/GetBoardInfo", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.board = result.data;
            //console.log(result.data);

        })
    }
    $scope.Refresh = function () {
        $scope.SchoolName = "";
        $scope.PhoneNo = "";
        $scope.SchoolName = "";
        $scope.PhoneNo = "";
        $scope.Address = "";
        $scope.ContactPerson = "";
        $scope.Designation = "";
        $scope.EmailId = "";
        $scope.LandlineNo = "";
        $scope.ValidityStartDate = "";
        $scope.ValidityEndDate = "";
        $scope.PayrollTemplateId = "";
        $scope.FeeTemplateId = "";
        $scope.ExamTemplateId = "";
        $scope.LoginTemplateId = "";
        $scope.UserPrefix = "";
        $scope.UserName = "";
        $scope.Password = "";
        $scope.BoardId = "";
        $scope.Language = "";
        $scope.Logo = "";
        $scope.Banner = "";
        $scope.SchoolId = "";
        $scope.Initialize();
    }


}
