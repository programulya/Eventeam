var platforms = (function() {
    'use strict';

    /*** PRIVATE ***/
    (function init() {
        getPlatforms();
    })();

    function getPlatforms() {
        var request = $.ajax({
            url: getContextPath() + '/api/hotels',
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8'
        });

        request.done(function(data) {
            $('#popular').html(renderPlatforms(data));
        });

        request.fail(function(jqXhr, textStatus) {
            console.log('Failed: ' + textStatus + ', ' + jqXhr);
        });
    }

    function renderPlatforms(platforms) {
        var content = '';
        for (var i = 0; i < platforms.length; ++i) {
            var platform = '<div class="col-sm-4">' +
                '<div class="shop-product">' +
                '<a href="' + getContextPath() + '/Platforms/Hotel/' + platforms[i].platformId + '"><img src=' + prepareLink(platforms[i].mainPhoto.link) + ' class="img-responsive" alt=' + platforms[i].mainPhoto.alt + '></a>' +
                '<a href="' + getContextPath() + '/Platforms/Hotel/' + platforms[i].platformId + '"><h5 class="primary-font">' + platforms[i].platformName + '</h5></a>' +
                '<p class="text-muted">' + platforms[i].platformAddress +
                '</p>' +
                '<p>' + platforms[i].platformCityName +
                '</p>' +
                '<a class="btn btn-sm btn-theme-secondary" href="' + getContextPath() + '/Platforms/Hotel/' + platforms[i].hotelId + '">' + '<i class="fa fa-shopping-cart"></i> Обзор</a>' +
                '</div>' +
                '</div>';

            content += platform;
        }

        return content;
    }

    /*** PUBLIC ***/

    return {
        getPlatforms: getPlatforms
    };
}());