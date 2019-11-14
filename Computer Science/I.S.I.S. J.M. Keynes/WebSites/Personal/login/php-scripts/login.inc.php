<?php

if (isset($_POST['login'])) {
  include 'db-connection.inc.php';
  $user= $_POST['email'];
}






function loginFunction() {

  include 'db-connection.inc.php';


  global $user;
  $pass = hash("sha256", $_POST['password']);

  $sql = "SELECT username, password FROM Users";
  $result = mysqli_query($conn, $sql);

  if (mysqli_num_rows($result) > 0) {
  // output data of each row
  while($row = mysqli_fetch_assoc($result)) {
    if($row["username"]==$user && $row["password"]==$pass){
      return true;
    }
  }
  } else {
      return false;
  }

  $conn->close();


}







 ?>
