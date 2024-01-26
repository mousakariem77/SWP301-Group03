document.addEventListener("DOMContentLoaded", function() {
  var informationLink = document.querySelector("a[href='#changepass']");
  var changepassLink = document.querySelector("a[href='#information']");
  var informationSection = document.getElementById("information");
  var changepassSection = document.getElementById("changepass");

  // Kiểm tra nếu URL chứa '#information' hoặc '#changepass'
  if (window.location.href.includes('#information')) {
      informationLink.classList.add("text-primary");
      changepassSection.style.display = "none";
  } else if (window.location.href.includes('#changepass')) {
      changepassLink.classList.add("text-primary");
      informationLink.style.color = "";
  }else{
      informationLink.classList.add("text-primary");
      changepassSection.style.display = "none";
  }

  informationLink.addEventListener("click", function(e) {
      e.preventDefault();
      informationSection.style.display = "block";
      informationLink.classList.add("text-primary");
      changepassSection.style.display = "none";
      changepassLink.classList.remove("text-primary");
      changepassLink.style.color = "";
      changepassLink.style.fontWeight = "";
  });

  changepassLink.addEventListener("click", function(e) {
      e.preventDefault();
      changepassSection.style.display = "block";
      changepassLink.classList.add("text-primary");
      informationSection.style.display = "none";
      informationLink.classList.remove("text-primary");
      informationLink.style.color = "";
      informationLink.style.fontWeight = "";
  });
});

// Create picture of Course
var inputFile = document.getElementById("input-file");
var updateBtn = document.getElementById("update-btn");
var coursePic = document.getElementById("course-pic");

updateBtn.addEventListener("click", function() {
  inputFile.click();
});

inputFile.addEventListener("change", function() {
  var file = inputFile.files[0];
  var reader = new FileReader();

  reader.onload = function(e) {
    coursePic.src = e.target.result;
    coursePic.style.display = "block";
    updateBtn.style.marginTop = "10px";
  };

  if (file) {
    reader.readAsDataURL(file);
  }
});

/**
 * Main
 */
function time() {
  var today = new Date();
  var weekday = new Array(7);
  weekday[0] = "Sunday";
  weekday[1] = "Monday";
  weekday[2] = "Tuesday";
  weekday[3] = "Wednesday";
  weekday[4] = "Thursday";
  weekday[5] = "Friday";
  weekday[6] = "Saturday";
  var day = weekday[today.getDay()];
  var dd = today.getDate();
  var mm = today.getMonth() + 1;
  var yyyy = today.getFullYear();
  var h = today.getHours();
  var m = today.getMinutes();
  var s = today.getSeconds();
  m = checkTime(m);
  s = checkTime(s);
  nowTime = h + "h " + m + "m " + s + "s";
  if (dd < 10) {
    dd = '0' + dd
  }
  if (mm < 10) {
    mm = '0' + mm
  }
  today = day + ', ' + dd + '/' + mm + '/' + yyyy;
  tmp = '<span class="date"> ' + today + ' - ' + nowTime +
    '</span>';
  document.getElementById("clock").innerHTML = tmp;
  clocktime = setTimeout("time()", "1000", "Javascript");

  function checkTime(i) {
    if (i < 10) {
      i = "0" + i;
    }
    return i;
  }
}

document.querySelector(".theme-toggle").addEventListener("click", () => {
  toggleLocalStorage();
  toggleRootClass();
});

function toggleRootClass(){
  const current = document.documentElement.getAttribute('data-bs-theme');
  const inverted = current == 'dark' ? 'light' : 'dark';
  document.documentElement.setAttribute('data-bs-theme', inverted);
};

function toggleLocalStorage(){
  if(isLight()){
    localStorage.removeItem("light");
  }else{
    localStorage.setItem("light", "set");
  }
};

function isLight(){
  return localStorage.getItem("light");
};

if(isLight()){
  toggleRootClass();
}

// Change Infomation


'use strict';

let menu, animate;

(function () {
  // Initialize menu
  //-----------------

  let layoutMenuEl = document.querySelectorAll('#layout-menu');
  layoutMenuEl.forEach(function (element) {
    menu = new Menu(element, {
      orientation: 'vertical',
      closeChildren: false
    });
    // Change parameter to true if you want scroll animation
    window.Helpers.scrollToActive((animate = false));
    window.Helpers.mainMenu = menu;
  });

  // Initialize menu togglers and bind click on each
  let menuToggler = document.querySelectorAll('.layout-menu-toggle');
  menuToggler.forEach(item => {
    item.addEventListener('click', event => {
      event.preventDefault();
      window.Helpers.toggleCollapsed();
    });
  });

  // Display menu toggle (layout-menu-toggle) on hover with delay
  let delay = function (elem, callback) {
    let timeout = null;
    elem.onmouseenter = function () {
      // Set timeout to be a timer which will invoke callback after 300ms (not for small screen)
      if (!Helpers.isSmallScreen()) {
        timeout = setTimeout(callback, 300);
      } else {
        timeout = setTimeout(callback, 0);
      }
    };

    elem.onmouseleave = function () {
      // Clear any timers set to timeout
      document.querySelector('.layout-menu-toggle').classList.remove('d-block');
      clearTimeout(timeout);
    };
  };
  if (document.getElementById('layout-menu')) {
    delay(document.getElementById('layout-menu'), function () {
      // not for small screen
      if (!Helpers.isSmallScreen()) {
        document.querySelector('.layout-menu-toggle').classList.add('d-block');
      }
    });
  }

  // Display in main menu when menu scrolls
  let menuInnerContainer = document.getElementsByClassName('menu-inner'),
    menuInnerShadow = document.getElementsByClassName('menu-inner-shadow')[0];
  if (menuInnerContainer.length > 0 && menuInnerShadow) {
    menuInnerContainer[0].addEventListener('ps-scroll-y', function () {
      if (this.querySelector('.ps__thumb-y').offsetTop) {
        menuInnerShadow.style.display = 'block';
      } else {
        menuInnerShadow.style.display = 'none';
      }
    });
  }

  // Init helpers & misc
  // --------------------

  // Init BS Tooltip
  const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
  tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl);
  });

  // Accordion active class
  const accordionActiveFunction = function (e) {
    if (e.type == 'show.bs.collapse' || e.type == 'show.bs.collapse') {
      e.target.closest('.accordion-item').classList.add('active');
    } else {
      e.target.closest('.accordion-item').classList.remove('active');
    }
  };

  const accordionTriggerList = [].slice.call(document.querySelectorAll('.accordion'));
  const accordionList = accordionTriggerList.map(function (accordionTriggerEl) {
    accordionTriggerEl.addEventListener('show.bs.collapse', accordionActiveFunction);
    accordionTriggerEl.addEventListener('hide.bs.collapse', accordionActiveFunction);
  });

  // Auto update layout based on screen size
  window.Helpers.setAutoUpdate(true);

  // Toggle Password Visibility
  window.Helpers.initPasswordToggle();

  // Speech To Text
  window.Helpers.initSpeechToText();

  // Manage menu expanded/collapsed with templateCustomizer & local storage
  //------------------------------------------------------------------

  // If current layout is horizontal OR current window screen is small (overlay menu) than return from here
  if (window.Helpers.isSmallScreen()) {
    return;
  }

  // If current layout is vertical and current window screen is > small

  // Auto update menu collapsed/expanded based on the themeConfig
  window.Helpers.setCollapsed(true, false);
})();

(function ($) {
  "use strict";
  
  // Dropdown on mouse hover
  $(document).ready(function () {
      function toggleNavbarMethod() {
          if ($(window).width() > 992) {
              $('.navbar .dropdown').on('mouseover', function () {
                  $('.dropdown-toggle', this).trigger('click');
              }).on('mouseout', function () {
                  $('.dropdown-toggle', this).trigger('click').blur();
              });
          } else {
              $('.navbar .dropdown').off('mouseover').off('mouseout');
          }
      }
      toggleNavbarMethod();
      $(window).resize(toggleNavbarMethod);
  }); 
  
  
  // Back to top button
  $(document).ready(function() {
    $(window).scroll(function() {
        if ($(this).scrollTop()) {
            $('.back-to-top').fadeIn("slow");
        } else {
            $('.back-to-top').fadeOut("slow");
        }
    });
    $(".back-to-top").click(function(){
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });
  });


  // Testimonials carousel
  $(".testimonial-carousel").owlCarousel({
      autoplay: true,
      smartSpeed: 1500,
      dots: true,
      loop: true,
      items: 1
  });
  
})(jQuery);


const passwordInput = document.getElementById('passwordInput');
const togglePassword = document.querySelector('.toggle-password');

togglePassword.addEventListener('click', function() {
  if (passwordInput.type === 'password') {
    passwordInput.type = 'text';
    togglePassword.classList.remove('fa-eye');
    togglePassword.classList.add('fa-eye-slash');
  } else {
    passwordInput.type = 'password';
    togglePassword.classList.remove('fa-eye-slash');
    togglePassword.classList.add('fa-eye');
  }
});
