angular.module('ERP').controller('LoginController', LoginController);

function LoginController($scope, Service) {
    var form = $(".login100-form");
    $scope.User = {};
   
        $scope.ValidateUser = function () {
            debugger;
            data = {
                Username:$scope.User.UserName,
                Password :$scope.User.Password
            }
                         
            Service.Post("Login/ValidateUserLogin",data).then(function (rd) {
               
            if (rd.data.IsSucess) {
                location.href = "SuperAdmin/Master/ViewSchoolMaster";
            }

        })
    }
        // Add headers
       
}
