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
-- Database: `Esercizio_3`
--

-- --------------------------------------------------------

--
-- Table structure for table `Autoveicolo`
--

CREATE TABLE `Autoveicolo` (
  `targa` varchar(7) COLLATE utf8mb4_bin NOT NULL,
  `alimentazione` enum('GPL','Benzina','Disel') COLLATE utf8mb4_bin DEFAULT NULL,
  `anno_di_immatricolazione` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `Autoveicolo`
--

INSERT INTO `Autoveicolo` (`targa`, `alimentazione`, `anno_di_immatricolazione`) VALUES
('78fgh85', 'Benzina', '2019-02-04'),
('78fgh89', 'Benzina', '2019-02-05'),
('DP997DR', 'Disel', '2008-02-11');

-- --------------------------------------------------------

--
-- Table structure for table `Dipendenti`
--

CREATE TABLE `Dipendenti` (
  `id_dipendente` int(11) NOT NULL,
  `data_di_nascita` date DEFAULT NULL,
  `residenza` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `nominativo` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `Dipendenti`
--

INSERT INTO `Dipendenti` (`id_dipendente`, `data_di_nascita`, `residenza`, `nominativo`) VALUES
(1, '2019-02-05', 'Varese', 'Giovanni'),
(2, '2019-02-05', 'Varese', 'Alberto'),
(3, '2019-02-05', 'Milano', 'Matteo');

-- --------------------------------------------------------

--
-- Table structure for table `Linea`
--

CREATE TABLE `Linea` (
  `nome_linea` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `capolinea_a` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `capolinea_b` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `n_fermate` int(11) DEFAULT NULL,
  `id_dipendente` int(11) DEFAULT NULL,
  `targa` varchar(7) COLLATE utf8mb4_bin DEFAULT NULL,
  `prezzo` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `Linea`
--

INSERT INTO `Linea` (`nome_linea`, `capolinea_a`, `capolinea_b`, `n_fermate`, `id_dipendente`, `targa`, `prezzo`) VALUES
('Azzate-Varese', 'Azzate', 'Varese', 6, 1, 'DP997DR', 5.9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Autoveicolo`
--
ALTER TABLE `Autoveicolo`
  ADD PRIMARY KEY (`targa`);

--
-- Indexes for table `Dipendenti`
--
ALTER TABLE `Dipendenti`
  ADD PRIMARY KEY (`id_dipendente`);

--
-- Indexes for table `Linea`
--
ALTER TABLE `Linea`
  ADD PRIMARY KEY (`nome_linea`),
  ADD KEY `id_dipendente` (`id_dipendente`),
  ADD KEY `targa` (`targa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Dipendenti`
--
ALTER TABLE `Dipendenti`
  MODIFY `id_dipendente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Linea`
--
ALTER TABLE `Linea`
  ADD CONSTRAINT `Linea_ibfk_1` FOREIGN KEY (`id_dipendente`) REFERENCES `Dipendenti` (`id_dipendente`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `Linea_ibfk_2` FOREIGN KEY (`targa`) REFERENCES `Autoveicolo` (`targa`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
