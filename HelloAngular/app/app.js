var app = angular.module("myApp", []);

app.controller("FirstCtrl", function ($scope) {
    $scope.model = { firstName: "Gabriel", lastName: "Schenker" };

    $scope.clickMe = function (name) {
        alert("Hello " + name);
    };
});

app.controller("ParentCtrl", function ($scope) {
    $scope.model = { title: "Title set by parent" };
    $scope.greet = function () {
        alert("Hi, I'm the parent.")
    }
});

app.controller("ChildCtrl", function ($scope) {
    $scope.content = "Content set by child";
    $scope.setModel = function () {
        $scope.model = { title: "test from child" };
    }
    $scope.greet = function () {
        alert("Hi, I'm the child.")
    }
});