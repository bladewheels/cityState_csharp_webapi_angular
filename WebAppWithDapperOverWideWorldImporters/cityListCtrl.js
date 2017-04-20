(function () {
    "use strict";
    angular
        .module("cityManagement")
        .controller("CityListCtrl", CityListCtrl);

    CityListCtrl.$inject = ["CityResource", "StateProvinceResource"];

    function CityListCtrl(CityResource, StateProvinceResource) {
        var vm = this;

        CityResource.query(function(data) {
            vm.cities = data;
        });

        StateProvinceResource.query(function(data) {
            vm.states = data;
        });
        
        vm.filterByState = function () {
            CityResource.query({id: vm.selectedState.StateProvinceId})
                .$promise
                .then(function(data) {
                        vm.cities = data;
                }, function(data) {
                    console.log('ERROR: ' + data);  
            });
        };
    }
}());
