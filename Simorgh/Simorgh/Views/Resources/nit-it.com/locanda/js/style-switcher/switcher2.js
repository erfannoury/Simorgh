function ColorLuminance(hex, lum) {
    // validate hex string
    hex = String(hex).replace(/[^0-9a-f]/gi, '');
    if (hex.length < 6) {
        hex = hex[0]+hex[0]+hex[1]+hex[1]+hex[2]+hex[2];
    }
    lum = lum || 0;
    // convert to decimal and change luminosity
    var rgb = "#", c, i;
    for (i = 0; i < 3; i++) {
        c = parseInt(hex.substr(i*2,2), 16);
        c = Math.round(Math.min(Math.max(0, c + (c * lum)), 255)).toString(16);
        rgb += ("00"+c).substr(c.length);
    }
    return rgb;
}
  
  jQuery(document).ready(function($) {
  	
	var layoutid = $.cookie('layoutstyle');
	if(layoutid == "boxed")
	{
		$("select option[value='boxed']").attr("selected","selected");
	}
	else
	{
		$("select option[value='wide']").attr("selected","selected");
	}
	
    $('#colorpicker').ColorPicker({
			onShow: function (colpkr) {
				$(colpkr).fadeIn("fast");
				return false;
			},
			onHide: function (colpkr) {
				$(colpkr).fadeOut("fast");
				return false;
			},
			onChange: function (hsb, hex, rgb) {
        var color = hex;
        var color2=ColorLuminance(hex,-0.7);
        var color3=ColorLuminance(hex,0.7);
        
        var defaultPattern = "url(images/bg/bg2.png)";
        $('.main_header, .caption2, .inner_bg, .our-offer header, .thumbnail, #copy-footer').css({
            backgroundColor: '#' + color
        }); 
        
        $('.top_section, .top-right, .flex-direction-nav .flex-next, .more-info, .more-info3').css({
            backgroundColor: '#' + color2,
            color: '#' + color
        });  
        
        $('.top-right ul li').css({
            backgroundColor: '#' + color
        });   
        
        $('.corner-right, .corner-left').css({
            "border-top-color": '#' + color2
        });  
        
        $('ul.nav > li > a i,  .caption2 p, .thumbnail .caption p').css({
            color: '#' + color3
        });   
        
        $('.testimonial h3, .testi h4').css({
            color: '#' + color2
        });  
        
        $('.border-footer, #copy-footer ul li').css({
            backgroundColor: '#' + color3
        }); 
        
        $('#copy-footer').css({
            color: '#' + color3
        }); 
        
        $('h4, .welcometext h2, #footer h3').css({
            color: '#' + color
        });
        
        $.cookie("portable_cookie_color", color, {path: "/"});   
        $.cookie("portable_cookie_pattern", null, {path: "/"});   
        $.cookie("portable_cookie_defaultBg", defaultPattern, {path: "/"});   
			},
    
    });    
    
    $('#style-switcher a.color-box').each(function (i) {
        var a = $(this);
        a.css({
            backgroundColor: '#' + a.attr('data-rel')
        })
    })    
    

   var switcher_skins = $('#style-switcher a.color-box');
   var switcher_link = $('#skins-switcher');
   switcher_skins.each(function(i) {
    var color = $(this).attr('data-rel');
    var defaultPattern = "url(images/bg/bg2.png)";
     
      
   });  
   
     /*STYLESHEETS LOAD STARTS*/ 
   switcher_skins.click(function(e) {
    var color = $(this).attr('data-rel');
    var skins;
    var defaultPattern = "url(images/bg/bg2.png)";
    
    if (color == "333333") {
      switcher_link.attr('href',"css/style.css");
      var atrrHref = switcher_link.attr('href');
      $('#slideshow-bg,#footer-bg').css({
          backgroundColor: '#' + color,
          backgroundImage : defaultPattern
      });   
    }

	if (color == "282828") {
      switcher_link.attr('href',"css/dark-style.css");
      var atrrHref = switcher_link.attr('href');
      $('#slideshow-bg,#footer-bg').css({
          backgroundColor: '#' + color,
          backgroundImage : defaultPattern
      });   
    }

	
	/*STYLESHEETS LOAD ENDS*/
	
	
	
	
     
    $.cookie("portable_cookie_pattern", null);   
    $.cookie("portable_cookie_bgimage",null);

    $.cookie("portable_cookie_color", color);  
    $.cookie("portable_cookie_skins", atrrHref);
    $.cookie("portable_cookie_defaultBg", defaultPattern);    
    return false;
	
   });  
   
  var color = $.cookie("portable_cookie_color");
  var portable_skins = $.cookie("portable_cookie_skins");
  var defaultPattern = $.cookie("portable_cookie_defaultBg");
  var pattern = $.cookie("portable_cookie_pattern");
  
  if (portable_skins) {
    $("#skins-switcher").attr("href",portable_skins);
    $('.banner_cont, #container_footer, .inner_bg').css({
        backgroundColor: '#' + color,
        backgroundImage : pattern
    });
     $('h4').css({
            color: '#' + color
        });
  }

  $('#style-switcher a.pattern-box').click(function (e) {
      e.preventDefault();
      var patternUrl = 'url(images/bg/bg2.png)';
      $('.banner_cont, #container_footer, .inner_bg').css({
          backgroundImage: patternUrl,
          backgroundRepeat: "repeat"
      });
      $.cookie("portable_cookie_bgimage",null);
      $.cookie("portable_cookie_pattern", patternUrl)
  });
  
  var defaultPattern = $.cookie("portable_cookie_defaultBg");
  var color = $.cookie("portable_cookie_color");
  var background = $.cookie("portable_cookie_bgimage");
  if (color) {
      $('.banner_cont, #container_footer, .inner_bg').css({
          backgroundColor: '#' + color,
          backgroundImage : defaultPattern
      });
  }
  var pattern = $.cookie("portable_cookie_pattern");
  if (pattern) {
      $('#slideshow-bg,#footer-bg').css({
          backgroundImage: pattern,
          backgroundRepeat: "repeat"
      });
  } else {
    if (background) {
        $('#slideshow-bg,#footer-bg').css({
          backgroundImage: background,
          backgroundRepeat: "repeat",
          backgroundPosition: "top center",
        
        });
    }    
  }  

   $('#style-switcher a.bg-box').each(function (i) {
    var backgroundUrl = 'url(images/bg/' + $(this).attr('data-rel') + '.png)';
    var a = $(this);
      a.css({
          backgroundImage: backgroundUrl
      })
  })
  
  $('#style-switcher a.color-box').each(function (i) {
    var backgroundUrl = 'url(images/' + $(this).attr('data-rel') + '.png)';
    var a = $(this);
      a.css({
          backgroundImage: backgroundUrl
      })
  })
  
  
  $('select#layout').on('change', function() {
  var layoutstyle=this.value;
  if(layoutstyle == "boxed")
  {
  	$('body').wrapInner('<div class="main-container"></div>');
  	$("body").addClass('boxed_bg');
  	$("body").css('background-color', '#333');
  }
  else
  {
  	$('.main-container').contents().unwrap();
  	$("body").removeClass('boxed_bg');
  	$("body").css('background-image', 'none');
  	$("body").css('background-color', '#ECF0F1');
  }
  $.cookie("layoutstyle", layoutstyle)
  });
  
    
  $('#style-switcher a.color-box').click(function (e) {
      e.preventDefault();
	  colorid=jQuery(this).attr("id");
	  if(colorid == "default")
	  {
	      $('head').append('<link rel="stylesheet" href="css/style.css" type="text/css" />');
	      $("#logo").attr('src','images/logo.png');
	      $(".portfolioHover span img").attr('src','images/zoom-icon.png');
	      $(".stats-box").find(".box").each(function () {
	      $(this).children().eq(1).alterClass( "stats-triangle-*","stats-triangle-bottom");
	      });
      	  $(".plus-btn").alterClass( 'plus-btn-*', 'plus-btn'); 
		  $(".navbar").removeClass( 'navbar-white');
		  $("header").removeClass( 'whiteheader');
		  $("a.dropdown-toggle").attr('style', 'color: #ffffff !important');
	  }
	  else if(colorid == "whiteheader")
	  {
	  	  $('head').append('<link rel="stylesheet" href="css/style.css" type="text/css" />');
	      $("#logo").attr('src','images/logo-white.png');
	      $(".portfolioHover span img").attr('src','images/zoom-icon.png');
      	  $(".plus-btn").alterClass( 'plus-btn-*', 'plus-btn'); 
		  $(".navbar").addClass( 'navbar-white');
		  $("header").addClass( 'whiteheader');
		  $("a.dropdown-toggle").attr('style', 'color: #594754 !important');
	  }
	  else
	  {
	      $('head').append('<link rel="stylesheet" href="css/'+colorid+'/style.css" type="text/css" />');
	      $("#logo").attr('src','css/'+colorid+'/images/logo.png');
	      $(".portfolioHover span img").attr('src','css/'+colorid+'/images/zoom-icon.png');
      	      $(".plus-btn").alterClass( 'plus-btn-*', 'plus-btn-'+colorid ); 
		  $(".navbar").removeClass( 'navbar-white');
		  $("header").removeClass( 'whiteheader');
		  $("a.dropdown-toggle").attr('style', 'color: #ffffff !important');
		  
		   if ($(".stats-triangle-bottom").length > 0){
		        $(".stats-box").find(".box").each(function () {
		        $(this).children().eq(1).css("border-bottom-color", "");
		        $(this).children().eq(1).alterClass( "stats-triangle-*","stats-triangle-"+colorid);
		  });
		  }
		  
		  if ($(".stats-triangle-blue").length > 0  || $(".stats-triangle-red").length > 0 || $(".stats-triangle-green").length > 0 || $(".stats-triangle-default").length > 0){
		        $(".stats-box").find(".box").each(function () {
		        $(this).children().eq(1).css("border-bottom-color", "");
		        $(this).children().eq(1).alterClass( "stats-triangle-*","stats-triangle-"+colorid);
		  });
		  }
		  else
		  {
		  	$(this).children().eq(1).alterClass( "stats-triangle-*","stats-triangle-default");
		  }
		  
		  if ($(".acc-triangle-blue").length > 0  || $(".acc-triangle-red").length > 0 || $(".acc-triangle-green").length > 0 || $(".acc-triangle-default").length > 0){
		        $(".acc-box").find(".portfolio").each(function () {
		        $(this).children().eq(1).css("border-bottom-color", "");
		        $(this).children().eq(1).alterClass( "acc-triangle-*","acc-triangle-"+colorid);
		  });
		  }
		  else
		  {
		  	$(this).children().eq(1).alterClass( "acc-triangle-*","acc-triangle-default");
		  }
	  }
	  
      
      $.cookie("colorscheme",colorid)
  });
  
   $('#style-switcher a.bg-box').click(function (e) {
      e.preventDefault();
      var patternUrl = 'url(images/bg/' + $(this).attr('data-rel') + '.png)';
      $('body').css({
          backgroundImage: patternUrl,
          backgroundRepeat: "repeat"
      });
      $.cookie("portable_cookie_bgimage",null);
      $.cookie("portable_cookie_pattern", patternUrl)
  });
    
  $('#style-switcher a.bg-box').click(function (e) {
      e.preventDefault();
      var backgroundUrl = 'url(http://localhost/travels/wp-content/themes/travels/images/banner_bg.png)';
      $('#slideshow-bg,#footer-bg').css({
          backgroundImage: backgroundUrl,
          backgroundRepeat: "repeat",
        
        
      });
    $.cookie("portable_cookie_bgimage",backgroundUrl)
  });

  var background = $.cookie("portable_cookie_bgimage");
  if (background) {
      $('#slideshow-bg,#footer-bg').css({
        backgroundImage: background,
        backgroundRepeat: "repeat",
      
      
      });
  }
         
});   
 

 
 $('#colorpicker2').ColorPicker({
	color: '#0000ff',
	onShow: function (colpkr) {
		$(colpkr).fadeIn(500);
		return false;
	},
	onHide: function (colpkr) {
		$(colpkr).fadeOut(500);
		return false;
	},
	onChange: function (hsb, hex, rgb) {
	   var color4 = hex;
	   var color5=ColorLuminance(hex,-0.7);
       var color6=ColorLuminance(hex,0.7);
		$('.booking_icon, .reservation_heading, .button-submit, .our_hotel').css('backgroundColor', '#' + hex);
        $('.more-info2').css({
            backgroundColor: '#' + color5
        });   
        $('.testi-sep').css({
            "border-color": '#' + color4
        }); 
        $('.top-right i, #footer ul li i, .footer-icons i, .icon-caret-down, .icon-calendar, .our-offer ul li i').css({
            "color": '#' + color4
        });
        
        $('.our_hotel .caption p, .job').css({
            color: '#' + color6
        }); 
	}
});