var app = angular.module('ERP').controller('ModuleController', ModuleController);

function ModuleController($scope, Service) {

    var form = $(".student-admission-wrapper");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.btnactive = 1;
  

    $scope.Initialize = function () {
        debugger; 
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("Module/GetModuleMaster", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.Modules = result.data.ResultData;
            //console.log(result.data);

        })
    }

    $scope.ShowHide = function (ModuleId) {
        debugger;
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        var data = {

            ModuleId: ModuleId

        };

        Service.Post("Module/GetSingleModuleInfo", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

            debugger;

            $scope.ViewGetStudentInfoes = result.data;

            $scope.ModuleName = result.data.ModuleName;
            $scope.ModuleOrder = result.data.ModuleOrder;
            $scope.ModuleId = result.data.ModuleId;
            // $scope.Students = result.data.ResultData;

            $scope.Initialize();
        })
    }


    $scope.ShowHideSave = function () {
        debugger;
        $scope.btnUpdate = false;
        $scope.btnSave = true;
        $scope.IsVisible = true;
    }


    $scope.Clear = function () {

        $scope.ModuleName = null;
        $scope.ModuleOrder = null;
        $scope.ModuleId = null;
        $scope.IsVisible = false;
        // $scope.Initialize();
    }

    $scope.AddUpdate = function (ModuleId, ModuleName, ModuleOrder, BtnStatus) {
        var data = {
            ModuleId: ModuleId,
            ModuleName: ModuleName,
            ModuleOrder: ModuleOrder,
            BtnStatus: BtnStatus
        };
        if ($scope.form.$valid) {
            Service.Post("Module/SaveModule", JSON.stringify(data)).then(function (response) {

                if (response.data.IsSucess) {
                    debugger;

                   

                    //CustomizeApp.UpdateMessage();
                    $scope.Clear();
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
    }


    $scope.Delete = function (ModuleId) {
        debugger;
        var data = {

            ModuleId: ModuleId
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the module?");

        }
        else {
            var confirm = window.confirm("Do you want to active the module?");
        }
        if (confirm == true) {
            Service.Post("Module/DeleteModule", JSON.stringify(data)).then(function (response) {

                debugger;
                if (response.data)
                    $scope.Initialize();
                    alert(response.data.ResultData);
            });
        }
        $scope.Clear();
        $scope.IsVisible = false;
        $scope.Initialize();

    }

}
