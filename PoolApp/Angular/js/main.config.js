;(function(){
  'use strict';
  angular.module('poolApp')
    .config(function($routeProvider){
      $routeProvider
        .when('/', {
          templateUrl: '/Angular/index.html'
        })
    })
}());