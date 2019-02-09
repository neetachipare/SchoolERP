angular.module('ERP').controller('LoginController', LoginController);

function LoginController($scope, Service) {
    var form = $(".login100-form");
    $scope.User = {};

        $scope.ValidateUser = function () {
            debugger;
            Username = $scope.User.UserName;
            Password = $scope.User.Password;
            Service.Post("api/Login/ValidateUserLogin").then(function (rd) {
                alert('Hii')
            if (rd.data.IsSucess) {
                alert('Success')
            }

        })
    }
}
