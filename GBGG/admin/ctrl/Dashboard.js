Dapp.controller('DashboardController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService) {
    httpReqService.ServiceReq(urlConfig.getEnquiry, '', function (data) {
        $scope.EnquiryList = data;
    });
});