var Dapp = angular.module('gbgadmin', ['ui.router']);
Dapp.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider) {
    $locationProvider.hashPrefix('');
    $urlRouterProvider.when("", "login");
    $urlRouterProvider.when("/", "login");

    // For any unmatched url, send to /route1
    $urlRouterProvider.otherwise("login");
    //angular.element(document.querySelector('#busy-overlay')).hide;
    $stateProvider.state('login', {
        url: '/login',
        templateUrl: 'views/Login.html',
        controller: 'LoginController',
        onEnter: function () {
            console.log("Login Form");
        }
    }).state('menu', {
        abstract: true,
        url: '/menu',
        templateUrl: 'views/Menu.html',
        controller: 'MenuController',
        onEnter: function () {
            console.log("enter contacts");
        },
        params: {
            obj: null
        }
    }).state('menu.dashboard', {
        url: '/dashboard',
        templateUrl: 'views/Dashboard.html',
        controller: 'DashboardController',
        onEnter: function () {
            console.log("enter dashboard");
        }
    }).state('menu.kids', {
        url: '/kids',
        templateUrl: 'views/Kids.html',
        controller: 'KidsController',
        onEnter: function () {
            console.log("enter Kids");
        }
    }).state('menu.cars', {
        url: '/cars',
        templateUrl: 'views/Cars.html',
        controller: 'CarsController',
        onEnter: function () {
            console.log("enter Cars");
        }
    }).state('menu.cardetails', {
        url: '/cardetails',
        templateUrl: 'views/Cardetails.html',
        controller: 'CarsController',
        onEnter: function () {
            console.log("enter cardetails");
        }
    }).state('menu.cartypes', {
        url: '/cartypes',
        templateUrl: 'views/CarTypes.html',
        controller: 'CartypesController',
        onEnter: function () {
            console.log("enter Cartypes");
        }
    }).state('menu.cartypedetails', {
        url: '/cartypedetails',
        templateUrl: 'views/CarTypeDetails.html',
        controller: 'CartypesController',
        onEnter: function () {
            console.log("enter Cartypes");
        }
    }).state('menu.contacts', {
        url: '/contacts',
        templateUrl: 'views/Contacts.html',
        controller: 'ContactsController',
        onEnter: function () {
            console.log("enter contacts");
        }
    }).state('menu.workshop', {
        url: '/workshop',
        templateUrl: 'views/Workshops.html',
        controller: 'WorkshopController',
        onEnter: function () {
            console.log("enter Workshop");
        }
    }).state('menu.workshopdetails', {
        url: '/workshopdetails',
        templateUrl: 'views/WorkshopDetails.html',
        controller: 'WorkshopController',
        onEnter: function () {
            console.log("enter Workshop");
        }
    });
}]);
