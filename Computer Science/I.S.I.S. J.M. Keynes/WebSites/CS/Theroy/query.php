<?php
require 'connessione.php';
$sql="";
if(!$conn->query($sql));     //Restituisce un array associativo se vero se falso un errore
  echo "Error: "." ".$conn->ERROR;
$query=$conn->query($sql);


 ?>

$query=$conn->query($sql)
$query->INSERT_ID     Restutuisce l'ultimo id dell'ultima tupla inserita
$query->AFFECTED_ROWS Restituisce numero di tuple
$query->NUM_ROWS      ==AFFECT_ROWS ma solo per le interrogazioni


Oggetto:
mysqli
Attributi:
  CONNECT_ERROR
  CONNECT_ERRNO
  HOST_INFO
  ERROR
Metodi:
  query(); ---{true=risorasa OR false=falso}
  Risorsa:
  Attributi:
    INSERT_ID
    AFFECT_ROWS
    NUM_ROWS
  MetodI:
  FETCH_ALL(MYSQLI_NUM, MYSQLI_ASSOC, MYSQLI_BOTH)
    MYSQLI_NUM   array dove gli indici rappresentano la riga che viene estartta;
    MYSQLI_ASSOC array dove gli indici rappresenteranno il nome dei campi selezionati;
    MYSQLI_BOTH accedere con entrambe le modalità

Array associativo quando la sua chiave non è un niomero ma è una stringa


Data una tabella contenente le anagrafiche studenti si vuole creare una pagina web che visualizzi nome, cognome di tutti gli stiudenti;
