; (function () {
    'use strict';
    angular.module('poolApp')
    .factory('productFactory', function ($http, USERID, API) {
        function _getProducts(call) {
            var url = API + 'Products/' + USERID;
            $http.get(url)
            .success(function (data) {
                call(data.Data.products);
            })
            .error(function (err) {
                console.log('get product error: ', err)
            })
        }

        function _getProductById(id, call) {
            var url = API + 'Products/' + USERID + '/' + id;
            $http.get(url)
            .success(function (data) {
                call(data.Data.product);
            })
            .error(function (err) {
                console.log('get product by id error', err)
            })
        }

        function _postProduct(product, call) {
            var url = API + 'Products/' + USERID;
            console.log(url);
            $http.get(url, product)
            .success(function (status) {
                console.log(status);
                call(status);
            })
            .error(function (err) {
                console.log('post product error: ', err)
            })
        }

        function _putProduct(product, call) {
            var url = API + 'Products/' + USERID + '/Edit/' + product.ID;
            console.log(url);
            $http.put(url)
            .success(function (product) {
                console.log("edit sent");
                call(product);
            })
            .error(function (err) {
                console.log('edit product error: ', err)
            })
        }

        function _deleteProduct(id, call) {
            var url = API + 'Products/' + USERID + '/Delete/' + id;
            $http.delete(url)
            .success(function (status) {
                call();
            })
            .error(function (err) {
                console.log('delete product error: ', err)
            })
        }

        return {
            getProducts: _getProducts,
            getProductById: _getProductById,
            postProduct: _postProduct,
            putProduct: _putProduct,
            deleteProduct: _deleteProduct
        };
    })
}());