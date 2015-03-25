;(function(){
  'use strict';
  angular.module('poolApp')
    .config(function($routeProvider){
        $routeProvider
        .when('/', {
            templateUrl: '/Angular/index.html',
            controller: 'mainController'
        })
            //CUSTOMERS//
        .when('/customers', {
            templateUrl: 'Angular/views/customers/customerList.html',
            controller: 'ListCustomersController',
            controllerAs: 'customerList'
        })
	    .when('/customers/new', {
	        templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'CustomerController',
	        controllerAs: 'add'
	    })
	    .when('/customers/:id', {
	        templateUrl: 'Angular/views/customers/customerProfile.html',
	        controller: 'ShowCustomerController',
	        controllerAs: 'show'
	    })
	    .when('/customers/:id/edit', {
	        templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'EditCustomerController',
	        controllerAs: 'add'
	    })
            //INVOICES//
        .when('/invoices', {
            templateUrl: 'Angular/views/invoices/invoiceList.html',
            controller: 'ListInvoiceController',
            controllerAs: 'list'
        })
	    .when('/invoices/new', {
	        templateUrl: 'Angular/views/invoices/invoiceForm.html',
	        controller: 'InvoiceController',
	        controllerAs: 'modify'
	    })
	    .when('/invoices/:id', {
	        templateUrl: 'Angular/views/invoices/invoiceProfile.html',
	        controller: 'InvoiceProfileController',
	        controllerAs: 'view'
	    })
	    .when('/invoices/:id/edit', {
	        templateUrl: 'Angular/views/invoices/invoiceEditForm.html',
	        controller: 'ModifyInvoiceController',
	        controllerAs: 'modify'
	    })
            //PRODUCTS//
        .when('/products', {
            templateUrl: 'Angular/views/products/productList.html',
            controller: 'ProductController',
            controllerAs: 'productList'
        })
	    .when('/products/new', {
	        templateUrl: 'Angular/views/products/productForm.html',
	        controller: 'ProductController',
	        controllerAs: 'add'
	    })
	    .when('/products/:id', {
	        templateUrl: 'Angular/views/products/productProfile.html',
	        controller: 'ShowProductController',
	        controllerAs: 'show'
	    })
	    .when('/products/:id/edit', {
	        templateUrl: 'Angular/views/products/productForm.html',
	        controller: 'EditProductController',
	        controllerAs: 'add'
	    })
            //SERVICES//
        .when('/services', {
            templateUrl: 'Angular/views/services/serviceList.html',
            controller: 'ServiceController',
            controllerAs: 'serviceList'
        })
	      .when('/services/new', {
	          templateUrl: 'Angular/views/services/serviceForm.html',
	          controller: 'ServiceController',
	          controllerAs: 'add'
	      })
	      .when('/services/:id', {
	          templateUrl: 'Angular/views/services/serviceProfile.html',
	          controller: 'ShowServiceController',
	          controllerAs: 'show'
	      })
	      .when('/services/:id/edit', {
	          templateUrl: 'Angular/views/services/serviceForm.html',
	          controller: 'EditServiceController',
	          controllerAs: 'add'
	      })
    })
}());