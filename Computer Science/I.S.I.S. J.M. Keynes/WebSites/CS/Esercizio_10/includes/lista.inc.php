<?php
    include 'dbh.inc.php';
    $sql = "SELECT nome,cognome,data_nacita,cellulare FROM Utente";
    $result = $conn->query($sql);
    if (!$result) {
    trigger_error('Invalid query: ' . $conn->error);
}

    if ($result->num_rows > 0) {
      echo '<table class="table">
            <thead>
              <tr>
                <th scope="col">Nº</th>
                <th scope="col">Nome</th>
                <th scope="col">Cognome</th>
                <th scope="col">Data di nascita</th>
                <th scope="col">Numero di cellunare</th>
                </tr>
            </thead>';
      $cont=0;
      while($row = $result->fetch_assoc()) {
        $cont++;
        echo "<tbody>";
        echo '<tr>';
        echo '<td scope="row">'.$cont.'</td>';
        echo '<td>' . $row['nome'] . '</td>';
        echo '<td>' . $row['cognome'] . '</td>';
        echo '<td>' . $row['data_nacita'] . '</td>';
        echo '<td>' . $row['cellulare'] . '</td>';
        echo "</tr>";
        echo "</tbody>";
      }
      echo '</table>';
      } else {
        echo "0 results";
      }

    $conn->close();
?>
