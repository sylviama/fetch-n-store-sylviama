var app = angular.module("fetchNStore", []);

app.controller("fetchButton", function ($scope, $http) {
    
    $scope.methods = ["Get", "Head"];
    $scope.urls = ["http://www.omdbapi.com/?s=harry&r=json", "https://ngtododemo.firebaseio.com/.json", "https://www.facebook.com", "https://www.realtyshares.com/blog/nnn-investing-the-basics"];
    
    $scope.fetchFunction=function()
    {
        $http({
            method: $scope.methodSelected,
            url: $scope.urlSelected
        }).then(function mysuccess(response) {
            $scope.statusResult = response.status;
            
            //calculate response time
            var time = response.config.responseTimestamp - response.config.requestTimestamp;
            $scope.requestTime=new Date();
            $scope.showtime=(time / 1000) + ' seconds.';

        }, function myerror(response) {
            $scope.statusResult = response.statusText;
        })
        console.log("this is the result after clicking ng-click");
    }

    

    
    
})

//calculate response time
app.factory('logTimeTaken', [function () {
    var logTimeTaken = {
        request: function (config) {
            config.requestTimestamp = new Date().getTime();
            return config;
        },
        response: function (response) {
            response.config.responseTimestamp = new Date().getTime();
            return response;
        }
    };
    return logTimeTaken;
}]);
app.config(['$httpProvider', function ($httpProvider) {
    $httpProvider.interceptors.push('logTimeTaken');
}]);