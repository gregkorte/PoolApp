;(function(){
  'use strict';
    angular.module('poolApp')
    .factory('customerFactory', function($http, USERID, API) {
        function _getCustomers(call) {
            var url = API + 'Customers/' + USERID;
            $http.get(url)
            .success(function (data) {
                call(data.Data.customers);
            })
            .error(function(err) {
                console.log('get customer error: ', err)
            })
        }

        function _getCustomerById(id, call) {
            var url = API + 'Customers/' + USERID + '/' + id;
            $http.get(url)
            .success(function (data) {
                call(data.Data.customer);
            })
            .error(function (err) {
                console.log('get customer by id error', err)
            })
        }

        function _postCustomer(customer, call) {
            var url = API + 'Customers/' + USERID;
            console.log(url);
            $http.get(url, customer)
            .success(function (status) {
                console.log(status);
                call(status);
            })
            .error(function (err) {
                console.log('post customer error: ', err)
            })
        }

        function _putCustomer(customer, call) {
            var url = API + 'Customers/' + USERID + '/edit/' + customer.ID;
            console.log(url);
            $http.put(url)
            .success(function (customer) {
                console.log("edit sent");
                call(customer);
            })
            .error(function (err) {
                console.log('edit customer error: ', err)
            })
        }

        function _deleteCustomer(id, call) {
            var url = API + 'Customers/' + USERID + '/delete/' + id;
            $http.delete(url)
            .success(function (status) {
                call();
            })
            .error(function (err) {
                console.log('delete customer error: ', err)
            })
        }

      return {
        getCustomers: _getCustomers,
        getCustomerById: _getCustomerById,
        postCustomer: _postCustomer,
        putCustomer: _putCustomer,
        deleteCustomer: _deleteCustomer
      };
    })
}());