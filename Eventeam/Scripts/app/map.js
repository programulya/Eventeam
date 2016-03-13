var map = (function() {
    'use strict';

    /*** PRIVATE ***/

    function createMap(latitude, longitude, address) {
        var canvas = document.getElementById('canvasHotel');
        var position = new google.maps.LatLng(latitude, longitude);

        var mapOptions = {
            scrollwheel: false,
            center: position,
            zoom: 10,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }

        var map = new google.maps.Map(canvas, mapOptions);

        var marker = new google.maps.Marker({
            position: position,
            map: map,
            title: address
        });
    }

    function init(latitude, longitude, address) {
        google.maps.event.addDomListener(window, 'load', createMap(latitude, longitude, address));
    }

    /*** PUBLIC ***/

    return {
        init: init
    };
}());