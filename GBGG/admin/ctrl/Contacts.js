Dapp.controller('ContactsController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService) {
    httpReqService.ServiceReq(urlConfig.getPersons, '', function (data) {
        $scope.ContactList = data;
    });
});