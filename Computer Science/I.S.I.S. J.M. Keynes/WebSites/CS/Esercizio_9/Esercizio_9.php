<?php
  $servername = "localhost";
  $username = "root";
  $password = "";
  $db="Esercizio_9";

  $conn = new mysqli($servername, $username, $password,$db);
  if ($conn->connect_error) {
      die("Connection failed: " . $conn->connect_error);
    }
    echo "Connected successfully!"." ". $conn->host_info;
    echo "&ensp;";

    $sql = "SELECT nome, cognome FROM Studenti";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
      echo "<table>
            <tr>
              <th>Nome</th>
              <th>Cognome</th>
            </tr>";
      while($row = $result->fetch_assoc()) {
        echo "<tr>";
        echo "<td> " . $row['nome'] . " </td>";
        echo "<td> " . $row['cognome'] . " </td>";
        echo "</tr>";
      }
      echo "</table>";
      } else {
        echo "0 results";
      }

    $conn->close();
?>
