;(function(){
	'use strict';

	angular.module('poolApp')
    .controller('ListServicesController', function ($routeParams, serviceFactory, $location) {
        var vm = this;
        serviceFactory.getServices(function (services) {
            vm.services = services;
        })

        vm.removeService = function (id, service) {
            serviceFactory.deleteService(service.ID, function (serviceID) {
                serviceFactory.getServices(function (services) {
                    vm.services = services;
                })
            })
        }
    })

    .controller('ShowServiceController', function ($routeParams, serviceFactory) {
        var vm = this;
        serviceFactory.getServiceById($routeParams.id, function (service) {
            vm.service = service;
        })
    })

    .controller('ServiceController', function (serviceFactory, $scope) {
      var vm = this;

      //serviceFactory.postService(function(data){
      //  vm.services = data;
      //});

      vm.NewService = function(){
        serviceFactory.postService(vm.newService, function(){
            vm.newService = { ServiceId: service.ID }
            serviceFactory.getServices(service.ID, function (services) {
                vm.services = services;
            })
        });
      };

      vm.removeService = function(serviceId){
        serviceFactory.deleteService(serviceId, function(){
          delete vm.services[serviceId];
        });
      };

      vm.newService = _renewServiceForm();

      function _renewServiceForm(){
        return null;
      }
    });
})();
		
    //.controller('EditServiceController', function($routeParams, serviceFactory){
    //  var vm = this;
    //  var id = $routeParams.id;

    //  serviceFactory.getService(id, function(data){
    //    vm.newService = data;
    //  });

    //  vm.addNewService = function(){
    //    serviceFactory.editService(id, vm.newService);
    //  };

    //})
