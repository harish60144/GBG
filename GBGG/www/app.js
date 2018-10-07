var Dapp = angular.module('gobabygo', ['ui.router']);
Dapp.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider) {
    $locationProvider.hashPrefix('');
    $urlRouterProvider.when("", "enquiry");
    $urlRouterProvider.when("/", "enquiry");

    // For any unmatched url, send to /route1
    $urlRouterProvider.otherwise("enquiry");
    //angular.element(document.querySelector('#busy-overlay')).hide;
    $stateProvider.state('enquiry', {
        url: '/enquiry',
        templateUrl: 'views/EnquiryForm.html',
        controller: 'EnquiryController',
        onEnter: function () {
            console.log("Enquiry Form");
        }
    });
}]);
