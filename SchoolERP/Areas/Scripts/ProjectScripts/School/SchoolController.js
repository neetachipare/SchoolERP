angular.module('ERP').controller('SchoolController', SchoolController);

function SchoolController($scope, Service) {
    var form = $(".m-form m-form--label-align-left- m-form--state-");
    $scope.School = {};
    $scope.IsVisible = false;
    $scope.Visible = true;
    $scope.btnupdate = true;
    $scope.btnsave = true;
   
    $scope.isActive = false;
    $scope.passwordvisible = true;
    $scope.div = true;
    $scope.Initialize = function () {
        debugger;  
        
        Data = {
           Status: $scope.btnactive
        }
       
        Service.Post("SchoolMaster/SchoolInformation", JSON.stringify(Data)).then(function (result) {
            debugger; 
            $scope.lstt = [];
            var data = result.data.ResultData;
            $scope.Students = result.data.ResultData;

                return false;
            
            //console.log(result.data.ResultData);

        })

    }
    $scope.ShowHide = function () {
        $scope.IsVisible = true;
        $scope.Visible = false;
        $scope.btnupdate = true;
        $scope.btnsave = false;
    }
    //$scope.board = function ()
    //{
    //    debugger;
    //    var tempArray = {};

    //    for (var i = 0; i < board.length; i++) {
    //        if (data[i].checked) tempArray.push(data[i]);
    //    }
    //    return tempArray; 
       
    //}




    $scope.Add = function () {
        debugger;
        $scope.lst = [];
        for (var i = 0; i < $scope.board.length; i++) {
            if ($scope.board[i].Selected) {
                var fruitId = $scope.board[i].BoardId;
                alert(fruitId);
                $scope.lst.push(fruitId);
            }
        }
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
            //BoardId: $scope.lst,
            Language: $scope.Language,
            Designation: $scope.Designation,
            EmailId: $scope.EmailId,
            LandlineNo: $scope.LandlineNo

        };
        debugger;

       
        var payload = new FormData();
        payload.append("id", JSON.stringify($scope.lst));
        payload.append("data", JSON.stringify(Info));
        payload.append("file1", $scope.Logo);
        payload.append("file", $scope.Banner);     

        Service.PostFile("SchoolMaster/AddSchool",payload).then(function (rd) {
            alert('Hii')
            $scope.IsVisible = false;
            $scope.Visible = true;
            if (rd.data.IsSucess) {
                alert(rd.data.ResultData);
                $scope.Clear();
                $scope.Initialize();
               

            }

        })

    }

    $scope.lstt = [];
    $scope.change = function (s, active) {
        debugger;
        if (active) {
            $scope.lstt.push(s);
            //$scope.checkID(s);
        }
        else {
            $scope.lstt.splice($scope.lstt.indexOf(s), 1);
        }
       
    };

   
    $scope.AddUpdate = function () {
        debugger;
        $scope.IsVisible = true;
        $scope.Visible = false;
        $scope.lstid = [];
        for (var i = 0; i < $scope.board.length; i++) {
            if ($scope.board[i].Selected) {
                var id = $scope.board[i].BoardId;
                alert(id);
                $scope.lstid.push(id);
                
            }
            
        }
        //if (i === 0) {
        //    $scope.lst = [0];
        //}
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
            //BoardId: $scope.BoardId,
            Language: $scope.Language,
             SchoolId: $scope.SchoolId
        };
        var payload = new FormData();
        payload.append("id", JSON.stringify($scope.lstid));
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
                $scope.reloadRoute();


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
        debugger;
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
        //$scope.reloadRoute();

    }
   
    $scope.Verify = function (SchoolId) {
        debugger;    
        $scope.Initialize();
        var data = {

            SchoolId: SchoolId
            //BoardId: BoardId
        };
        Service.Post("SchoolMaster/GetSingleSchool", JSON.stringify(data)).then(function (rd) {
            alert('getsingle')
            debugger;
            $scope.IsVisible = true;
            $scope.Visible = false;
            $scope.isDisabled = true;
            $scope.btnupdate = false;
            $scope.btnsave = true;
            $scope.passwordvisible = false;
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
            $scope.BoardID = rd.data.ResultData.BoardID;
            $scope.BoardName = rd.data.ResultData.BoardName;
            $scope.Language = rd.data.ResultData.Language;
            $scope.Logo = rd.data.ResultData.Logo;
            $scope.Banner = rd.data.ResultData.Banner;
            //$scope.lst = [];
            //for (var i = 0; i < $scope.BoardID.length; i++) {
            //    var id = $scope.BoardID[i];
            //    $scope.BoardID[i].Selected;

            //    $scope.lst.push(id);
            //    if (id === ",")
            //    {
            //        id = 0;
            //    }
            //    else {
            //        $scope.checkID(id);
            //    }
               

            //}
            debugger;
            //$scope.boardidarray = [];
            $scope.boardidarray= $scope.BoardID.split(',');
            for (var i = 0; i < $scope.boardidarray.length; i++) {
                $scope.change($scope.boardidarray[i], true);
                //$scope.checkID($scope.boardidarray[i]);
                //if ($scope.board["BoardId"] === $scope.boardidarray[i][""])
                //{
                //    alert("Hiiiye");
                //    $scope.checkID(BoardId)=true;
                //}
                //$scope.checkID($scope.boardidarray[i]);
            }
            
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
        $scope.reloadRoute();
    }

    $scope.reloadRoute = function () {
        debugger; 
       
        
    }

    $scope.checkID = function (BoardId) {
        debugger;
        if ($scope.boardidarray == undefined)
        {
       
        }
        else {
            var count = 0;
            for (var i = 0; i < $scope.boardidarray.length; i++) {
                if ($scope.boardidarray[i] == BoardId) {
                    //alert("Hiiiye");
                    count = count + 1;

                    //$scope.checkID(BoardId);
                }
                else
                {  }
            }
            if (count > 0)
            {
                return true;
            }
            
        }
       
    }

}
