var app = angular.module("fetchNStore", []);

app.controller("fetchButton", function ($scope) {
    $scope.fetchValue = "wakakakaka";
    $scope.methods = ["Get", "Post", "Put", "Delete"];
    console.log($scope.methodSelected);
    $scope.fetchFunction=function()
    {
        console.log("this is the result after clicking ng-click");
    }
    
})