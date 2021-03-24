(function () {
    'use strict';
    var app = angular.module('myApp');

    app.controller('ModalCtrl', function ($scope, $uibModal) {

        $scope.open = function () {
            var modalInstance = $uibModal.open({
                templateUrl: "/views/modalContent.html",
                controller: "ModalContentCtrl",
                size: '',
            });

            modalInstance.result.then(function (response) {
                $scope.result = `${response} button hitted`;
            });

        };
    })

    app.controller('ModalContentCtrl', function ($scope, $http, $uibModalInstance) {
        
        $scope.result = {};
        $scope.save = function (dashboard, createDashboard) {
            if (createDashboard.$valid) {

                $http.post("api/dashboard", dashboard).then(function success(response) {
                    $scope.result = response.data;
                        $uibModalInstance.close("Ok");
                    });
                }
            };
        
      $scope.cancel = function () {
            $uibModalInstance.dismiss();
        }

    });
})();
