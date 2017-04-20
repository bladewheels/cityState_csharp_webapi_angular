(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("CityResource", CityResource);

    CityResource.$inject = ["$resource"];

    function CityResource($resource) {
        return $resource("/api/city/:id");
    }
})();