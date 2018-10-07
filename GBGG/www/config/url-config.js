Dapp.service('urlConfig', function () {
    //var baseURL = "http://LHBLREGLL039:8080/api/";
    var baseURL = "http://localhost:55274/";
    
    this.submitEnquiry = baseURL + "api/addEnquiry";
    this.saveEnquiry = baseURL + "api/saveEnquiry";
    
});
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