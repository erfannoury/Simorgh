$(document).ready(function() { 

$("#handle").text('');

 var originalFontSize = $('body').css('font-size');
 $(".resetFont").click(function(){
 $('body').css('font-size', originalFontSize);
 });
 $(".increaseFont").click(function(){
 var currentFontSize = $('body').css('font-size');
 var currentFontSizeNum = parseFloat(currentFontSize, 12);
 var newFontSize = currentFontSizeNum+1;
 $('body').css('font-size', newFontSize);
 return false;
 });
 $(".decreaseFont").click(function(){
 var currentFontSize = $('body').css('font-size');
 var currentFontSizeNum = parseFloat(currentFontSize, 12);
 var newFontSize = currentFontSizeNum-1;
 $('body').css('font-size', newFontSize);
 return false;
 });
});

$(document).ready(function() { 
 var originalFontSize = $(':header').css('font-size');
 $(".resetFontHeader").click(function(){
 $(':header').css('font-size', originalFontSize);
 });
 $(".increaseFontHeade").click(function(){
 var currentFontSize = $(':header').css('font-size');
 var currentFontSizeNum = parseFloat(currentFontSize, 12);
 var newFontSize = currentFontSizeNum+1;
 $(':header').css('font-size', newFontSize);
 return false;
 });
 $(".decreaseFontHeader").click(function(){
 var currentFontSize = $(':header').css('font-size');
 var currentFontSizeNum = parseFloat(currentFontSize, 12);
 var newFontSize = currentFontSizeNum-1;
 $(':header').css('font-size', newFontSize);
 return false;
 });
});

$(document).ready(function() {
$("#switcher-handle > #handle").toggle
	(
		function()
		{
			$('#switcher-handle').animate({left:'0px'}, {queue:false,duration:200});
			$('#switcher-handle > #handle').addClass('out');
		}
		,function()
		{
			$('#switcher-handle').animate({left:'-150px'}, {queue:false,duration:200});
			$('#switcher-handle > #handle').removeClass('out');
		}
	);
	
	
});

$(document).ready(function() {
$('#body-font').bind('change', function() {
var font = $(this).val();
 $('p, a ,#main_navigation, span, ul ,li , ol').css('fontFamily', font);
 
});
});

$(document).ready(function() {
$('#headings-font').bind('change', function() {
var font = $(this).val();
 $(':header, :header a, a:header, span:header, :header span').css('fontFamily', font);
 
});
});

$(window).load(function() {
		   $('.flexslider').flexslider({
					animation: "fade",
					controlNav: true,
					smoothHeight: true,
					before: function(){
				      	onBefore();
				    },
					after: function(){
				      	onAfter();
				    }
				});
			});
						
			
$(window).load(function() {
		   $('.flexslider-gallery').flexslider({
					animation: "slide",
					controlNav: true,
					smoothHeight: true
				});
			});			
			
			$('.caption2').css("display", "block").animate({ left: "20px" }).fadeIn(500);
			$('.book-now2').delay(300).show(0).animate({ left: "-20px" }).fadeIn(2000);
			
			function onBefore() { 
			   $('.caption2').css({
				   'display' : 'none',
				   left : '0px'
				});
			   $('.book-now2').css({
				   'display' : 'none',
				   left : '0px'
				});
			}
			function onAfter() { 
			   $('.caption2').css("display", "block").animate({ left: "20px" }).fadeIn(500);
			   $('.book-now2').delay(300).show(0).animate({ left: "-20px" }).fadeIn(2000);
			}
			

jQuery(document).ready(function( $ ) {
$('.counter').counterUp({
delay: 100, // the delay time in ms
time: 1000 // the speed time in ms
});
});

	// portfolio hover
	$('.portfolioHover span').css({opacity:0});
	$('.portfolio').hover(function(){
		$(this).find('.portfolioHover img').stop().animate({ opacity:0.3 }, 0, function() {});
		$(this).find('.portfolioHover span').stop().animate({ opacity:1 }, 0, function() {});
		$(this).find('.plus-btn').stop().css('background', '#FF6239');
		$(this).find('.plus-btn-blue').stop().css('background', '#3d9ae8');
		$(this).find('.plus-btn-red').stop().css('background', '#f12537');
		$(this).find('.plus-btn-green').stop().css('background', '#53ad5e');
		$(this).find('.acc-box .box h3').stop().css('color', '#FF6239');
		$(this).find('.acc-triangle-bottom').stop().css("border-bottom-color", "#FC6339");
		
		
		$(this).find('.acc-triangle-blue').stop().css("border-bottom-color", "#3d9ae8");
		$(this).find('.acc-triangle-red').stop().css("border-bottom-color", "#f12537");
		$(this).find('.acc-triangle-green').stop().css("border-bottom-color", "#53ad5e");
		
		$(this).find('.portfolioHover span img').stop().animate({ opacity:1 }, 0, function() {});
	}, function(){
		$(this).find('.portfolioHover img').stop().animate({ opacity:1 }, 0, function() {});
		$(this).find('.portfolioHover span').stop().animate({ opacity:0 }, 0, function() {});
		$(this).find('.plus-btn').stop().css('background', '#FFFFFF');
		
		$(this).find('.acc-triangle-blue').stop().css("border-bottom-color", "#dbdbdb");
		$(this).find('.acc-triangle-red').stop().css("border-bottom-color", "#dbdbdb");
		$(this).find('.acc-triangle-green').stop().css("border-bottom-color", "#dbdbdb");
		$(this).find('.acc-triangle-bottom').stop().css('border-bottom-color', '#dbdbdb');
	});
	
	$(".stats-box .box").on({
    mouseenter: function () {
        $(this).find('.stats-triangle-bottom').stop().css('border-bottom-color', '#392934');
        $(this).find('.stats-triangle-default').stop().css("border-bottom-color", "#392934");
        $(this).find('.stats-triangle-blue').stop().css('border-bottom-color', '#392934');
		$(this).find('.stats-triangle-red').stop().css('border-bottom-color', '#392934');
		$(this).find('.stats-triangle-green').stop().css('border-bottom-color', '#392934');
    },
    mouseleave: function () {
        $(this).find('.stats-triangle-default').stop().css("border-bottom-color", "#FF6239");
        $(this).find('.stats-triangle-bottom').stop().css('border-bottom-color', '#FC6339');
		$(this).find('.stats-triangle-blue').stop().css('border-bottom-color', '#3d9ae8');
		$(this).find('.stats-triangle-red').stop().css('border-bottom-color', '#f12537');
		$(this).find('.stats-triangle-green').stop().css('border-bottom-color', '#53ad5e');
    }
});

/*
$(".news-box .col-md-4").each(function(){
$(this).hover(function(){
		$(this).find('#news-triangle-bottom').stop().css("border-bottom-color", "#FC6339");
	}, function(){
		$(this).find('#news-triangle-bottom').stop().css("border-bottom-color", "#dbdbdb");
	});
});
*/

$(document).ready(function () {
var activeindex=$('ul.navbar-nav li.active').index();  
    $('.navbar-default .navbar-nav > li.dropdown').hover(function () {
        $('ul.dropdown-menu', this).stop(true, true).slideDown('fast');      
        $(this).addClass('open');
    }, function () {
        $('ul.dropdown-menu', this).stop(true, true).slideUp('fast');
        $(this).removeClass('open');
    });
});


$(document).ready(function(){
   // cache the window object
   $window = $(window);
 
   $('section[data-type="background"]').each(function(){
     // declare the variable to affect the defined data-type
     var $scroll = $(this);
                     
      $(window).scroll(function() {
        // HTML5 proves useful for helping with creating JS functions!
        // also, negative value because we're scrolling upwards                            
        var yPos = -($window.scrollTop() / $scroll.data('speed'));
         
        // background position
        var coords = '100% '+ yPos + 'px';
 
        // move the background
        $scroll.css({ backgroundPosition: coords });   
      }); // end window scroll
   });  // end section function
}); // close out script	


$(document).ready(function(){
	var $cs = $('.styled').customSelect();
	$('.datepicker').datepicker()
});



/**
* jQuery alterClass plugin
*
* Remove element classes with wildcard matching. Optionally add classes:
* $( '#foo' ).alterClass( 'foo-* bar-*', 'foobar' )
*
* Copyright (c) 2011 Pete Boere (the-echoplex.net)
* Free under terms of the MIT license: http://www.opensource.org/licenses/mit-license.php
*
*/
(function ( $ ) {
$.fn.alterClass = function ( removals, additions ) {
var self = this;
if ( removals.indexOf( '*' ) === -1 ) {
// Use native jQuery methods if there is no wildcard matching
self.removeClass( removals );
return !additions ? self : self.addClass( additions );
}
 
var patt = new RegExp( '\\s' +
removals.
replace( /\*/g, '[A-Za-z0-9-_]+' ).
split( ' ' ).
join( '\\s|\\s' ) +
'\\s', 'g' );
 
self.each( function ( i, it ) {
var cn = ' ' + it.className + ' ';
while ( patt.test( cn ) ) {
cn = cn.replace( patt, ' ' );
}
it.className = $.trim( cn );
});
 
return !additions ? self : self.addClass( additions );
};
 
})( jQuery );
