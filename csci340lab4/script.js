$(document).ready(function() {
  console.log("ready");
    $('#cclicker').click(function() {
      console.log("cat clicked");
      $.ajax({
        url: "https://api.thecatapi.com/v1/images/search",
        success: function(results) {
          console.log(results[0]);
          if (results[0]["url"].endsWith(".mp4")) {
            $('#cat').attr("src", "images/blank.png");
          } else {
            $('#cat').attr("src", results[0]["url"]);
          }
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
    });
    $('#dclicker').click(function() {
      $.ajax({
        dataType: "json",
        url: "https://random.dog/woof.json",
        success: function(results) {
          console.log(results["url"]);
          if (results["url"].endsWith(".mp4")) {
            $('#dog').attr("src", "images/blank.png");
          } else {
            $('#dog').attr("src", results["url"]);
          }
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
      $.ajax({
        dataType: "json",
        url: 'https://dogapi.dog/api/v2/facts?limit=1',
        success: function(results) {
          $('.dogfacts').text(results["data"]["body"]);
          console.log("Dog Fact");
          console.log(result);
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
    });
    console.log("Finding Fact");
    $.ajax({
      dataType: "json",
      url: "https://meowfacts.herokuapp.com/",
      success: function(results) {
        console.log("Fact Found");
        console.log(results)
        $('.catfacts').text(results["data"]["0"]);
      },
      error: function(xhr,status,error) {
        console.log(error);
      }
    });
  });

  