// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('#main-slider').slick({
        adaptiveHeight:true,
        autoplay:true,
        centerMode:true,
        centerPadding: '10px',
        dots:true,
        draggable:true,
        fade:true,
        infinite:true,
        mobileFirst:true,
        pauseOnFocus:false,
    });

    $('#category-slider').slick({
        autoplay:true,
        infinite:true,
        slidesToShow: 6,
    });
});