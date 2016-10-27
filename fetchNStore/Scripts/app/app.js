var app = angular.module("fetchNStore", []);

app.controller("fetchButton", ['$scope', '$http', function ($scope, $http) {

    $scope.methods = ["Get", "Head"];
    $scope.urls = ["http://www.omdbapi.com/?s=harry&r=json", "https://ngtododemo.firebaseio.com/.json", "https://www.facebook.com", "https://www.realtyshares.com/blog/nnn-investing-the-basics"];

    //fetch
    $scope.fetchFunction = function () {
        $http({
            method: $scope.result.HttpMethod,
            url: $scope.result.URL
        }).then(function mysuccess(response) {
            $scope.result.StatusCode = response.status;

            //calculate response time
            var time = response.config.responseTimestamp - response.config.requestTimestamp;
            $scope.result.RequestTime = new Date();
            $scope.result.ResponseTime = time / 1000;

        }, function myerror(response) {
            $scope.result.StatusCode = response.statusText;
        })
        console.log("this is the result after clicking ng-click");
    }


    //get
    $scope.GetFunction = function () {
        $http.get('/api/Response').then(function mysuccess(response) {
            $scope.getResult=response;
        }).then(function myerror(response) { });
    }


    //post
    $scope.PostFunction = function () {
        $http.post('/api/Response',
            {
            "StatusCode": $scope.result.StatusCode,
            "URL": $scope.result.URL,
            "ResponseTime": $scope.result.ResponseTime,
            "HttpMethod": $scope.result.HttpMethod,
            "TimeRequest":$scope.result.RequestTime
        }).success(function (response) {
            console.log(response);
        }).error(function (response) { console.log("error");})
    }

    //delete
    $scope.DeleteFunction=function(id)
    {
        $http.delete('/api/Response/' + id).success(function (response) {
            console.log("Successful delete");
            $scope.GetFunction();
        }).error(function (response) {
            console.log("Ops..");
        })
    }

}])

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