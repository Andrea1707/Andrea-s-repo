<?php
$user=$_POST['usr'];
$pass=$_POST['pswd'];
$rip=$_POST['rpswd'];
require 'dbh.inc.php';
if (empty($user)||empty($pass)||empty($rip)) {
  header("Location: ../index.php?error=emptyfields");
}elseif ($pass!=$rip) {
  header("Location: ../index.php?error=pswdmissmatch");
}else{
  $sql="SELECT username FROM Utenti WHERE username='$user'";
  $result = $conn->query($sql);
  if (!$result) {
  trigger_error('Invalid query: ' . $conn->error);
  }
  if ($result->num_rows == 1) {
    header("Location: ../index.php?error=exist");
  }
  $hashedPws=password_hash($pass, PASSWORD_DEFAULT);

  $sql="INSERT INTO Utenti (username, pass) VALUES ('$user', '$hashedPws')";
  $result = $conn->query($sql);
  if (!$result) {
  trigger_error('Invalid query: ' . $conn->error);
}else {
  header("Location: ../index.php?register=success");
}

}
 ?>
