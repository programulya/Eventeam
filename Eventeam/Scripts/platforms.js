var platforms = (function() {
    'use strict';

    /*** PRIVATE ***/
    (function init() {
        getHotels();
    })();

    function getHotels() {
        var request = $.ajax({
            url: getContextPath() + '/api/hotels',
            type: "GET",
            dataType: 'json',
            contentType: 'application/json; charset=utf-8'
        });

        request.done(function(data) {
            $('#popular').html(renderHotels(data));
        });

        request.fail(function(jqXhr, textStatus) {
            console.log('Failed: ' + textStatus + ', ' + jqXhr);
        });
    }

    function renderHotels(hotels) {
        var content = '';
        for (var i = 0; i < hotels.length; ++i) {
            var hotel = '<div class="col-sm-4">' +
                '<div class="shop-product">' +
                '<a href="@Url.Action("ShopItem", "Home")"><img src=' + prepareLink(hotels[i].mainPhoto.link) + ' class="img-responsive" alt=' + hotels[i].mainPhoto.alt + '></a>' +
                '<a href="@Url.Action("ShopItem", "Home")"><h5 class="primary-font">' + hotels[i].name + '</h5></a>' +
                '<p class="text-muted">' + hotels[i].platformAddress +
                '</p>' +
                '<p>' + hotels[i].platformCityName +
                '</p>' +
                '<a href="#" class="btn btn-sm btn-theme-secondary"><i class="fa fa-shopping-cart"></i> Обзор</a>' +
                '</div>' +
                '</div>';

            content += hotel;
        }

        return content;
    }

    /*** PUBLIC ***/

    return {
        getHotels: getHotels
    };
}());