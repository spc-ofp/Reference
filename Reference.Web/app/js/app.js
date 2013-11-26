var ReferenceApp = angular.module("ReferenceApp", ['ngRoute', 'services', 'ngResource', 'controllers', 'directives', 'ngAnimate']).
    config(function ($routeProvider) {
        $routeProvider.
            when('/edit/:itemId', { controller: 'ReferenceEditCtrl', templateUrl: 'views/ReferenceDetail.html' }).
            when('/new', { controller: 'ReferenceCreateCtrl', templateUrl: 'views/ReferenceDetail.html' }).
            when('/', { controller: 'ReferenceListCtrl', templateUrl: 'views/ReferenceList.html' }).
            //when('/test', { controller: 'ObsvMasterListCtrlNew', templateUrl: 'partials/ObsvMasterListNew.html' }).
            otherwise({ redirectTo: '/' });
    });