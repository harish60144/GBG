Dapp.controller('EnquiryController', function ($scope, $stateParams, $window, $http, urlConfig, httpReqService) {
    $scope.enquiry = {
        rFirstName: '',
        rLastName: '',
        rRelation: '',
        rEmail: '',
        rPhoneNo: '',
        rPhoneType: '',
        hearreason: '',

        g1FirstName: '',
        g1LastName: '',
        g1Relation: '',
        g1Email: '',
        g1PhoneNo: '',
        g1PhoneType: '',
        g1Address: '',
        g1Address1: '',
        g1City: '',
        g1State: '',
        g1Pin: '',
        g2FirstName: '',
        g2LastName: '',
        g2Relation: '',
        g2Email: '',
        g2PhoneNo: '',
        g2PhoneType: '',
        g2Address: '',
        g2Address1: '',
        g2City: '',
        g2State: '',
        g2Pin: '',

        fname: '',
        mname: '',
        lname: '',
        gender: '',
        dobMonth: '',
        dobDay: '',
        dobYear: '',
        isAddSame: '',
        address1: '',
        address2: '',
        city: '',
        cstate: '',
        czip: '',
        hospitalName: '',
        primaryDiagnosis: '',
        secondaryDiagnosis: '',
        allergies: '',
        equipment: '',
        measurement1: '',
        measurement2: '',
        cancrawl: '',
        cansit: '',
        canstand: '',
        canbendKnee: '',
        canwalk: '',
        priorexperience: '',
        currentSupportings: '',
        canpress: '',
        picUrl: '',
        aboutChild: '',
        addinfo1: '',
        addinfo2: '',
        addinfo3: '',
    };
    $scope.SubmitEnquiry = function () {
        httpReqService.ServiceReq(urlConfig.submitEnquiry, $scope.enquiry, function (data) {
            alert(data);
        });
    };
    $scope.SaveEnquiry = function () {
        httpReqService.ServiceReq(urlConfig.saveEnquiry, $scope.enquiry, function (data) {
            alert(data);
        });
    };
});