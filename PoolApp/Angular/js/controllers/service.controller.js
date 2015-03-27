;(function(){
	'use strict';

    angular.module('poolApp')
    .controller('ServiceController', function (serviceFactory, $scope, USERID, $location) {
        var vm = this;
        vm.newService = { UserID: USERID };
        console.log(vm.newService);

        serviceFactory.getServices(function (services) {
            vm.services = services;
        })

        vm.NewService = function(service){
            serviceFactory.postService(vm.newService, function (service) {
                vm.newService = { UserID: USERID }
                console.log(vm.newService);
                $location.path('/Services');
            })
        }

        vm.removeService = function(serviceId){
            serviceFactory.deleteService(serviceId, function(){
                delete vm.services[serviceId];
            })
        }

        vm.newService = _renewServiceForm();

        function _renewServiceForm(){
            return null;
        }
    })

    .controller('ListServicesController', function ($routeParams, serviceFactory, $location) {
        var vm = this;
        var id = $routeParams.id;
        serviceFactory.getServices(function (services) {
            vm.services = services;
        })

        vm.removeService = function (id, service) {
            serviceFactory.deleteService(id, function (service) {
                serviceFactory.getServices(function (services) {
                    vm.services = services;
                })
            })
        }
    })

    .controller('EditServiceController', function($routeParams, serviceFactory){
      var vm = this;
      var id = $routeParams.id;

      serviceFactory.getServiceById(id, function(data){
          vm.newService = data;
          console.log(data)
      })

      vm.addNewService = function () {
          console.log(id);
          console.log(vm.newService);
        serviceFactory.putService(id, vm.newService);
      }
    })

    .controller('ShowServiceController', function ($routeParams, serviceFactory) {
        var vm = this;
        serviceFactory.getServiceById($routeParams.id, function (service) {
            vm.service = service;
        })
    })
})();
