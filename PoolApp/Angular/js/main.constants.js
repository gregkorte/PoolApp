;(function(){
  'use strict';
  angular.module('poolApp')
    .constant('USERID', $('#userID').val())
    .constant('TAX_RATE', 9.25)
    .constant('API', '/api/poolApp/')
})();
