/// <reference path="angular.js" />
var app = angular.module("step4App", []);

app.controller("FriendsCtrl", function ($scope, $http) {
    $scope.loadFriends = function () {
        $http.get("api/friends").success(function (data) {
            $scope.friends = data;
        }).error(function () {
            alert("an unexpected error ocurred!");
        });
    }
});