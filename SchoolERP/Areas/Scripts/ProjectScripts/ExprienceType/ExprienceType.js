﻿var app = angular.module('ERP').controller('ExprienceTypeController', ExprienceTypeController);

function ExprienceTypeController($scope, Service) {

    var form = $(".student-admission-wrapper");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.btnactive = 1;


    $scope.Initialize = function () {
        debugger;
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("ExperienceType/GetExprienceTypeInfo", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.ExprienceTypeData = result.data;
            //console.log(result.data);

        })
    }

    $scope.ShowHide = function (ExprienceTypeID) {
        debugger;
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        var data = {

            ExprienceTypeID: ExprienceTypeID

        };

        Service.Post("ExperienceType/GetSingleExprienceTypeInfo", JSON.stringify(data)).then(function (result) {

            debugger;

            $scope.ViewGetStudentInfoes = result.data;

            $scope.ExprienceType = result.data.ResultData.ExprienceType;
            $scope.ExprienceTypeID = result.data.ResultData.ExprienceTypeID;
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

        $scope.ExprienceType = null;
        $scope.ExprienceTypeID = null;
        $scope.IsVisible = false;
        // $scope.Initialize();
    }
    $scope.Add = function (ExprienceTypeID, ExprienceType) {
        var data = {
            ExprienceTypeID: ExprienceTypeID,
            ExprienceType: ExprienceType

        };
        if ($scope.form.$valid) {
            Service.Post("ExperienceType/AddExperienceType", JSON.stringify(data)).then(function (response) {

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

    $scope.AddUpdate = function (ExprienceTypeID, ExprienceType) {
        var data = {
            ExprienceTypeID: ExprienceTypeID,
            ExprienceType: ExprienceType

        };
        if ($scope.form.$valid) {
            Service.Post("ExperienceType/UpdateExprienceType", JSON.stringify(data)).then(function (response) {

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


    $scope.Delete = function (ExprienceTypeID) {
        debugger;
        var data = {

            ExprienceTypeID: ExprienceTypeID
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the ExperienceType?");

        }
        else {
            var confirm = window.confirm("Do you want to active the ExperienceType?");
        }
        if (confirm == true) {
            Service.Post("ExperienceType/DeleteExprienceType", JSON.stringify(data)).then(function (response) {

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
