(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("StateProvinceResource", StateProvinceResource);

    StateProvinceResource.$inject = ["$resource"];

    function StateProvinceResource($resource) {
        return $resource("/api/StateProvince/:id");
    }
})();