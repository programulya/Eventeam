var home = (function() {
    var isLoaded = false;

    $(document).on("scroll", function() {

        if ($(this).scrollTop() >= $('#services').position().top && isLoaded === false) {
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

            isLoaded = true;
        }
    });
})();