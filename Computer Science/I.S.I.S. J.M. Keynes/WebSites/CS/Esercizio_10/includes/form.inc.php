<form class="" action="includes/registrazione.inc.php" method="post">
  <div class="form-group">
    <label>Nome</label>
    <br>
    <input type="text" name="nome" placeholder="nome">
  </div>
  <div class="form-group">
    <label>Cognome</label>
    <br>
    <input type="text" name="cognome" placeholder="cognome">
 </div>
 <div class="form-group">
   <label>Data di nacita</label>
   <br>
   <input type="date" name="data">
 </div>
  <div class="form-group">
    <label>Cellulare</label>
    <br>
    <input type="text" name="cellulare" placeholder="cellulare">
 </div>
  <input type="submit" class="btn btn-primary" value="Registrati">
</form>
<?php
echo "<br>";
if (isset($_GET['error'])) {
if ($_GET['error']=='emptyfields') {
  echo '
  <div class="alert alert-danger">
       Riempi tutti i campi!
 </div>';
} elseif ($_GET['error']=='sql') {
  echo '
  <div class="alert alert-danger">
      No injection today!
 </div>';
}
}
if (isset($_GET['signup'])) {
if ($_GET['signup'] == 'success' ) {
  echo '<div class="alert alert-success">
           Ti sei registrato correttamente nel db!
           </div>';
}
}

?>
