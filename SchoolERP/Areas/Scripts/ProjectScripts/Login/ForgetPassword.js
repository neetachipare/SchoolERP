angular.module('ERP').controller('ForgetPassController', ForgetPassController);

function ForgetPassController($scope, Service) {
    var form = $(".m-login__form m-form");
      $scope.UserCredentialModel = {};
      $scope.Verify = function () {
          debugger;
        var Info = {
            ContactNumber: $scope.ContactNumber
        }
        if ($scope.ContactNumber == undefined) {
            $("#error").text("Contact Number Required");
            $("#error").css({ 'color': 'red' });
            return false;
        }

        Service.Post("api/Login/ForgetPassword", Info).then(function (result) {
            debugger;
            if (result.data.IsSucess) {

               

            }
            else {
               

            }


        })

      }
    $scope.Close = function () {
        $scope.ContactNumber = {};
        location.href = baseURL + "Home/Index";
    }
}
