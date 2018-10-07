Dapp.controller('WorkshopController', function ($scope, $state, $stateParams, $window, $http, urlConfig, httpReqService) {

    httpReqService.ServiceReq(urlConfig.getWorkshopsList, '', function (data) {
        $scope.WorkshopsList = data;
    });
    $scope.AddWorkshop = function () {
        $state.go('menu.workshopdetails');
    };

    $scope.SaveWorkShop = function () {
        $state.go('menu.workshop');
    };

    $scope.tabEvent = 'active';
    $scope.tabSponser = 'disabled';
    $scope.tabAddress = 'disabled';
    $scope.tabBtnEvent = 'active';
    $scope.tabBtnSponser = 'disabled';
    $scope.tabBtnAddress = 'disabled';
    $scope.next = function (tab) {
        switch (tab) {
            case 1:
                $scope.tabEvent = 'disabled';
                $scope.tabSponser = 'active';
                $scope.tabAddress = 'disabled';
                $scope.tabBtnEvent = 'disabled';
                $scope.tabBtnSponser = 'active';
                $scope.tabBtnAddress = 'disabled';
                break;
            case 2:
                $scope.tabEvent = 'disabled';
                $scope.tabSponser = 'disabled';
                $scope.tabAddress = 'active';
                $scope.tabBtnEvent = 'disabled';
                $scope.tabBtnSponser = 'disabled';
                $scope.tabBtnAddress = 'active';
                break;
            case 3:
                $scope.tabEvent = 'disabled';
                $scope.tabSponser = 'disabled';
                $scope.tabAddress = 'active';
                $scope.tabBtnEvent = 'disabled';
                $scope.tabBtnSponser = 'disabled';
                $scope.tabBtnAddress = 'active';
                break;
        }
    };
    $scope.prev = function (tab) {
        switch (tab) {
            case 2:
                $scope.tabEvent = 'active';
                $scope.tabSponser = 'disabled';
                $scope.tabAddress = 'disabled';
                $scope.tabBtnEvent = 'active';
                $scope.tabBtnSponser = 'disabled';
                $scope.tabBtnAddress = 'disabled';
                break;
            case 3:
                $scope.tabEvent = 'disabled';
                $scope.tabSponser = 'active';
                $scope.tabAddress = 'disabled';
                $scope.tabBtnEvent = 'disabled';
                $scope.tabBtnSponser = 'active';
                $scope.tabBtnAddress = 'disabled';
                break;
        }
    };

    $('.nav-tabs > li a[title]').tooltip();
    /*=========================Calander=========================*/
    $scope.today = function () {
        $scope.dt = '02/01/2017';
    };
    $scope.dt = '31/12/2017';
    $scope.clear = function () {
        $scope.dt = null;
    };

    $scope.dateOptions = {
        formatYear: 'yy',
        startingDay: 1
    };

    $scope.open1 = function () {
        $scope.popup1.opened = true;
    };

    $scope.popup1 = {
        opened: false
    };
}).directive('dateFormatter', [
    function () {
        return {
            restrict: 'A',
            require: 'ngModel',
            link: function postLink(scope, element, attrs, ngModel) {
                ngModel.$parsers.push(function (data) {
                    console.log("parsers.push " + data);
                    var out = moment(data).format('DD/MM/YYYY');
                    console.log("$parsers.out = " + out);
                    return out;
                });

                ngModel.$formatters.push(function (data) {
                    console.log("$formatters.push " + data);
                    var out = moment(data, 'DD/MM/YYYY').toDate()
                    console.log("$formatters.out =" + out);
                    return out;
                });
            }
        };
    }
]);