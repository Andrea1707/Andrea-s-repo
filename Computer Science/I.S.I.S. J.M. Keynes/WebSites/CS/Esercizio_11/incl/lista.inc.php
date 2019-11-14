<?php
    include 'dbh.inc.php';
    $sql = "SELECT * FROM Prodotti";
    $result = $conn->query($sql);
    if (!$result) {
    trigger_error('Invalid query: ' . $conn->error);
}

    if ($result->num_rows > 0) {
      echo '<table class="table">
            <thead>
              <tr>
                <th scope="col">ID</th>
                <th scope="col">Nome</th>
                <th scope="col">Prezzo</th>
                <th scope="col">Quantita</th>
                </tr>
            </thead>';
      $cont=0;
      while($row = $result->fetch_assoc()) {
        $cont++;
        echo "<tbody>";
        echo '<tr>';
        echo '<td scope="row">'.$row['id'].'</td>';
        echo '<td>' . $row['nome'] . '</td>';
        echo '<td>' . $row['prezzo'] . '</td>';
        echo '<td>' . $row['quantita'] . '</td>';
        echo "</tr>";
        echo "</tbody>";
      }
      echo '</table>';
      } else {
        echo "0 results";
      }

    $conn->close();
?>
