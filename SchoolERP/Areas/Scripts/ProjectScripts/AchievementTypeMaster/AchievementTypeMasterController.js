var app = angular.module('ERP').controller('AchievementTypeMasterController', AchievementTypeMasterController);

function AchievementTypeMasterController($scope, Service)
{
    var form = $(".student-admission-wrapper");
    
    $scope.UserCredentialModel = {};
    $scope.AchievementTypeMasterList = {};
    $scope.btnactive = 1;

    $scope.Initialize = function () {
      
        $scope.UserCredentialModel.Status = $scope.btnactive;
        Service.Post("AchievementTypeMaster/GetAllAchievementTypeMaster", $scope.UserCredentialModel).then(function (result) {
           
            $scope.AchievementTypeMasterList =result.data;
        })
    }
    $scope.ShowHide = function (AchievementTypeID) {
      
        $scope.btnUpdate = true;
        $scope.btnSave = false;
        $scope.IsVisible = true;
        var data = {
            AchievementTypeID: AchievementTypeID
        };

        Service.Post("AchievementTypeMaster/GetSingleAchievementTypeMaster", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

           
            
            $scope.AchievementType = result.data.AchievementType;
            $scope.AchievementTypeID = result.data.AchievementTypeID;
           

            $scope.Initialize();
        })
    }
    $scope.ShowHideSave = function () {
      
        $scope.btnUpdate = false;
        $scope.btnSave = true;
        $scope.IsVisible = true;
    }
    $scope.Clear = function () {

        $scope.AchievementType = null;
        $scope.AchievementTypeID = null;
        $scope.IsVisible = false;
       
    }

    $scope.Add = function (AchievementType) {
        debugger;
        var data = {
            AchievementType: AchievementType
        };
        if ($scope.form.$valid) {
            Service.Post("AchievementTypeMaster/AddAchievementTypeMaster", JSON.stringify(data)).then(function (response) {

                if (response.data.IsSucess) {
                    debugger;
                    $scope.Clear();
                    $scope.IsVisible = false;
                    $scope.Initialize();
                    alert(response.data.ResultData);
                }
                else {
                    debugger;
                    alert(response.data.Message);
                   
                }

            });
        }
    }

    $scope.Update = function (AchievementTypeID, AchievementType) {
        debugger;
        var data = {
            AchievementTypeID: AchievementTypeID,
            AchievementType: AchievementType
        };
        if ($scope.form.$valid) {
            Service.Post("AchievementTypeMaster/UpdateAchievementTypeMaster", JSON.stringify(data)).then(function (response) {

                if (response.data.IsSucess) {
                    debugger;
                    $scope.Clear();
                    $scope.IsVisible = false;
                    $scope.Initialize();
                    alert(response.data.ResultData);
                    
                }
                else {
                    debugger;
                    alert(response.data.Message);
                }

            });
        }
    }
    
    $scope.Delete = function (AchievementTypeID) {
        debugger;
        var data = {

            AchievementTypeID: AchievementTypeID
        };

        if (event.target.checked == false) {
            var confirm = window.confirm("Do you want to deactive the Achievement Type?");

        }
        else {
            var confirm = window.confirm("Do you want to active the Achievement Type?");
        }
        if (confirm == true) {
            Service.Post("AchievementTypeMaster/DeleteAchievementTypeMaster", JSON.stringify(data)).then(function (response) {

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




















