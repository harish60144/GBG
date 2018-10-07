Dapp.service('httpReqService', function ($http) {
    this.ServiceReq = function (url, reqBody, callback) {
        var method = "POST";
        var resData;
        //angular.element('#busy-overlay').show();
        $http({
            method: method,
            url: url,
            data: angular.toJson(reqBody),
            headers: {
                'Access-Control-Allow-Origin': '*',
                'Content-Type': 'application/json'
            }
        }).then(function (response) {
            //angular.element('#busy-overlay').hide();
            callback(response.data);
        }, function () {
            //angular.element('#busy-overlay').hide();
            alert('Error!!!');
        });
    }
});