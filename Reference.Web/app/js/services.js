var services = angular.module('services', []);

services.factory('ReferenceResource', function ($resource) {
    return $resource('../api/vessel/:action',
        //{ id: '@Id' },
        {},
        {
 
        }
    );
});

