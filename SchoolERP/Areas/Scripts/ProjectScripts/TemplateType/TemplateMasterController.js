var app = angular.module('ERP').controller('TemplateMasterController', TemplateMasterController);

function TemplateMasterController($scope, Service) {

    var form = $(".student-admission-wrapper");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.btnactive = 1;


    $scope.Initialize = function () {
        debugger;
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("TemplateMaster/GetTemplateMaster", $scope.UserCredentialModel).then(function (result) {
            //debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.Modules = result.data.ResultData;
            //console.log(result.data);

        })
    }


    $scope.GetInfo = function () {
        debugger;
        Service.Get("TemplateMaster/GetTemplateType").then(function (result) {
            //debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            //$scope.tbl_grievance_list = result.data;
            $scope.TemplateType = result.data.ResultData;
            console.log(result.data);

        })

    }

    $scope.GetMenu = function () {
        debugger;
        Service.Get("TemplateMaster/GetMenu").then(function (result) {
            //debugger;
            // $scope.ParamUserLogin.Name = result.data.Name
            //$scope.tbl_grievance_list = result.data;

            $scope.Menulist = result.data.ResultData;

            console.log(result.data);

        })

    }

    $scope.ShowHide = function (TemplateId) {
        debugger;
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        $scope.GetInfo();
        var data = {

            TemplateId: TemplateId

        };

        Service.Post("TemplateMaster/GetSingleTemplateMasterInfo", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

            debugger;

            $scope.ViewGetStudentInfoes = result.data;
            $scope.Name = result.data.Name;
            $scope.TemplateTypeId = result.data.TemplateTypeId;
            $scope.TemplateId = result.data.TemplateId;
            Service.Post("TemplateMaster/GetMenuDetails", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {
                debugger;
                $scope.MenuDetails = result.data;
                for (var i = 0; i < $scope.MenuDetails.length; i++)
                {
                    $scope.change($scope.MenuDetails[i], true);
                }
                
            })
            $scope.Initialize();
        })
    }

    $scope.checkID = function (moduleid) {
        var dat = $scope.MenuDetails.find(o=> o.ModuleId === moduleid);
        debugger;
        if (dat)
        {
            return true
        }
        else { return false }
    }


    $scope.ShowHideSave = function () {
        debugger;
        $scope.btnUpdate = false;
        $scope.btnSave = true;
        $scope.IsVisible = true;
    }
   

    $scope.Clear = function () {

        $scope.Name = null;
        $scope.TemplateId = null;
        $scope.IsVisible = false;
      
            
        //$scope.Initialize();
   
    }
    $scope.lst = [];
    $scope.str = "No Selected Menus !";
    $scope.change = function (s, active) {

        debugger;
        if (active)
           $scope.lst.push(s.ModuleName);
            else
                $scope.lst.splice($scope.lst.indexOf(s.ModuleName), 1);
            $scope.str = "";
           for (var i = 0; i < $scope.lst.length; i++)
            {
                $scope.str += $scope.lst[i] + ", ";
                

            }
        
    };
    //$scope.AddUpdate = function (TemplateId, TemplateTypeId, Menu, BtnStatus) {
    $scope.AddUpdate = function (TemplateId, TemplateTypeId, Name, BtnStatus) {
        debugger;
        var MenuListIds = "";
        for (var i = 0; i < $scope.Menulist.length; i++) {
            if ($scope.Menulist[i].Selected) {
                var ModuleId = $scope.Menulist[i].ModuleId;
                var ModuleName = $scope.Menulist[i].ModuleName;
                MenuListIds += ModuleId + ",";
            }
        }
       
        //alert(MenuListIds);
        var data = {
            TemplateId: TemplateId,
            TemplateTypeId: TemplateTypeId,
            Name: Name,
            BtnStatus: BtnStatus,
            MenuListIds: MenuListIds
        };
        if ($scope.form.$valid) {
            Service.Post("TemplateMaster/SaveTemplateMaster", JSON.stringify(data)).then(function (response) {
                debugger;
                if (response.data.IsSucess) {




                    //CustomizeApp.UpdateMessage();
                    $scope.Clear();
                    $scope.GetMenu();
                    $scope.GetInfo();
                    $scope.str = "No Selected Menus !";
                    $scope.IsVisible = false;
                    $scope.Initialize();
                    alert(response.data.ResultData);
                    // window.location = "./ParentGrievance"

                    //alert(result.data);

                }
                else {
                    debugger;
                    //ShowMessage(0, response.data.Message);
                    alert(response.data.Message);
                    //$scope.clear();
                    //window.location = "./PostGrievance"
                }

            });
        }
    };


    $scope.Delete = function (TemplateId) {
        debugger;
        var data = {

            TemplateId: TemplateId
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the Template?");

        }
        else {
            var confirm = window.confirm("Do you want to active the Template?");
        }
        if (confirm == true) {
            Service.Post("TemplateMaster/DeleteTemplateMaster", JSON.stringify(data)).then(function (response) {

                debugger;
                if (response.data)
                    $scope.Initialize();
                alert(response.data.ResultData);
            });
        }
        $scope.Clear();
        $scope.IsVisible = false;
        $scope.Initialize();

    };

   
   


}
