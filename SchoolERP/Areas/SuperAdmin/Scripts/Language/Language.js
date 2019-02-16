var app = angular.module('ERP').controller('LanguageController', LanguageController);

function LanguageController($scope, Service) {

    var form = $(".student-admission-wrapper");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
    $scope.btnactive = 1;


    $scope.Initialize = function () {
        debugger;
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("SchoolMaster/GetLanguageInfo", $scope.UserCredentialModel).then(function (result) {
            debugger;
            $scope.ViewGetStudentInfoes = result.data;
            $scope.data = result.data;
            //console.log(result.data);

        })
    }

    $scope.ShowHide = function (LanguageId) {
        debugger;
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        var data = {

            LanguageId: LanguageId

        };

        Service.Post("SchoolMaster/GetSingleLanuageInfo", JSON.stringify(data)).then(function (result) {

            debugger;

            $scope.ViewGetStudentInfoes = result.data;

            $scope.Language = result.data.ResultData.Language;
            $scope.LanguageId = result.data.ResultData.LanguageId;
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

        $scope.Language = null;
        $scope.LanguageId = null;
        $scope.IsVisible = false;
        // $scope.Initialize();
    }
    $scope.Add = function (LanguageId, Language) {
        var data = {
            LanguageId: LanguageId,
            Language: Language

        };
        if ($scope.form.$valid) {
            Service.Post("SchoolMaster/AddLanguage", JSON.stringify(data)).then(function (response) {

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

    $scope.AddUpdate = function (LanguageId, Language) {
        var data = {
            LanguageId: LanguageId,
            Language: Language

        };
        if ($scope.form.$valid) {
            Service.Post("SchoolMaster/UpdateLanguage", JSON.stringify(data)).then(function (response) {

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


    $scope.Delete = function (LanguageId) {
        debugger;
        var data = {

            LanguageId: LanguageId
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the board?");

        }
        else {
            var confirm = window.confirm("Do you want to active the board?");
        }
        if (confirm == true) {
            Service.Post("SchoolMaster/DeleteLanguage", JSON.stringify(data)).then(function (response) {

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
