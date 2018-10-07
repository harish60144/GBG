Dapp.controller('CartypesController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService, $state) {
    $scope.AddCarType = function () {
        $state.go('menu.cartypedetails');
    };
    httpReqService.ServiceReq(urlConfig.getCarTypesList, '', function (data) {
        $scope.CarTypeList = data;
    });
    $scope.SaveCarType = function (type, make, model, color, location, owner, voltage) {
        var ctype = {

            CarTypeId: 0,
            Make: make,
            Model: model,
            Color: color,
            Voltage: voltage,
            Owner: owner,
            IsActive: 1,
            CreatedDate: '',
            CreatedBy: 1,
            ModifiedDate: '',
            ModifiedBy: 1
        };
        httpReqService.ServiceReq(urlConfig.addCarType, ctype, function (data) {

        });
        $state.go('menu.cartype');
    }
});