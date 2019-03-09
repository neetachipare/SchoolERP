
var app = angular.module('ERP').controller('SideBarController', SideBarController);

function SideBarController($scope, Service) {

    var form = $(".m-form m-form--fit m-form--label-align-right");
    $scope.ViewGetStudentInfoes = {};
    $scope.UserCredentialModel = {};
   
    $scope.SiteMenu = [];
    $scope.Initialize = function () {
        debugger;
       
       Service.Post("SideBar/GetSiteMenu").then(function (result) {
           debugger;
           $scope.SiteMenu = result.data;

       })

    }
}