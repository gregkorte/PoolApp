; (function () {
    'use strict';
    angular.module('poolApp')
    .factory('invoiceFactory', function ($http, USERID, API) {
        function _getInvoices(call) {
            var url = API + 'Invoices/' + USERID;
            $http.get(url)
            .success(function (data) {
                call(data.Data.invoices);
            })
            .error(function (err) {
                console.log('get invoice error: ', err)
            })
        }

        function _getInvoiceById(id, call) {
            var url = API + 'Invoices/' + USERID + '/' + id;
            $http.get(url)
            .success(function (data) {
                call(data.Data.invoice);
            })
            .error(function (err) {
                console.log('get invoice by id error', err)
            })
        }

        function _postInvoice(invoice, call) {
            var url = API + 'Invoices/' + USERID;
            console.log(url);
            $http.get(url, invoice)
            .success(function (status) {
                console.log(status);
                call(status);
            })
            .error(function (err) {
                console.log('post invoice error: ', err)
            })
        }

        function _putInvoice(invoice, call) {
            var url = API + 'Invoices/' + USERID + '/edit/' + invoice.ID;
            console.log(url);
            $http.put(url)
            .success(function (invoice) {
                console.log("edit sent");
                call(invoice);
            })
            .error(function (err) {
                console.log('edit invoice error: ', err)
            })
        }

        function _deleteInvoice(id, call) {
            var url = API + 'Invoices/' + USERID + '/delete/' + id;
            console.log(url);
            $http.delete(url)
            .success(function (status) {
                console.log(status);
                call();
            })
            .error(function (err) {
                console.log('delete invoice error: ', err)
            })
        }

        return {
            getInvoices: _getInvoices,
            getInvoiceById: _getInvoiceById,
            postInvoice: _postInvoice,
            putInvoice: _putInvoice,
            deleteInvoice: _deleteInvoice
        };
    })
}());