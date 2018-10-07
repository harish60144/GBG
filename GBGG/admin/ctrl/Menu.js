Dapp.controller('MenuController', function ($scope, $state, $stateParams, $window, $http, urlConfig, httpReqService) {
    $scope.dashboard = function () { $state.go('menu.dashboard'); };
    $scope.kids = function () { $state.go('menu.kids'); };
    $scope.cars = function () { $state.go('menu.cars'); };
    $scope.cartypes = function () { $state.go('menu.cartypes'); };
    $scope.contacts = function () { $state.go('menu.contacts'); };
    $scope.workshop = function () { $state.go('menu.workshop'); };

});