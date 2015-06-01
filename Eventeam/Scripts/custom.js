/*------------------------------------------------------------------
Project:    Paperclip
Author:     Yevgeny S.
URL:        http://simpleqode.com/
      https://twitter.com/YevSim
Version:    1.2.0
Created:        11/03/2014
Last change:    18/02/2015
-------------------------------------------------------------------*/

/* ===== Navbar Search ===== */

$('#navbar-search > a').on('click', function() {
  $('#navbar-search > a > i').toggleClass('fa-search fa-times');
  $("#navbar-search-box").toggleClass('show hidden animated fadeInUp');
  return false;
});

/* ===== Navbar Submenu ===== */

/**
 * Dropdown submenu positioning (left or right)
 */

$('ul.dropdown-menu a[data-toggle=dropdown]').hover(function() {
  var menu = $(this).parent().find("ul");
  var menupos = menu.offset();
  if ((menupos.left + menu.width()) + 30 > $(window).width()) {
    $(this).parent().addClass('pull-left');   
  }
  return false;
});

/* ===== Thumbs rating ===== */

$('.rating .voteup').on('click', function () {
  var up = $(this).closest('div').find('.up');
  up.text(parseInt(up.text(),10) + 1);
  return false;
});
$('.rating .votedown').on('click', function () {
  var down = $(this).closest('div').find('.down');
  down.text(parseInt(down.text(),10) + 1);
  return false;
});

/* ===== Responsive Showcase ===== */

$('.responsive-showcase ul > li > i').on('click', function() {
  var device = $(this).data('device');
  $('.responsive-showcase ul > li > i').addClass("inactive");
  $(this).removeClass("inactive");
  $('.responsive-showcase img').removeClass("show");
  $('.responsive-showcase img').addClass("hidden");
  $('.responsive-showcase img' + device).toggleClass("hidden show");
  $('.responsive-showcase img' + device).addClass("animated fadeIn");
  return false;
});

/* ===== Services ===== */

$('.service-item').hover (function() {
  $(this).children("i").toggleClass("fa-rotate-90");
  return false;
});