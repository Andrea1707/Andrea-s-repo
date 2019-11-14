
<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <meta name="description" content="This is an example of a meta description. This will often show up in the search results.">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
    <link rel="stylesheet" href="css/style.css">
  </head>
  <body>
    <header>
      <nav class="nav" >
        <ul>
          <li>
          <a href="index.php">
            <img class="logo" src="img/logo.png" alt="logo">
          </a>
        </li>
          <li> <a href="#">Home</a> </li>
          <li> <a href="#">Portfolio</a> </li>
          <li> <a href="#">About</a> </li>
          <li> <a href="#">Contact</a> </li>
        </ul>
        <button class="login-button" onclick="document.getElementById('id01').style.display='block'" style="width:auto;">Login</button>
        <div id="id01" class="modal">

          <form class="modal-content animate" action="includes/login.inc.php" method="post">
            <div class="imgcontainer">
              <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
              <img src="img/avatar.png" >
            </div>

            <div class="container">
              <label for="uname"><b>Username</b></label>
              <input type="text" placeholder="Enter Username" name="mailuid" required>

              <label for="psw"><b>Password</b></label>
              <input type="password" placeholder="Enter Password" name="pwd" required>

              <button type="submit" name="login-submit">Login</button>
              <label>
                <span class="psw"> Forgot <a href="#">password?</a></span>
              </label>
            </div>

            <div class="container" style="background-color:#f1f1f1">
              <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
              <span class="create">  Create an acccount: <a href="signup.php">here!</a></span> <br>

            </div>
          </form>
        </div>

        <script>
        // Get the modal
        var modal = document.getElementById('id01');

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function(event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }
        </script>

      </nav>
    </header>

  </body>
</html>
