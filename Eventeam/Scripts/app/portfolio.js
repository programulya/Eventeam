(function() {
    // init Isotope
    var $container = $('#isotope-container').imagesLoaded(function() {
        $container.isotope({
            itemSelector: '.isotope-item',
            layoutMode: 'fitRows'
        });
    });

    // filter items on button click
    $('#filters a').on('click', function() {
        var filterValue = $(this).attr('data-filter');
        $container.isotope({ filter: filterValue });
        return false;
    });
})();