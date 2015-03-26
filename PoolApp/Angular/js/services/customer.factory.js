;(function(){
  'use strict';
    angular.module('poolApp')
    .factory('customerFactory', function($http, USERID, API) {
        function _getCustomers(call) {
            var url = API + 'Customers/' + USERID;
            console.log(url);
            $http.get(url)
            .success(function (data) {
                console.log(data.Data.customers);
                call(data.Data.customers);
            })
            .error(function(err) {
                console.log('get customer error: ', err)
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
            var url = API + 'Customers/' + USERID + '/Edit/' + customer.ID;
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
            var url = API + 'Customers/' + USERID + '/Delete/' + id;
            console.log(url);
            $http.delete(url)
            .success(function (status) {
                console.log(status);
                call();
            })
            .error(function (err) {
                console.log('delete customer error: ', err)
            })
        }

      return {
        getCustomers: _getCustomers,
        postCustomer: _postCustomer,
        putCustomer: _putCustomer,
        deleteCustomer: _deleteCustomer
      };
    })
}());