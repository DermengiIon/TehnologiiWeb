$('.dropdown').on('show.bs.dropdown', function(e){
  $(this).find('.dropdown-menu').first().slideDown(300);
});

$('.dropdown').on('hide.bs.dropdown', function(e){
  $(this).find('.dropdown-menu').first().slideUp(200);
});

$(function () {
  $(document).scroll(function () {
    var $nav = $("nav.navbar");
    $nav.toggleClass('scroll', $(this).scrollTop() > $nav.height());
  });
});