var app = angular.module("fetchNStore", []);

app.controller("fetchButton", function ($scope, $http) {
    $scope.fetchValue = "wakakakaka";
    $scope.methods = ["Get", "Post", "Put", "Delete"];
    console.log($scope.methodSelected);
    $scope.fetchFunction=function()
    {
        $http({
            method: "Get",
            //url:"www.facebook.com"
            url: "http://www.omdbapi.com/?s=harry&r=json"
        }).then(function mysuccess(response) {
            $scope.result = response.status;
            console.log($scope.result);

            var time = response.config.responseTimestamp - response.config.requestTimestamp;
            console.log('Time taken ' + (time / 1000) + ' seconds.');

        }, function myerror(response) {
            $scope.result = response.statusText;
        })
        console.log("this is the result after clicking ng-click");
    }

    

    
    
})

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