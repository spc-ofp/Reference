var controllers = angular.module('controllers', []);

controllers.controller("ReferenceListCtrl", function ($scope, $location, $routeParams, ReferenceResource) {
    $scope.MyVessels = ReferenceResource.query();
    return $scope;
});


