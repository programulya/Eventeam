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
                '<a class="btn btn-sm btn-theme-secondary" href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '">' + '<i class="fa"></i>Обзор</a>' +
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
                '<a class="btn btn-sm btn-theme-secondary" href="' + getContextPath() + '/Platforms/Platform/' + platforms[i].platformId + '">' + '<i class="fa"></i>Обзор</a>' +
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
            $('#hotels').html(renderPlatforms(data));
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
            $('#restaurants').html(renderRestaurants(data));
        });

        request.fail(function(jqXhr, textStatus) {
            console.log('Failed: ' + textStatus + ', ' + jqXhr);
        });

        request.always(function() {
            $('#divLoading').hide();
        });
    }

    (function init() {
        var substringMatcher = function (strs) {
            return function findMatches(q, cb) {         
                // regex used to determine if a string contains the substring `q`
                var substringRegex = new RegExp(q, 'i');

                // an array that will be populated with substring matches
                var matches = [];

                // iterate through the pool of strings and for any string that
                // contains the substring `q`, add it to the `matches` array
                $.each(strs, function (i, str) {
                    if (substringRegex.test(str)) {
                        matches.push(str);
                    }
                });

                cb(matches);
            };
        };

        var states = ['Alabama', 'Alaska', 'Arizona', 'Arkansas', 'California',
          'Colorado', 'Connecticut', 'Delaware', 'Florida', 'Georgia', 'Hawaii',
          'Idaho', 'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana',
          'Maine', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota',
          'Mississippi', 'Missouri', 'Montana', 'Nebraska', 'Nevada', 'New Hampshire',
          'New Jersey', 'New Mexico', 'New York', 'North Carolina', 'North Dakota',
          'Ohio', 'Oklahoma', 'Oregon', 'Pennsylvania', 'Rhode Island',
          'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont',
          'Virginia', 'Washington', 'West Virginia', 'Wisconsin', 'Wyoming'
        ];

        $('.typeahead').typeahead({
            hint: true,
            highlight: true,
            minLength: 1
        },
        {
            name: 'states',
            source: substringMatcher(states)
        });

        getPlatforms();
        getRestaurants();
    })();

    /*** PUBLIC ***/

    return {
        getPlatforms: getPlatforms,
        getRestaurants: getRestaurants
    };
}());