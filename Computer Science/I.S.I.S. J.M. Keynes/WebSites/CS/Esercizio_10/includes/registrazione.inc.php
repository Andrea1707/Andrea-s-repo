<?php
  include 'dbh.inc.php';
    $nome=$_POST['nome'];
    $cognome=$_POST['cognome'];
    $data=$_POST['data'];
    $cellulare=$_POST['cellulare'];


    if (empty($nome)||empty($cognome)||empty($data)||empty($cellulare)) {
      header("Location: ../index.php?error=emptyfields");
    }else {
      $sql = "INSERT INTO Utente(nome, cognome, data_nacita, cellulare) VALUES ( ?, ?, ?, ?);";
      $stmt = $conn->prepare($sql);
      $stmt->bind_param("ssss", $nome, $cognome, $data, $cellulare);
      if ($stmt->execute()) {
        header("Location: ../index.php?signup=success");
      }else {
        header("Location: ../index.php?error=sql");
      }




    }

    $conn->close();
?>
