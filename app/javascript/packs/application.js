// This file is automatically compiled by Webpack, along with any other files
// present in this directory. You're encouraged to place your actual application logic in
// a relevant structure within app/javascript and only use these pack files to reference
// that code so it'll be compiled.

require("@rails/ujs").start()
require("turbolinks").start()
const copy = require('clipboard-copy')


// Uncomment to copy all static images under ../images to the output folder and reference
// them with the image_pack_tag helper in views (e.g <%= image_pack_tag 'rails.png' %>)
// or the `imagePath` JavaScript helper below.
//
// const images = require.context('../images', true)
// const imagePath = (name) => images(name, true)

// $('.carousel.carousel-slider').carousel({
//   fullWidth: true
// });

// var instance = M.Carousel.init({
//   fullWidth: true
// });


$(document).ready(function(){

  $('.carousel.carousel-slider').carousel({
    fullWidth: true
  });

  $('.materialboxed').materialbox();



  $(".action-copy").click(function(){
    copy($(this).data("copy"));
  });

});

$(document).on('turbolinks:load', function(){
  $('.sidenav').sidenav()
  // https://github.com/mkhairi/materialize-sass/issues/162#issuecomment-375530286
  M.Modal._count = 0;
  $('.modal').modal();
})

$(document).on('turbolinks:before-cache', function(){
  sidenav = $('.sidenav')
  sidenavInstance = M.Sidenav.getInstance(sidenav)
  sidenavInstance.destroy()
})




