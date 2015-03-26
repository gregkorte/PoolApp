; (function () {
    'use strict';
    angular.module('poolApp')
    .factory('serviceFactory', function ($http, USERID, API) {
        function _getServices(call) {
            var url = API + 'Services/' + USERID;
            $http.get(url)
            .success(function (data) {
                call(data.Data.services);
            })
            .error(function (err) {
                console.log('get service error: ', err)
            })
        }

        function _getServiceById(id, call) {
            var url = API + 'Services/' + USERID + '/' + id;
            $http.get(url)
            .success(function (data) {
                call(data.Data.service);
            })
            .error(function (err) {
                console.log('get service by id error', err)
            })
        }

        function _postService(service, call) {
            var url = API + 'Services/' + USERID;
            console.log(url);
            $http.get(url, service)
            .success(function (status) {
                console.log(status);
                call(status);
            })
            .error(function (err) {
                console.log('post service error: ', err)
            })
        }

        function _putService(service, call) {
            var url = API + 'Services/' + USERID + '/Edit/' + service.ID;
            console.log(url);
            $http.put(url)
            .success(function (service) {
                console.log("edit sent");
                call(service);
            })
            .error(function (err) {
                console.log('edit service error: ', err)
            })
        }

        function _deleteService(id, call) {
            var url = API + 'Services/' + USERID + '/Delete/' + id;
            console.log(url);
            $http.delete(url)
            .success(function (status) {
                console.log(status);
                call();
            })
            .error(function (err) {
                console.log('delete service error: ', err)
            })
        }

        return {
            getServices: _getServices,
            getServiceById: _getServiceById,
            postService: _postService,
            putService: _putService,
            deleteService: _deleteService
        };
    })
}());