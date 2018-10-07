Dapp.controller('CarsController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService, $state) {
    httpReqService.ServiceReq(urlConfig.getCarsList, '', function (data) {
        $scope.CarsList = data;
    });
    $scope.AddNewCar = function () {
        $state.go('menu.cardetails');
    };
    $scope.SaveCar = function (iPurpose, ilocation) {
        var car = {
            CarId: 0,
            Purpose: iPurpose,
            TypeId: 1,
            IsActive: 1,
            Location: ilocation,
            CreatedDate: '',
            CreatedBy: 1,
            ModifiedDate: '',
            ModifiedBy: 1
        }
        httpReqService.ServiceReq(urlConfig.addCar, car, function (data) {

        });
        $state.go('menu.cars');
    };
    
});