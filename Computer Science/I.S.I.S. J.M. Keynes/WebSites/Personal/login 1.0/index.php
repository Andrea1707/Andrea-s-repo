<?php
session_start();
if (isset($_SESSION['userId'])) {
  require 'header_logged.php';
}else {
require 'header.php';
}

 ?>

 <main>

       <?php
        require '';
        ?>


 </main>

 <?php
 require 'footer.php';
 ?>
