/* -------------------- *\
  #PORTFOLIO
\* -------------------- */

/* Requires isotope.pkgd.min.js & imagesloaded.pkgd.min.js */

/**
 * Isotope filtering
 */

// init Isotope
var $container = $('#isotope-container').imagesLoaded(function () {
    $container.isotope({
        itemSelector: '.isotope-item',
        layoutMode: 'fitRows'
    });
});
// filter items on button click
$('#filters a').on('click', function () {
    var filterValue = $(this).attr('data-filter');
    $container.isotope({ filter: filterValue });
    return false;
});

$(document).ready(function () {
    var galleryList = model.GalleryPhotoList,
        imgList = [],
        itemsOnPage = 8;
    var lastItemIndex = galleryList.length - 1 < itemsOnPage
        ? galleryList.length - 1
        : itemsOnPage - 1;
    var defaultOptions = {
        firstItemIndex: 0,
        lastItemIndex: lastItemIndex,
        maxItemsOnPage: 8
    }

    var getGalleryContent = function (options) {
        var galleryContent = '';
        for (var i = options.firstItemIndex, size = galleryList.length - 1; i <= size; i++) {
            var defaultOptions = i < options.maxItemsOnPage
                ? {}
                : { style: 'style="display: none;"' };
            var portfolioOpt = $.extend(defaultOptions, {
                linkResponsive: galleryList[i].LinkResponsive,
                alt: galleryList[i].Alt,
                href: galleryList[i].Link
            });
            
            galleryContent += generatePhotoItem(portfolioOpt);
        }

        return galleryContent;
    }

    function generatePhotoItem(options) {
        var opt = $.extend({}, options);
        return '<div class="col-sm-3 portfolio-photo"' + opt.style + '>' +
                    '<div class="portfolio-item">' +
                    '<div class="portfolio-thumbnail">' +
                    '<img class="img-responsive" src="' + prepareLink(opt['linkResponsive']) + '" alt="' + opt['alt'] + '">' +
                    '<div class="mask">' +
                    '<p class="zoom-in">' +
                    '<a href="' + prepareLink(opt['href']) + '" data-lightbox="template_showcase"><i class="fa fa-search-plus fa-2x"></i></a>' +
                    '</p>' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '</div>';
    }

    $('#photo-gallery').html(getGalleryContent(defaultOptions));

    $('#page-selection').bootpag({
        total: Math.ceil(galleryList.length / itemsOnPage)
    }).on('page', function (event, num) {
        // do this here due to possibility of not full load of content
        if (!imgList.length > 0) {
            $('div.portfolio-photo').each(function (index, value) {
                imgList.push(value);
            });
        }
        removePhotoContent();
        var options = $.extend({}, defaultOptions, getModifiedOptions({
            itemsOnPage: itemsOnPage,
            num: num,
            content: galleryList
        }));
        for (var i = options.firstItemIndex; i <= options.lastItemIndex; i++) {
            $(imgList[i]).css({ 'display': 'inline-block' });
        }
    });

    function getModifiedOptions(pageOpt) {
        var lastItemIndex = pageOpt.itemsOnPage * pageOpt.num - 1;
        var modifiedOptions;

        if (pageOpt.content.length < lastItemIndex) {
            lastItemIndex = pageOpt.content.length - 1;
            var previousPageLastIndex = pageOpt.itemsOnPage * (pageOpt.num - 1);
            modifiedOptions = {
                lastItemIndex: lastItemIndex,
                firstItemIndex: previousPageLastIndex
            };
        } else {
            modifiedOptions = {
                lastItemIndex: lastItemIndex,
                firstItemIndex: lastItemIndex - (pageOpt.itemsOnPage - 1)
            };
        }
        return modifiedOptions;
    }

    function removePhotoContent() {
        $('div.portfolio-photo:visible').css({ 'display': 'none' });
    }
});