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

//.factory('customerFactory', function ($http, $rootScope, USERID, API, $location) {

//function _getCustomers(cb) {
//    var url = API + 'Customers/' + USERID
//    $http.get(url)
//    .success(function(obj){
//        console.log(obj.Data.customer);
//        cb(obj.Data.customer);
//    })
//    .error(function(err){
//        console.log('get customer error: ',err)
//    })
//}

//function _customerUrl(id){
//  if (id) {
//    return API + '/users/' + $rootScope.user.uid +
//      '/customers/' + id + '.json?auth=' + $rootScope.user.token;
//  } else {
//      return API + '/users/' + $rootScope.user.uid +
//      '/customers.json?auth=' +  $rootScope.user.token;
//    }
//  }

//  function _customerUrl(id) {
//      if (id) {
//          return API + 'Customers/' + USERID + '/' + id;
//      } else {
//          return API + 'Customers/' + USERID;
//      }
//  }

//function getCustomer(id, cb){
//  $http.get(_customerUrl(id))
//    .success(function(data){
//      cb(data);
//    })
//    .error(function(err){
//      console.log('Could not get customer');
//    });
//}

//function editCustomer(id, customer){
//  $http.put(_customerUrl(id), customer)
//    .success(function(data){
//      $location.path('/customers');
//    })
//    .error(function(err){
//      console.log('Could not edit customer');
//    });
//}

//function getAllCustomers(cb){
//  $http.get(_customerUrl())
//    .success(function(data){
//      cb(data);
//    })
//    .error(function(err){
//      console.log('Could not get all customers');
//    });
//}

//function createCustomer(customer, cb){
//  $http.post(_customerUrl(), customer)
//    .success(function(data){
//      cb(data);
//      $location.path('/customers');
//    })
//    .error(function(err){
//      console.log('Could not create customer');
//    });
//}

//function deleteCustomer(customerId, cb) {
//  $http.delete(_customerUrl(customerId))
//    .success(function(){
//      cb();
//      $location.path('/customers');
//    })
//    .error(function(err){
//      console.log('Could not delete customer');
//    });
//}