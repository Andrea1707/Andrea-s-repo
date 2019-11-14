<?php
function Connection ($db)
{
  $servername = "localhost";
  $username = "root";
  $password = "";


  $conn = new mysqli($servername, $username, $password,$db);


  if ($conn->connect_error) {
      die("Connection failed: " . $conn->connect_error);
  }
  echo "Connected successfully!"." ". $conn->host_info;
  return $conn;
}
?>
