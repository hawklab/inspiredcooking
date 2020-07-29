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
  $('.sidenav').sidenav();

  $('.carousel.carousel-slider').carousel({
    fullWidth: true
  });

  $('.materialboxed').materialbox();

  $('.modal').modal();

  $(".action-copy").click(function(){
    copy($(this).data("copy"));
  });

});

