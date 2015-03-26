;(function(){
	'use strict';

	angular.module('poolApp')
    //.controller('ListProductsController', function($routeParams){
    //    var vm = this;
    //    vm.test = "Product controller works!";
    //})


    .controller('ListProductsController', function ($routeParams, productFactory, $location) {
        var vm = this;
        productFactory.getProducts(function (products) {
            vm.products = products;
        })

        vm.removeProduct = function (id, product) {
            productFactory.deleteProduct(product.ID, function (productID) {
                productFactory.getProductss(function (products) {
                    vm.products = products;
                })
            });
        }
    })
}());
	//	.controller('ShowProductController', function($routeParams, productFactory){
    //  var vm = this;
    //  var id = $routeParams.id;
    //  productFactory.getProduct(id, function(data){
    //    vm.product = data;
    //  });
    //})
    //.controller('EditProductController', function($routeParams, productFactory){
    //  var vm = this;
    //  var id = $routeParams.id;

    //  productFactory.getProduct(id, function(data){
    //    vm.newProduct = data;
    //  });

    //  vm.addNewProduct = function(){
    //    productFactory.editProduct(id, vm.newProduct);
    //  };

    //})
    //.controller('ProductController', function(productFactory){
    //  var vm = this;

    //  productFactory.getAllProducts(function(data){
    //    vm.products = data;
    //  });

    //  vm.addNewProduct = function(){
    //    productFactory.createProduct(vm.newProduct, function(data){
    //      vm.products = vm.newProduct || {};
    //      vm.products[data.name] = vm.newProduct;
    //      vm.newProduct = _renewProductForm();
    //    });
    //  };

    //  vm.removeProduct = function(productId){
    //    console.log(productId);
    //    productFactory.deleteProduct(productId, function(){
    //      delete vm.products[productId];
    //    });
    //  };

    //  vm.newProduct = _renewProductForm();

    //  function _renewProductForm(){
    //    return null;
    //  }
    //});
