Dapp.controller('KidsController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService) {
    httpReqService.ServiceReq(urlConfig.getKids, '', function (data) {
        $scope.KidsList = data;
    });
});