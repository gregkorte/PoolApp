;(function(){
  'use strict';
  angular.module('poolApp')
    .factory('invoiceFactory', function($rootScope, FIREBASE_URL, $http, $location){

      function _invoiceUrl(id){
        if (id) {
          return FIREBASE_URL + '/users/' + $rootScope.user.uid +
            '/invoices/' + id + '.json?auth=' + $rootScope.user.token;
        } else {
            return FIREBASE_URL + '/users/' + $rootScope.user.uid +
            '/invoices.json?auth=' +  $rootScope.user.token;
          }
      }

      function getInvoice(id, cb){
        $http.get(_invoiceUrl(id))
          .success(function(data){
            cb(data);
            console.log('Success: Got invoice');
          })
          .error(function(err){
            console.log('Fail: Could not get invoice');
          });
      }

      function editInvoice(id, invoice){
        $http.put(_invoiceUrl(id), invoice)
          .success(function(data){
            $location.path('/invoices');
            console.log('Success: Edited invoice');
          })
          .error(function(err){
            console.log('Fail: Could not edit invoice');
          });
      }

      function getAllInvoices(cb){
        $http.get(_invoiceUrl())
          .success(function(data){
            cb(data);
            console.log('Success: Got all invoices');
          })
          .error(function(err){
            console.log('Fail: Could not get all invoices');
          });
      }

      function createInvoice(invoice, cb){
        console.log(invoice);
        $http.post(_invoiceUrl(), invoice)
          .success(function(data){
            cb(data);
            $location.path('/invoices');
            console.log('Success: Created invoice');
          })
          .error(function(err){
            console.log('Fail: Could not create invoice');
          });
      }

      function deleteInvoice(invoiceId, cb) {
        $http.delete(_invoiceUrl(invoiceId))
          .success(function(){
            cb();
            $location.path('/invoices');
            console.log('Success: Deleted invoice');
          })
          .error(function(err){
            console.log('Fail: Could not delete invoice');
          });
      }

      return {
        getInvoice: getInvoice,
        editInvoice: editInvoice,
        getAllInvoices: getAllInvoices,
        createInvoice: createInvoice,
        deleteInvoice: deleteInvoice
      };
    })
}());