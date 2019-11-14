-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 11, 2019 at 11:50 AM
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
-- Database: `Esercizio_2`
--

-- --------------------------------------------------------

--
-- Table structure for table `Animale`
--

CREATE TABLE `Animale` (
  `id_animale` int(11) NOT NULL,
  `id_struttura` int(11) DEFAULT NULL,
  `nome` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `razza` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `peso` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `alimentazione` varchar(45) COLLATE utf16_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Animale`
--

INSERT INTO `Animale` (`id_animale`, `id_struttura`, `nome`, `razza`, `peso`, `alimentazione`) VALUES
(1, 2, 'Alessandro', 'Panda', '300', 'Sassi');

-- --------------------------------------------------------

--
-- Table structure for table `Struttura`
--

CREATE TABLE `Struttura` (
  `id_struttura` int(11) NOT NULL,
  `naz` varchar(3) COLLATE utf16_bin DEFAULT NULL,
  `data_inaugurazione` date DEFAULT NULL,
  `citta` varchar(45) COLLATE utf16_bin DEFAULT NULL,
  `numero_dipendenti` int(11) DEFAULT NULL,
  `tipologia` varchar(45) COLLATE utf16_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Dumping data for table `Struttura`
--

INSERT INTO `Struttura` (`id_struttura`, `naz`, `data_inaugurazione`, `citta`, `numero_dipendenti`, `tipologia`) VALUES
(2, 'ITA', '2019-02-15', 'Varese', 50, 'Safari');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Animale`
--
ALTER TABLE `Animale`
  ADD PRIMARY KEY (`id_animale`),
  ADD KEY `id_struttura` (`id_struttura`);

--
-- Indexes for table `Struttura`
--
ALTER TABLE `Struttura`
  ADD PRIMARY KEY (`id_struttura`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Animale`
--
ALTER TABLE `Animale`
  MODIFY `id_animale` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `Struttura`
--
ALTER TABLE `Struttura`
  MODIFY `id_struttura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Animale`
--
ALTER TABLE `Animale`
  ADD CONSTRAINT `Animale_ibfk_1` FOREIGN KEY (`id_struttura`) REFERENCES `Struttura` (`id_struttura`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
