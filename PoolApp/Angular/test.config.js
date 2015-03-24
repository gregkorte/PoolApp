; (function () {
    'use strict';
    angular.module('test')
    .config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/Angular/test.html'
        })
    })
})();