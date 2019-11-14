-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 11, 2019 at 11:49 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Esercizio_5`
--

-- --------------------------------------------------------

--
-- Table structure for table `Attori`
--

CREATE TABLE `Attori` (
  `id_attore` int(11) NOT NULL,
  `nome` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `data_nascita` date DEFAULT NULL,
  `nazionalita` char(3) COLLATE utf16_bin DEFAULT 'ITA'
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Attori`
--

INSERT INTO `Attori` (`id_attore`, `nome`, `data_nascita`, `nazionalita`) VALUES
(0, 'Ciccio', '2019-01-02', 'ITA');

-- --------------------------------------------------------

--
-- Table structure for table `Film`
--

CREATE TABLE `Film` (
  `id_film` int(11) NOT NULL,
  `titolo` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `anno_produzione` date DEFAULT NULL,
  `nazionalita` char(3) COLLATE utf16_bin DEFAULT 'ITA',
  `regista` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `genere` enum('Horror','Fantascienza','Commedia','Thriller') COLLATE utf16_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Film`
--

INSERT INTO `Film` (`id_film`, `titolo`, `anno_produzione`, `nazionalita`, `regista`, `genere`) VALUES
(0, 'Oh mia bela Madonnina', '2019-03-01', 'ITA', 'Andrea Ferrario', 'Fantascienza');

-- --------------------------------------------------------

--
-- Table structure for table `Film_estratti`
--

CREATE TABLE `Film_estratti` (
  `titolo` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `anno_produzione` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Film_estratti`
--

INSERT INTO `Film_estratti` (`titolo`, `anno_produzione`) VALUES
('Oh mia bela Madonnina', '2019-03-01');

-- --------------------------------------------------------

--
-- Table structure for table `Proiezioni`
--

CREATE TABLE `Proiezioni` (
  `id_proiezione` int(11) NOT NULL,
  `fk_id_film` int(11) DEFAULT NULL,
  `fk_id_sala` int(11) DEFAULT NULL,
  `incasso` float DEFAULT '0',
  `data_proiezione` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Proiezioni`
--

INSERT INTO `Proiezioni` (`id_proiezione`, `fk_id_film`, `fk_id_sala`, `incasso`, `data_proiezione`) VALUES
(0, 0, 0, 100000, '2019-03-22');

-- --------------------------------------------------------

--
-- Table structure for table `Recita`
--

CREATE TABLE `Recita` (
  `fk_id_attore` int(11) DEFAULT NULL,
  `fk_id_film` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Recita`
--

INSERT INTO `Recita` (`fk_id_attore`, `fk_id_film`) VALUES
(0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `Sale`
--

CREATE TABLE `Sale` (
  `id_sala` int(11) NOT NULL,
  `posti` int(11) DEFAULT '0',
  `nome` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `citta` varchar(45) COLLATE utf16_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Sale`
--

INSERT INTO `Sale` (`id_sala`, `posti`, `nome`, `citta`) VALUES
(0, 500, 'MultiSala', 'Varese');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Attori`
--
ALTER TABLE `Attori`
  ADD PRIMARY KEY (`id_attore`);

--
-- Indexes for table `Film`
--
ALTER TABLE `Film`
  ADD PRIMARY KEY (`id_film`);

--
-- Indexes for table `Proiezioni`
--
ALTER TABLE `Proiezioni`
  ADD PRIMARY KEY (`id_proiezione`),
  ADD KEY `fk_id_film` (`fk_id_film`),
  ADD KEY `fk_id_sala` (`fk_id_sala`);

--
-- Indexes for table `Recita`
--
ALTER TABLE `Recita`
  ADD KEY `fk_id_attore` (`fk_id_attore`),
  ADD KEY `fk_id_film` (`fk_id_film`);

--
-- Indexes for table `Sale`
--
ALTER TABLE `Sale`
  ADD PRIMARY KEY (`id_sala`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Proiezioni`
--
ALTER TABLE `Proiezioni`
  ADD CONSTRAINT `Proiezioni_ibfk_1` FOREIGN KEY (`fk_id_film`) REFERENCES `Film` (`id_film`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `Proiezioni_ibfk_2` FOREIGN KEY (`fk_id_sala`) REFERENCES `Sale` (`id_sala`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `Recita`
--
ALTER TABLE `Recita`
  ADD CONSTRAINT `Recita_ibfk_1` FOREIGN KEY (`fk_id_attore`) REFERENCES `Attori` (`id_attore`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `Recita_ibfk_2` FOREIGN KEY (`fk_id_film`) REFERENCES `Film` (`id_film`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
