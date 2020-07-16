$(document).ready(function(){
    $("div").dblclick(function(){
          $(this).html("Changed using jQuery....");
      })
      $("#div1").mouseenter(function(){
          $(this).css("background-color","green");
      })
      $("#div1").mouseleave(function(){
          $(this).css("background-color","pink");
      })
    //   $("button").click(function(){
    //       $("#div2").hide(2000);
    //   })
      $("#btnToggle").click(function(){
          $("#div2").toggle(2000);//show/hide
      })
      $("#btnSlide").click(function(){
          $("#div1").slideToggle(2000);//slideUp/slideDown
      })
      $("#btnFade").click(function(){
          $("#div1").fadeToggle(2000);//fadeIn/fadeOut
      })
      $("#txtData").blur(function(){
          if($(this).val()=="")
            $(this).css("border-color","red");
          else
          $(this).css("border-color","green");
      })
   });