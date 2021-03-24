(function () {
    'use strict';

    angular
        .module('myApp')('dataService',
            function($http, $q) {
                return {
                    getDashboards: function() {
                        var deferred = $q.defer();
                        $http.get('api/dasboard').then(function success(response) {
                                deferred.resolve(response.data);
                            },
                            function error(response) {
                                deferred.reject(response.status);
                            }
                        );

                        return deferred.promise;
                    },

                    createDashboard: function (dashboard) {
                        var deferred = $q.deffer();

                        $http.post("api/dashboard", dashboard).then(function success(response) {
                                deferred.resolve(response.data);
                        },
                            function error(response) {
                                deferred.reject(response.status);
                            }
                        );

                        return deferred.promise;
                    }
                }
            });
})();