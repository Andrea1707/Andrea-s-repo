<?php


if(loginFunction()==true){
  if (checkTime()==false) {

    $session=$_SESSION["utente"]=hash("sha256",openssl_random_pseudo_bytes(64));
    $expiretime=strtotime("+ 2 hours");


    checkToken();

    $sql = "INSERT INTO Sessions (session_id, expire_time, fk_email)
              VALUES ('$session', '$expiretime', '$user')";

    if (mysqli_query($conn, $sql)) {
          echo "New record created successfully";
        } else {
          echo "Error: " . $sql . "<br>" . mysqli_error($conn);
        }
    mysqli_close($conn);


  }else{
    $sql="SELECT session_id FROM Sessions where email='$user' ";

    $session=$_SESSION["utente"]=mysqli_query($conn, $sql);;
    echo $session;
  }

  }


  function checkToken(){
    include 'db-connection.inc.php';
    global $user;
    $sql="DELETE FROM Sessions WHERE fk_email='$user'";
    if (mysqli_query($conn, $sql)) {

    } else {

    }
    mysqli_close($conn);


  }




  function checkTime(){
    include 'db-connection.inc.php';
    global $user;
    $sql = "SELECT expire_time FROM Sessions WHERE fk_email='$user'";
    $result = mysqli_query($conn, $sql);

    if (mysqli_num_rows($result) > 0) {
    // output data of each row
    while($row = mysqli_fetch_assoc($result)) {
      if($row["expire_time"]>strtotime("now")){
        return true;
      }
    }
    } else {
        return false;
    }

    $conn->close();
  }



 ?>
