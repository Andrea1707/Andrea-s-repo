<?php
      include 'db-connection.inc.php';
      $first_name=mysqli_real_escape_string($conn, $_POST['first-name']);
      $last_name=mysqli_real_escape_string($conn, $_POST['last-name']);
      $email=mysqli_real_escape_string($conn, $_POST['email']);
      $passwd=mysqli_real_escape_string($conn, $_POST['psw']);
      $re_passwd=mysqli_real_escape_string($conn, $_POST['psw-repeat']);
      $fiv=mysqli_real_escape_string($conn, $_POST['fiv-card']);


      if($passwd==$re_passwd){

          $pass = hash("sha256", $_POST['psw']);
          $sql="INSERT INTO Users (first_name, last_name, email, password, fiv_card)
                            VALUES ('$first_name', '$last_name', '$email', '$pass', $fiv)";

          if (mysqli_query($conn, $sql)) {
              echo "New record created successfully";
            } else {
              echo "Error: " . $sql . "<br>" . mysqli_error($conn);
            }

mysqli_close($conn);
          echo "fatto!";

      }else {

        echo "<p>Password mismatch!</p>";
      }

 ?>
