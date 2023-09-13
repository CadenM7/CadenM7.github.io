$(document).ready(function() {
    $('.cat').click(function() {
      $.ajax({
        dataType: "jsonp",
        jsonpCallback: "parseQuote",
        url: "https://api.thecatapi.com/v1/images/search",
        success: function(results) {
          $('.fortune').text(results["quoteText"]);
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
    });
    $('.dog').click(function() {
      $.ajax({
        dataType: "jsonp",
        jsonpCallback: "parseQuote",
        url: "https://api.thecatapi.com/v1/images/search",
        success: function(results) {
          $('.fortune').text(results["quoteText"]);
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
    });
  });

  