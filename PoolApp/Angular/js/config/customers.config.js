;(function(){
  'use strict';

  angular.module('poolApp')
    .config(function($routeProvider){
      $routeProvider
	      .when('/customers', {
	        templateUrl: 'Angular/views/customers/customerList.html',
	        controller: 'ListCustomersController',
	        controllerAs: 'customerList',
	        private: true
	      })
	      .when('/customers/new', {
	          templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'CustomerController',
	        controllerAs: 'add',
	        private: true
	      })
	      .when('/customers/:id', {
	          templateUrl: 'Angular/views/customers/customerProfile.html',
	        controller: 'ShowCustomerController',
	        controllerAs: 'show',
	        private: true
	      })
	      .when('/customers/:id/edit', {
	          templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'EditCustomerController',
	        controllerAs: 'add',
	        private: true
	      })
	  })
}());