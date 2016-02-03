var home = (function() {
    var isCounters = false;
    var isServices = false;

    $(document).on("scroll", function() {

        if ($(this).scrollTop() >= $('#services').position().top && isCounters === false) {
            $('#countries').jQuerySimpleCounter({
                end: 7,
                duration: 7000
            });

            $('#cities').jQuerySimpleCounter({
                end: 28,
                duration: 7000
            });

            $('#concepts').jQuerySimpleCounter({
                end: 267,
                duration: 7000
            });

            $('#projects').jQuerySimpleCounter({
                end: 365,
                duration: 7000
            });

            isCounters = true;
        }

        if ($(this).scrollTop() >= $('#home-slider').position().top && isServices === false) {
            $('#services .services-area').css('visibility', 'visible');
            $('#conferences').addClass('animated fadeInDown delay-1');
            $('#mice').addClass('animated fadeInUp delay-2');
            $('#teamBuildings').addClass('animated fadeInUp delay-3');
            $('#events').addClass('animated slideInRight delay-4');
            $('#children').addClass('animated slideInLeft delay-5');
            $('#weddings').addClass('animated fadeInDown delay-6');
            $('#cathering').addClass('animated fadeInDown delay-7');
            $('#production').addClass('animated slideInRight delay-8');

            isServices = true;
        }
    });
})();