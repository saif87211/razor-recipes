// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {

    //-------SLIDERS
    
    $('#main-slider').slick({
        // adaptiveHeight:true,
        autoplay:true,
        dots:true,
        draggable:true,
        infinite:true,
        mobileFirst:true,
        pauseOnFocus:false,
    });
    $('.single-slide').css({
        'display':'flex',
        'justify-content': 'center'
    });

    $('#category-slider').slick({
        autoplay:true,
        infinite:true,
        slidesToShow: 8,
        slidesToScroll: 8,
        variableWidth: true,
        centerMode:true,
        mobileFirst:true,
        pauseOnFocus:false,
        arrows:false,
    });

    $('.prev-category').on('click', function(){
        $('#category-slider').slick('slickPrev');
    });

    $('.next-category').on('click', function(){
        $('#category-slider').slick('slickNext');
    });
    
    $('#toprate-slider').slick({
        dots:false,
        mobileFirst:true,
        pauseOnFocus:false,
        infinite:false,
        slidesToShow: 3,
        responsive: [
            {
                breakpoint : 1000,
                settings :{
                    slidesToShow:3
                }
            },
            {
                breakpoint : 800,
                settings :{
                    slidesToShow:2
                }
            },
            {
                breakpoint : 200,
                settings :{
                    slidesToShow:2
                }
            }
        ]
    });
});