/// <reference path="../angular.js" />

var app = angular.module("myApp", []);
app.controller("PersonCtrl", function ($scope) {
    $scope.persons = [
        { first: "Henry", middle: "Jacob", last: "Mendocino", gender: "M" },
        { first: "Ann", middle: "Cecilia", last: "Negro", gender: "F" },
        { first: "Berta", middle: "Ann", last: "Sallyfield", gender: "F" },
        { first: "Rudolf", middle: "John", last: "Waters", gender: "M" },
        { first: "Ken", middle: "Adam", last: "Aundry", gender: "M" },
    ];
})

app.controller("QuestionnaireCtrl", function ($scope) {
    $scope.questionnaire = [
        { number: "1", question: "How old are you?", type: "number" },
        { number: "2", question: "You date of birth?", type: "date" },
        { number: "3", question: "Describe yourself in a few words.", type: "text" },
        { number: "4", question: "Which is you favorite color?", type: "singleOption" },
        { number: "5", question: "Which of the following sweets do you like?", type: "multiOption" },
    ]
})

app.controller("TreeCtrl", function ($scope) {
    $scope.tree = [
        {
            name: "Parent 1",
            children: [
                {
                    name: "Child 1.1",
                    children: [
                        { name: "Grandchild 1.1.1" },
                        { name: "Grandchild 1.1.2" },
                        { name: "Grandchild 1.1.3" },
                    ]
                },
                { name: "Child 1.2" },
                { name: "Child 1.3" },
            ]
        },
        {
            name: "Parent 2",
            children: [
                { name: "Child 2.1" },
                { name: "Child 2.2" },
                { name: "Child 2.3" },
            ]
        },
        { name: "Parent 3" },
        { name: "Parent 4" },
        { name: "Parent 5" },
    ];
})