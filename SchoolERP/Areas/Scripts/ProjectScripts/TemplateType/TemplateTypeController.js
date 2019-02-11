var app = angular.module('ERP').controller('TemplateTypeController', TemplateTypeController);

function TemplateTypeController($scope, Service) {

    var form = $(".student-admission-wrapper");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.btnactive = 1;


    $scope.Initialize = function () {
        debugger;
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("TemplateType/GetTemplateTypeMaster", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.TemplateTypes = result.data.ResultData;
            //console.log(result.data);

        })
    }

    $scope.ShowHide = function (TemplateTypeId) {
        debugger;
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        var data = {

            TemplateTypeId: TemplateTypeId

        };

        Service.Post("TemplateType/GetSingleTemplateTypeInfo", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

            debugger;

            $scope.ViewGetStudentInfoes = result.data;

            $scope.TemplateType = result.data.TemplateType;
            $scope.TemplateTypeId = result.data.TemplateTypeId;
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

        $scope.TemplateType = null;
        $scope.TemplateTypeId = null;
        $scope.IsVisible = false;
        // $scope.Initialize();
    }

    $scope.AddUpdate = function (TemplateTypeId, TemplateType, BtnStatus) {
        var data = {
            TemplateTypeId: TemplateTypeId,
            TemplateType: TemplateType,
            BtnStatus: BtnStatus
        };
        if ($scope.form.$valid) {
            Service.Post("TemplateType/SaveTemplateType", JSON.stringify(data)).then(function (response) {

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


    $scope.Delete = function (TemplateTypeId) {
        debugger;
        var data = {

            TemplateTypeId: TemplateTypeId
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the Template Type?");

        }
        else {
            var confirm = window.confirm("Do you want to active the Template Type?");
        }
        if (confirm == true) {
            Service.Post("TemplateType/DeleteTemplateType", JSON.stringify(data)).then(function (response) {

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
