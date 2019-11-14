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
-- Database: `Esercizio_4`
--

-- --------------------------------------------------------

--
-- Table structure for table `Aereo`
--

CREATE TABLE `Aereo` (
  `tipo_aereo` varchar(45) COLLATE utf8_bin NOT NULL,
  `n_passeggeri` int(11) DEFAULT NULL,
  `q_merce` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `Aereo`
--

INSERT INTO `Aereo` (`tipo_aereo`, `n_passeggeri`, `q_merce`) VALUES
('A120', 50, 500),
('A320', 120, 500),
('A380', 380, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `Aereoporto`
--

CREATE TABLE `Aereoporto` (
  `Citta` varchar(45) COLLATE utf8_bin NOT NULL,
  `Nazione` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `n_piste` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `Aereoporto`
--

INSERT INTO `Aereoporto` (`Citta`, `Nazione`, `n_piste`) VALUES
('Barcellona', 'BRA', NULL),
('Bologna', 'Italia', 2),
('Milano', 'Italia', 5),
('Monaco', 'GER', 20),
('Napoli', 'Italia', 3),
('New York', 'USA', 10),
('Palermo', 'Africa', 1),
('Torino', 'Italia', 9),
('Venezia', 'Italia', 2);

-- --------------------------------------------------------

--
-- Table structure for table `Volo`
--

CREATE TABLE `Volo` (
  `idvolo` int(11) NOT NULL,
  `giorno` date DEFAULT NULL,
  `aereoporto_partenza` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `ora_partenza` time DEFAULT NULL,
  `aereoporto_arrivo` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `tipo_aereo` varchar(45) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `Volo`
--

INSERT INTO `Volo` (`idvolo`, `giorno`, `aereoporto_partenza`, `ora_partenza`, `aereoporto_arrivo`, `tipo_aereo`) VALUES
(1, '2019-02-23', 'Milano', '18:30:00', 'New York', 'A380'),
(2, '2019-02-26', 'Torino', '18:30:00', 'Palermo', 'A120'),
(3, '2019-02-28', 'New York', '22:15:00', 'Venezia', 'A380'),
(4, '2019-02-28', 'Monaco', '21:00:00', 'Torino', 'A120'),
(5, '2019-02-13', 'Napoli', '16:00:00', 'New York', 'A380');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Aereo`
--
ALTER TABLE `Aereo`
  ADD PRIMARY KEY (`tipo_aereo`);

--
-- Indexes for table `Aereoporto`
--
ALTER TABLE `Aereoporto`
  ADD PRIMARY KEY (`Citta`);

--
-- Indexes for table `Volo`
--
ALTER TABLE `Volo`
  ADD PRIMARY KEY (`idvolo`),
  ADD KEY `aereoporto_partenza` (`aereoporto_partenza`),
  ADD KEY `aereoporto_arrivo` (`aereoporto_arrivo`),
  ADD KEY `tipo_aereo` (`tipo_aereo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Volo`
--
ALTER TABLE `Volo`
  MODIFY `idvolo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Volo`
--
ALTER TABLE `Volo`
  ADD CONSTRAINT `Volo_ibfk_1` FOREIGN KEY (`aereoporto_partenza`) REFERENCES `Aereoporto` (`Citta`),
  ADD CONSTRAINT `Volo_ibfk_2` FOREIGN KEY (`aereoporto_arrivo`) REFERENCES `Aereoporto` (`Citta`),
  ADD CONSTRAINT `Volo_ibfk_3` FOREIGN KEY (`tipo_aereo`) REFERENCES `Aereo` (`tipo_aereo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
