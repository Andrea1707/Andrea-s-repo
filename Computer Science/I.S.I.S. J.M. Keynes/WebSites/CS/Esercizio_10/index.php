<?php
    include 'includes/dbh.inc.php';
    ?>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="css/master.css">
    <meta charset="utf-8">
    <title>Esercizio 10</title>
  </head>

  <body>
    <h1>Lista utenti registrati:</h1>
    <br>
    <?php
    include 'includes/lista.inc.php';
     ?>
     <br>
     <div class="div-form">

       <h1>Registrazione:</h1>
       <?php
       include 'includes/form.inc.php';
        ?>
  </div>
  </body>
</html>
