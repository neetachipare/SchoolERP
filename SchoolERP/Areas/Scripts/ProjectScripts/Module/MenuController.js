var app = angular.module('ERP').controller('MenuController', MenuController);

function MenuController($scope, Service) {

    var form = $(".m-form--label-align-right");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.ModuleMenuName = {};
    $scope.ParentMenu = {};
    

    $scope.Initialize = function () {
        debugger; 
        var data =
        {
            Status: $scope.btnactive
        };
        Service.Post("Module/GetAllMenu", JSON.stringify(data)).then(function (result) {
            
            $scope.ViewGetStudentInfoes = result.data;
            $scope.ModuleData = result.data;
            console.log(result.data);

        })

       

    }
    $scope.GetModuleNames = function () {
        debugger;
        Service.Post("Module/GetMenuModuleName").then(function (result) {


            $scope.ModuleMenuName = result.data;
            console.log(result.data);

        })
    }

    $scope.GetChildMenuName = function () {
        debugger;
        Service.Post("Module/GetChildMenuNames").then(function (result) {


            $scope.ParentMenu = result.data;
            console.log(result.data);

        })
    }

   
    $scope.GetChildMenus = function (ParentModuleId) {
        debugger;
        var Data = {
            ParentMenuId: ParentModuleId
        };
        Service.Post("Module/GetMenuUnderModule", JSON.stringify(Data)).then(function (result) {



            $scope.ParentMenu = result.data;
            console.log(result.data);

        })
    }
    $scope.ShowHideSave = function () {
        debugger;
        $scope.btnUpdate = false;
        $scope.btnSave = true;
        $scope.IsVisible = true;
        $scope.ddlEdit = false;
        $scope.ddlSave = true;
            
    }


    $scope.AddUpdate = function (ModuleId, ParentModuleId, ModuleName, ActionName, ModuleOrder, Save) {
        var data = {
            ModuleId: ModuleId,            
            ParentMenuId: ParentModuleId,
            ModuleName: ModuleName,
            ActionName: ActionName,
            ModuleOrder: ModuleOrder,
            BtnStatus:Save
        };
        if ($scope.form.$valid) {
            Service.Post("Module/SaveUpdate", JSON.stringify(data)).then(function (response) {

                if (response.data.IsSucess) {
                    debugger;
                    alert(response.data.Message);
                    $scope.Clear();
                    //$scope.IsVisible = false;
                    $scope.Initialize();
                    
                }
                else {
                    ShowMessage(0, response.data.Message);
                    //$scope.clear();
                    //window.location = "./PostGrievance"
                }

               
            });
        }
    }


    $scope.Delete = function (ModuleId) {
        debugger;
        var data = {

            ModuleId: ModuleId,

        };
        var deactivestatus = 1;
        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to delete this entry ?");
            deactivestatus = 0;
        }
        else {
            var confirm = window.confirm("Do you want to re-enter this entry ?");
        }
        if (confirm == true) {
            Service.Post("Module/DeleteMenu", JSON.stringify(data)).then(function (response) {

                $scope.Initialize();


                if (deactivestatus == 0) {
                    window.alert('Entry deleted Successfully!')

                }
                else {
                    window.alert('Entry Added Successfully!')
                   
                }

            });
        }
        $scope.Clear();
        $scope.IsVisible = false;


    }


    $scope.Clear = function () {

        $scope.ModuleId = null;
        $scope.ParentMenuId = null;
        $scope.ModuleName = null;
        $scope.ActionName = null;
        $scope.ModuleOrder = null;
        $scope.Save = null;
        $scope.IsVisible = false;
        // $scope.Initialize();
    }
    $scope.ShowHide = function (ModuleId) {
        
        $scope.ddlEdit = true;
        $scope.ddlSave = false;
        $scope.btnUpdate = true;
        $scope.btnSave = false;

        var data = {

            ModuleId: ModuleId

        };

        Service.Post("Module/GetSingleMenu", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

            debugger;
            console.log(result.data);
            $scope.ViewGetStudentInfoes = result.data;

            $scope.ModuleId = result.data.ModuleId;
            $scope.ModuleName = result.data.ModuleName;
            $scope.ParentModuleId = result.data.ParentModuleId;
            $scope.ModuleOrder = result.data.ModuleOrder;
            $scope.Status = result.data.Status;
            $scope.ActionName = result.data.ActionName;
            
               // $scope.GetChildMenus(result.data.ParentModuleId);
            
            $scope.IsVisible = true;
           // $scope.Initialize();
        })
    }
    

    //

    //$scope.Delete = function (UserId, Type) {
    //    debugger;
    //    var data = {

    //        UserId: UserId,
    //        type: Type
    //    };

    //    if (event.target.checked == false) {
    //        var confirm = window.confirm("Do you want to deactive the student ?");

    //    }
    //    else {
    //        var confirm = window.confirm("Do you want to active the student ?");
    //    }
    //    if (confirm == true) {
    //        Service.Post("api/Register/DeleteStudents", JSON.stringify(data)).then(function (response) {


    //            if (response.data)

    //                window.alert('Student Deactive Successfully!')



    //        });
    //    }
    //    $scope.Clear();
    //    $scope.IsVisible = false;
    //    $scope.Initialize();


    //}



}
