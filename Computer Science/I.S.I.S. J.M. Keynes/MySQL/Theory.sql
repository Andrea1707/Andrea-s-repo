--SQL



CREATE DATABASE Database_name ()

CREATE TABLE Table_name
(
  id int(11) PRIMARY KEY,
  fk_id_external_key int(11),
  FOREIGN KEY (id_inside) REFERENCES Table_name(id) ON UPDATE CASCADE ON DELETE SET NULL
	alimentazione ENUM ('GPL','Benzina','Disel'),
)

ALTER TABLE Table_name CHANGE  attribute_name  New_attribute_name parameters


/*
Esercizio:
Autoveicolo(targa, alimentazione, anno di immatricolazione)
Linea(Nome line, Capolinea A, Capolinea B,n fermate, id impiegato, id autoveicolo )

Alimentazione solo di tipi noti
Le linee devono avere un unico nome id
I capolinea devono essere impostati rispettivamente con deposito e stazioni
In oltre le fermate sono almeno 2 una volta creato il db bisogna effettuare mod linea aggiungendo il costo tratta inserire una tupla in auto mezzo 2 tuple indipendenti tralasciando la loro residenza rinominare la tabella linea in tratta eliminare gli automezzi immatricolati nel 1975 aggiornare il campo anno di immatricolazione di automezzo con 1999 se il veicolo e alimentato a gasolio.
*/

/* SELECT ---->   Ci permette di estrarre informazioni dal nostro db.
SELECT ATTRIBITO,ATTRIBUTO@,ATTRIBUTO3,….. FROM table_name1, table_name2…… WHERE condizione
SELECT DISTINCT residenza FROM `Dipendenti`
Premette di rimuover le tuple che comportano determinati attributi ripetuti
Prende i nomi che iniziano per Al
SELECT * FROM Dipendenti WHERE nominativo LIKE 'Al%'
%—> sostituisce uno o più caratteri
_—>sostituisce un carattere
*/



--Costo + iva
SELECT capolinea_a, capolinea_b, costo*1.22 FROM Linea
SELECT capolinea_a, capolinea_b, costo*1.22 AS 'Prezzo iva inclusa' FROM Linea
--Visualizzare 3 automezzi
SELECT * FROM `Autoveicolo` LIMIT 3


/*Esercizio
Aereoporto(Città,nazione,numero piste)
Volo(ID volo,  Day-settimana, città-p,destinazione,ora-p,ora-a,tipo aereo)
Aereo(tipo aereo,n_passeggeri,qtmerci))
*/


--Query:
--Si vuole conoscere le città con un aereo porto di cui non e noto il numero di piste
SELECT DISTINCT Citta FROM Aereoporto WHERE n_piste is null
--Tipi di aereo usati per i voli che partono da Torino
SELECT tipo_aereo FROM `Volo` WHERE aereoporto_partenza="Torino"
--Le città da cui partono voli diretti a bologna
SELECT aereoporto_partenza FROM `Volo` WHERE aereoporto_arrivo="Bolaogna"
--I voli internazionali che partono giovedì da Napoli
SELECT * FROM `Volo`, Aereoporto WHERE Aereoporto_partenza='Napoli' and Volo.aereoporto_arrivo=Aereoporto.Citta and Nazione <> 'Italia'
--I voli che partono nella dalle 8-12 di mattina
SELECT * FROM `Volo` WHERE ora_partenza BETWEEN '8:00:00' and '12:00:00'
--I diversi tipi di aerei
SELECT DISTINCT tipo_aereo FROM `Aereo`
--I dati dei voli effettuati con un numero di passeggeri maggiore di cento

/*
Esercizio
Attori(cod_attore,Nome,COgnome,Anno di nascita, Nazionalita)
Recita(Cod_attore*,cid_film*)
Film(Cod_film, titolo, Anno produzione, Nazionalita, Regista, Genere)
Proiezione(Cod_proiezione, Cod_film*,Cod_Sala*,Incasso, Data Proiezione)
Sale(Cod_sala,Posti,Nome,citta)


Nazionalità default Italia
Genere solo( Horror Commedia )
Incasso def 0
Posti not null
*/

--Query:
--Dato questo schema si vuole conoscere il nome di tutte le sale di Pisa:
SELECT nome FROM Sale WHERE citta='Pisa'
--Il titolo dei film di Ciccio prodotti dopo il 1960:
SELECT titolo FROM `Film` WHERE regista='Ciccio' AND anno_produzione>1960
--Il titolo dei film di fantascienza Giapponesi e francesi dopo il 1990:
SELECT titolo FROM `Film` WHERE (nazionalita='GAP' OR nazionalita='FR') AND genere='Fantascienza' AND anno_produzione>1990
--Il titolo e il genere dei film prodotti il giorno di natale nel 2004:
SELECT titolo,genere FROM `Film`, Proiezioni WHERE data_proiezione='2004-12-25' AND Film.id_film=Proiezioni.fk_id_film
--Il nome delle sale di Napoli in cui sempre nello stesso giorno di natale e stato proiettato un film con Ciro:
SELECT Sale.nome FROM Sale, Proiezioni,Attori,Recita,Film WHERE Attori.nome='Ciro' and Sale.citta='Napoli' AND Proiezioni.data_proiezione='2004-12-25' AND Sale.id_sala=Proiezioni.fk_id_sala and Film.id_film=Proiezioni.fk_id_film AND Film.id_film=Recita.fk_id_film AND Attori.id_attore=Recita.fk_id_attore
--Titolo dei film dove recita Pikaciu o Jessy:
SELECT titolo from Film, Recita, Attori where Recita.fk_id_attore=Attori.id_attore and Recita.fk_id_film=Film.id_film and Attori.nome='Ciccio' or Attori.nome='Jessy'
--Per ogni film in cui recita un attore francese il titolo del film e il nome dell’attore:
SELECT Film.titolo,Attori.nome AS 'Nome attore' from Film, Recita, Attori where Recita.fk_id_attore=Attori.id_attore and Recita.fk_id_film=Film.id_film and Attori.nazionalita='FRN'
--Per ogni film che e stato proiettato a Varese nel gennaio 2019  il titolo deli film e la sala:
SELECT Film.titolo as 'Titolo film:', Sale.nome as 'Nome della sala:' FROM Film, Sale, Proiezioni WHERE Proiezioni.fk_id_film=Film.id_film AND Proiezioni.fk_id_sala=Sale.id_sala AND Proiezioni.data_proiezione BETWEEN '2019-1-1' AND '2019-1-31' AND Sale.citta='Varese'
--Il numero di sale con più di sessanta posti:
SELECT COUNT(*) FROM `Sale` WHERE Sale.posti>50

/*Funzioni di aggregazione:

Count()							*=Conta tutte le tuple, name=Condizione
MAX()
MIN()
AVG()
*/

--Creare una Tabella da una select:
CREATE TABLE Table_name
	Select attribute1, attribute2, ….. FROM Table_name WHERE Condition1, Condition2, …..



--Query:
--Ottenere il codice E titolo delle opere di Tiziano conservate agli Uffizi:
SELECT id_opera, titolo FROM Opere,Artisti,Musei WHERE Opere.fk_nome_artista=Artisti.nome AND Artisti.nome='Tiziano' AND Opere.fk_nome_museo=Musei.nome AND Musei.nome='Uffizi'
--Il nome dell’artista ed il titolo delle opere conservate agli Uffizi o al Louvre:
SELECT Artisti.nome as 'Nome artista:', Opere.titolo as 'Titolo dell opera:' FROM Artisti,Opere,Musei WHERE Musei.nome='Louvre' AND Artisti.nome=Opere.fk_nome_artista AND Opere.fk_nome_museo=Musei.nome
--Il nome dell’artista ed il titolo delle opere conservate nei musei di Milano:
SELECT Artisti.nome as 'Nome artista:', Opere.titolo as 'Titolo dell opera:' FROM Artisti,Opere,Musei WHERE Musei.citta='Milano' AND Artisti.nome=Opere.fk_nome_artista AND Opere.fk_nome_museo=Musei.nome
--Le città in cui sono conservate le opere di Caravaggio
SELECT DISTINCT Musei.citta FROM Musei,Artisti,Opere WHERE Artisti.nome='Caravaggio' AND Artisti.nome=Opere.fk_nome_artista AND Opere.fk_nome_museo=Musei.nome
--Il codice ed il titolo delle opere di Raffaello conservate nei musei di Londra
SELECT id_opera, titolo FROM Opere,Artisti,Musei WHERE Opere.fk_nome_artista=Artisti.nome AND Artisti.nome='Raffaello' AND Opere.fk_nome_museo=Musei.nome AND Musei.citta='Londra'
--Il nome dell’artista e il titolo delle opere di artisti spagnoli conservati nei musei di Firenze
SELECT Artisti.nome, titolo FROM Opere,Artisti,Musei WHERE Opere.fk_nome_artista=Artisti.nome AND Artisti.nazione='SPA' AND Opere.fk_nome_museo=Musei.nome AND Musei.citta='Firenze'
--Il codice il titolo di opere di artisti Italiani conservate nei musei di Londra in cui è rappresentata la natura morta
SELECT Artisti.nome, Opere.titolo FROM Artisti,Opere,Musei WHERE Musei.citta='Londra' AND Artisti.nazione='ITA' AND Opere.titolo='Natura morta' AND Artisti.nome=Opere.fk_nome_artista AND Opere.fk_nome_museo=Musei.nome


--GROUP BY Syntax:

SELECT column_name(s)
FROM table_name
WHERE condition
GROUP BY column_name(s)
ORDER BY column_name(s);

--ORDER

LIMIT --—> Limita il numeri du tuple visualizzate
ORDER BY 
DESC -- ordina in senso decrescente , —> separa più condizioni di ordinamento (NomeAttributo 1, NomeAttributo 2)

--JOIN

INNER JOIN SecondaTabella /ON tabella1.Attributo1 = Tabella2.Attributo2/ WHERE ….. ;
SELECT * FROM tb_1 INNER JOIN tb_2 USING(X) WHERE……
SELECT * FROM (tb_1 INNER JOIN tb_2 USING(X)) JOIN tb_3 USING(X)  WHERE……
SELECT * FROM tb_1 INNER JOIN tb_2 ON tb_1.X=tb_2.Y WHERE……
