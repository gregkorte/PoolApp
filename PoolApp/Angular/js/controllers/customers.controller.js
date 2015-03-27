;(function(){
	'use strict';

    angular.module('poolApp')
    .controller('CustomerController', function(customerFactory){
      var vm = this;

      vm.NewCustomer = function(){
        customerFactory.createCustomer(vm.newCustomer, function(data){
          vm.customers = vm.newCustomer || {};
          vm.customers[data.firstName] = vm.newCustomer;
          vm.newCustomer = _renewCustomerForm();
        });
      };

      vm.removeCustomer = function (id, customer) {
          console.log(id);
        customerFactory.deleteCustomer(id, function (customer) {
            customerFactory.getCustomers(function (customers) {
                vm.customers = customers;
            })
        })
      }

      vm.newCustomer = _renewCustomerForm();

      function _renewCustomerForm(){
        return null;
      }
    })

    .controller('ListCustomersController', function ($routeParams, customerFactory, $location) {
        var vm = this;
        var id = $routeParams.id;
        customerFactory.getCustomers(function (customers) {
            vm.customers = customers;
        })

        vm.removeCustomer = function (id, customer) {
            customerFactory.deleteCustomer(id, function (customer) {
                customerFactory.getCustomers(function (customers) {
                    vm.customers = customers;
                })
            })
        }
    })

    .controller('EditCustomerController', function($routeParams, customerFactory){
      var vm = this;
      var id = $routeParams.id;

      customerFactory.getCustomerById(id, function(data){
        vm.newCustomer = data;
      });

      vm.NewCustomer = function(){
        customerFactory.putCustomer(id, vm.newCustomer);
      };
    })

    .controller('ShowCustomerController', function($routeParams, customerFactory){
        var vm = this;
        customerFactory.getCustomerById($routeParams.id, function (customer) {
            vm.customer = customer;
        })
     })
}());