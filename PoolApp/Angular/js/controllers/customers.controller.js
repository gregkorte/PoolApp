;(function(){
	'use strict';

	angular.module('poolApp')
    //.controller('ListCustomersController', function ($routeParams, customerFactory) {
    //    var vm = this;
    //    vm.test = "Customer controller works!";
    //})


    .controller('ListCustomersController', function ($routeParams, customerFactory, $location) {
        var vm = this;
        customerFactory.getCustomers(function (customers) {
            vm.customers = customers;
        })

        vm.removeCustomer = function (id, customer) {
            customerFactory.deleteCustomer(customer.ID, function (customerID) {
                customerFactory.getCustomers(function (customers) {
                    vm.customers = customers;
                })
            });
        }
    })
}());
    //.controller('CustomerController', function(customerFactory){
    //  var vm = this;

    //  vm.addNewCustomer = function(){
    //    customerFactory.createCustomer(vm.newCustomer, function(data){
    //      vm.customers = vm.newCustomer || {};
    //      vm.customers[data.firstName] = vm.newCustomer;
    //      vm.newCustomer = _renewCustomerForm();
    //    });
    //  };

    //  vm.removeCustomer = function(customerId){
    //    customerFactory.deleteCustomer(customerId, function(){
    //      delete vm.customers[customerId];
    //    });
    //  };

    //  vm.newCustomer = _renewCustomerForm();

    //  function _renewCustomerForm(){
    //    return null;
    //  }
    //})
    //.controller('EditCustomerController', function($routeParams, customerFactory){
    //  var vm = this;
    //  var id = $routeParams.id;

    //  customerFactory.getCustomer(id, function(data){
    //    vm.newCustomer = data;
    //  });

    //  vm.addNewCustomer = function(){
    //    customerFactory.editCustomer(id, vm.newCustomer);
    //  };
    //})
    //.controller('ShowCustomerController', function($routeParams, customerFactory){
    //  var vm = this;
    //  var id = $routeParams.id;
    //  customerFactory.getCustomer(id, function(data){
    //    vm.customer = data;
    //  });
    //})
        //Dependency array syntax for deployment//
    