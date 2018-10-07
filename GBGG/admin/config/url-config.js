Dapp.service('urlConfig', function () {
    //var baseURL = "http://gobabygo.dhruti.in/api/";
    var baseURL = "http://localhost:55274/";
    this.getEnquiry = baseURL + "api/getEnquiry";
    this.getWorkshopsList = baseURL + "api/getWorkshops";
    this.getCarsList = baseURL + "api/getCars";
    this.getCarTypesList = baseURL + "api/getCarTypes";
    this.getPersons = baseURL + "api/getPersons";
    this.getKids = baseURL + "api/getKids";
    this.addCar = baseURL + "api/addCar";
    this.addCarType = baseURL + "api/addCarType";

    Dapp.directive('uploadFiles', function () {
        return {
            scope: true,        //create a new scope  
            link: function (scope, el, attrs) {
                el.bind('change', function (event) {
                    var files = event.target.files;
                    //iterate files since 'multiple' may be specified on the element  
                    for (var i = 0; i < files.length; i++) {
                        //emit event upward  
                        scope.$emit("seletedFile", { file: files[i] });
                    }
                });
            }
        };
    });
});