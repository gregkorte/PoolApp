;(function(){
  'use strict';
  angular.module('poolApp')
    .config(function($routeProvider){
        $routeProvider
        .when('/', {
            templateUrl: 'Angular/index.html'
        })

            //CUSTOMERS//
        .when('/Customers/', {
            templateUrl: 'Angular/views/customers/customerList.html',
            controller: 'ListCustomersController',
            controllerAs: 'customerList'
        })
        .when('/Customers/new', {
	        templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'CustomerController',
	        controllerAs: 'add'
	    })
	    .when('/Customers/:id', {
	        templateUrl: 'Angular/views/customers/customerProfile.html',
	        controller: 'ShowCustomerController',
	        controllerAs: 'show'
	    })
	    .when('/Customers/:id/edit/:id', {
	        templateUrl: 'Angular/views/customers/customerForm.html',
	        controller: 'EditCustomerController',
	        controllerAs: 'add'
	    })
	    
        //    //INVOICES//
        //.when('/invoices', {
        //    templateUrl: 'Angular/views/invoices/invoiceList.html',
        //    controller: 'ListInvoiceController',
        //    controllerAs: 'list'
        //})
	    //.when('/invoices/new', {
	    //    templateUrl: 'Angular/views/invoices/invoiceForm.html',
	    //    controller: 'InvoiceController',
	    //    controllerAs: 'modify'
	    //})
	    //.when('/invoices/:id', {
	    //    templateUrl: 'Angular/views/invoices/invoiceProfile.html',
	    //    controller: 'InvoiceProfileController',
	    //    controllerAs: 'view'
	    //})
	    //.when('/invoices/:id/edit/:id', {
	    //    templateUrl: 'Angular/views/invoices/invoiceEditForm.html',
	    //    controller: 'ModifyInvoiceController',
	    //    controllerAs: 'modify'
	    //})

            //PRODUCTS//
        .when('/Products', {
            templateUrl: 'Angular/views/products/productList.html',
            controller: 'ListProductsController',
            controllerAs: 'productList'
        })
	    .when('/Products/new', {
	        templateUrl: 'Angular/views/products/productForm.html',
	        controller: 'ProductController',
	        controllerAs: 'add'
	    })
	    .when('/Products/:id', {
	        templateUrl: 'Angular/views/products/productProfile.html',
	        controller: 'ShowProductController',
	        controllerAs: 'show'
	    })
	    .when('/Products/:id/edit/:id', {
	        templateUrl: 'Angular/views/products/productForm.html',
	        controller: 'EditProductController',
	        controllerAs: 'add'
	    })

            //SERVICES//
        .when('/Services', {
            templateUrl: 'Angular/views/services/serviceList.html',
            controller: 'ListServicesController',
            controllerAs: 'serviceList'
        })
        .when('/Services/new', {
	        templateUrl: 'Angular/views/services/serviceForm.html',
	        controller: 'ServiceController',
	        controllerAs: 'add'
        })
        .when('/Services/:id', {
	        templateUrl: 'Angular/views/services/serviceProfile.html',
	        controller: 'ShowServiceController',
	        controllerAs: 'show'
        })
        .when('/Services/:id/edit', {
	        templateUrl: 'Angular/views/services/serviceForm.html',
	        controller: 'EditServiceController',
	        controllerAs: 'add'
        })
    })
}());