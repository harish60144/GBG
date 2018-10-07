Dapp.controller('LoginController', function ($scope, $stateParams, $state, $window, $http, urlConfig, httpReqService) {
    $scope.usr = {
        name: '',
        Pwd:''
    };
    $scope.Signin = function (usrname,usrpwd) {
        //alert(usrname + '-' + usrpwd)
        $state.go('menu.dashboard');
    };
});