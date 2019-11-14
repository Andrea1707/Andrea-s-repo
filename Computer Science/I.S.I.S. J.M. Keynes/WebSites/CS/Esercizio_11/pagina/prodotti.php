<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="css/master.css">
    <title>Prodotti</title>
  </head>
  <body>
    <?php echo '<h1>Utente registrato: '.$_GET['user']."</h1>"; ?>
    <br>
    <h2>Prodotti</h2>
    <div class="">
      <?php
      require '../incl/lista.inc.php'; ?>
    </div>
  </body>
</html>
