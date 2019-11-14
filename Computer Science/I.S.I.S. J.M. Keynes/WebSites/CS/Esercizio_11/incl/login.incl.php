<?php

$user=$_POST['usr'];
$pass=$_POST['pswd'];


if (empty($user) || empty($pass)) {
  header("Location: ../index.php?error=emptyfields");
  exit();
}
require 'dbh.inc.php';
$sql = "SELECT * FROM Utenti WHERE username='$user'";

$result=$conn->query($sql);

if (!$result) {
trigger_error('Invalid query: ' . $conn->error);
}
if ($result->num_rows == 1) {
  $row = $result->fetch_assoc();
  $pwdCheck = password_verify($pass, $row['pass']);
  if ($pwdCheck == true) {
 header("Location: ../pagina/prodotti.php?login=success&user=".$row['username']);
}
}








 ?>
