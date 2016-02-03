var platforms = (function() {
    'use strict';

    /*** PRIVATE ***/

    function renderPlatforms(platforms) {
        var content = '';
        for (var i = 0; i < platforms.length; ++i) {
            var platform = '<div class="col-sm-4">' +
                '<div class="shop-product">' +
                '<a href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '"><img src=' + prepareLink(platforms[i].mainPhoto.link) + ' class="img-responsive" alt=' + platforms[i].mainPhoto.alt + '></a>' +
                '<a href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '"><h5 class="primary-font">' + platforms[i].name + '</h5></a>' +
                '<p class="text-muted">' + platforms[i].address +
                '</p>' +
                '<p>' + platforms[i].cityName +
                '</p>' +
                '<a class="btn btn-sm btn-theme-secondary" href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '">' + '<i class="fa fa-shopping-cart"></i> Обзор</a>' +
                '</div>' +
                '</div>';

            content += platform;
        }

        return content;
    }

    function renderRestaurants(platforms) {
        var content = '';
        for (var i = 0; i < platforms.length; ++i) {
            var platform = '<div class="col-sm-4">' +
                '<div class="shop-product">' +
                '<a href="' + getContextPath() + '/Platforms/Restaurant/' + platforms[i].RestaurantId + '"><img src=' + prepareLink(platforms[i].mainPhoto.link) + ' class="img-responsive" alt=' + platforms[i].mainPhoto.alt + '></a>' +
                '<a href="' + getContextPath() + '/Platforms/Restaurant/' + platforms[i].Name + '"><h5 class="primary-font">' + platforms[i].name + '</h5></a>' +
                '<p class="text-muted">' + platforms[i].RestaurantId +
                '</p>' +
                '<p>' + platforms[i].RestaurantId +
                '</p>' +
                '<a class="btn btn-sm btn-theme-secondary" href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '">' + '<i class="fa fa-shopping-cart"></i> Обзор</a>' +
                '</div>' +
                '</div>';

            content += platform;
        }

        return content;
    }

    function getPlatforms() {
        $('#divLoading').show();

        var request = $.ajax({
            url: getContextPath() + '/api/platforms',
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            timeout: 15000
        });

        request.done(function(data) {
            $('#popular').html(renderPlatforms(data));
        });

        request.fail(function(jqXhr, textStatus) {
            console.log('Failed: ' + textStatus + ', ' + jqXhr);
        });

        request.always(function() {
            $('#divLoading').hide();
        });
    }

    function getRestaurants() {
        $('#divLoading').show();

        var request = $.ajax({
            url: getContextPath() + '/api/restaurants',
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            timeout: 15000
        });

        request.done(function(data) {
            $('#recommended').html(renderRestaurants(data));
        });

        request.fail(function(jqXhr, textStatus) {
            console.log('Failed: ' + textStatus + ', ' + jqXhr);
        });

        request.always(function() {
            $('#divLoading').hide();
        });
    }

    (function init() {
        getPlatforms();
        getRestaurants();    
    })();

    /*** PUBLIC ***/

    return {
        getPlatforms: getPlatforms,
        getRestaurants: getRestaurants
    };
}());