/*------------------------------------------------------------------
Project:    Paperclip
Author:     Yevgeny S.
URL:        http://simpleqode.com/
      https://twitter.com/YevSim
Version:    1.2.0
Created:        11/03/2014
Last change:    18/02/2015
-------------------------------------------------------------------*/

/* -------------------- *\
  #PORTFOLIO
\* -------------------- */

/* Requires isotope.pkgd.min.js & imagesloaded.pkgd.min.js */

/**
 * Isotope filtering
 */

// init Isotope
var $container = $('#isotope-container').imagesLoaded( function() {
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

$(document).ready(function () {
    var galleryList = model.GalleryPhotoList;
    var itemsOnPage = 4;
    var defaultOptions = {
        firstItemIndex: 0,
        lastItemIndex: itemsOnPage - 1
    }

    var prepareLink = function (rawStringLink) {
        return rawStringLink.replace(/~/, getContextPath());
    }

    var getGalleryContent = function (options) {
        var galleryContent = '';
        for (var i = options.firstItemIndex, size = options.lastItemIndex; i < size; i++) {
            var porfolioItem = '<div class="col-sm-3">' +
                '<div class="portfolio-item">' +
                    '<div class="portfolio-thumbnail">' +
                    '<img class="img-responsive" src="' + prepareLink(galleryList[i].LinkResponsive) + '" alt="' + galleryList[i].Alt + '">' +
                    '<div class="mask">' +
                    '<p class="zoom-in">' +
                    '<a href="' + prepareLink(galleryList[i].Link) + '" data-lightbox="template_showcase"><i class="fa fa-search-plus fa-2x"></i></a>' +
                    '</p>' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '</div>';
            galleryContent += porfolioItem;
        }
        return galleryContent;
    }
    $('#photo-gallery').html(getGalleryContent(defaultOptions));

    $('#page-selection').bootpag({
        total: Math.ceil(galleryList.length / itemsOnPage)
    }).on("page", function (event, num) {
        var lastItem = itemsOnPage * num - 1;
        var modifiedOptions = {
            lastItemIndex: lastItem,
            firstItemIndex: lastItem - (itemsOnPage - 1)
        };
        var options = $.extend({}, defaultOptions, modifiedOptions);
        $("#photo-gallery").html(getGalleryContent(options));
    });
});