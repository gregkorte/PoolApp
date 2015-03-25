;(function(){
  'use strict';

  angular.module('poolApp')
    .config(function($routeProvider){
      $routeProvider
	      .when('/services', {
	          templateUrl: 'Angular/views/services/serviceList.html',
	        controller: 'ServiceController',
	        controllerAs: 'serviceList',
	        private: true
	      })
	      .when('/services/new', {
	          templateUrl: 'Angular/views/services/serviceForm.html',
	        controller: 'ServiceController',
	        controllerAs: 'add',
	        private: true
	      })
	      .when('/services/:id', {
	          templateUrl: 'Angular/views/services/serviceProfile.html',
	        controller: 'ShowServiceController',
	        controllerAs: 'show',
	        private: true
	      })
	      .when('/services/:id/edit', {
	          templateUrl: 'Angular/views/services/serviceForm.html',
	        controller: 'EditServiceController',
	        controllerAs: 'add',
	        private: true
	      })
	  })
}());