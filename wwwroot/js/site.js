// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
  //-------SLIDERS

  $("#main-slider").slick({
    autoplay: true,
    dots: true,
    draggable: true,
    infinite: true,
    mobileFirst: true,
    pauseOnFocus: false,
    prevArrow:
      '<div class="main-prev-btn"><i class="bi bi-chevron-left"></i></div>',
    nextArrow:
      '<div class="main-next-btn"><i class="bi bi-chevron-right"></i></div>',
    responsive: [
      {
        breakpoint: 1000,
        settings: {
          arrows: true,
        },
      },
      {
        breakpoint: 600,
        settings: {
          arrows: false,
        },
      },
      {
        breakpoint: 200,
        settings: {
          arrows: false,
        },
      },
    ],
  });

  $("#category-slider").slick({
    slidesToShow: 5,
    slidesToScroll: 12,
    autoplay: true,
    infinite: true,
    variableWidth: true,
    centerMode: true,
    mobileFirst: true,
    swipeToSlide:true,
    pauseOnFocus: false,
    arrows: true,
    prevArrow:
      '<button class="btn btn-sm prev-category rounded-0 btn-light"><i class="bi bi-chevron-left"></i></button>',
    nextArrow:
      '<button class="btn btn-sm next-category rounded-0 btn-light"><i class="bi bi-chevron-right"></i></button>',
    responsive: [
      {
        breakpoint: 1000,
        settings: {
          arrows: true,
        },
      },
      {
        breakpoint: 600,
        settings: {
          arrows: false,
        },
      },
      {
        breakpoint: 200,
        settings: {
          arrows: false,
        },
      },
    ],
  });

  $("#toprate-slider").slick({
    dots: false,
    mobileFirst: true,
    pauseOnFocus: false,
    infinite: false,
    slidesToShow: 4,
    slidesToScroll: 4,
    swipeToSlide:true,
    arrows: true,
    prevArrow: $('.top-rated-prev'),
    nextArrow: $('.top-rated-next'),
    responsive: [
      {
        breakpoint: 1000,
        settings: {
          slidesToShow: 4,
        },
      },
      {
        breakpoint: 800,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 200,
        settings: {
          slidesToShow: 2,
        },
      },
    ],
  });
});
