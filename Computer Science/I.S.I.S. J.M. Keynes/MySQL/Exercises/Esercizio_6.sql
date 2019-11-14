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
-- Database: `Esercizio_6`
--

-- --------------------------------------------------------

--
-- Table structure for table `Artisti`
--

CREATE TABLE `Artisti` (
  `nome` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `nazione` varchar(45) COLLATE utf8mb4_bin DEFAULT 'ITA'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Table structure for table `Musei`
--

CREATE TABLE `Musei` (
  `nome` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `citta` varchar(50) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Table structure for table `Opere`
--

CREATE TABLE `Opere` (
  `id_opera` int(11) NOT NULL,
  `titolo` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `fk_nome_museo` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `fk_nome_artista` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Table structure for table `Personaggi`
--

CREATE TABLE `Personaggi` (
  `personaggio` int(11) NOT NULL,
  `fk_id_opera` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Artisti`
--
ALTER TABLE `Artisti`
  ADD PRIMARY KEY (`nome`);

--
-- Indexes for table `Musei`
--
ALTER TABLE `Musei`
  ADD PRIMARY KEY (`nome`);

--
-- Indexes for table `Opere`
--
ALTER TABLE `Opere`
  ADD PRIMARY KEY (`id_opera`),
  ADD KEY `fk_nome_museo` (`fk_nome_museo`),
  ADD KEY `fk_nome_artista` (`fk_nome_artista`);

--
-- Indexes for table `Personaggi`
--
ALTER TABLE `Personaggi`
  ADD PRIMARY KEY (`personaggio`),
  ADD KEY `fk_id_opera` (`fk_id_opera`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Opere`
--
ALTER TABLE `Opere`
  ADD CONSTRAINT `Opere_ibfk_1` FOREIGN KEY (`fk_nome_museo`) REFERENCES `Musei` (`nome`),
  ADD CONSTRAINT `Opere_ibfk_2` FOREIGN KEY (`fk_nome_artista`) REFERENCES `Artisti` (`nome`);

--
-- Constraints for table `Personaggi`
--
ALTER TABLE `Personaggi`
  ADD CONSTRAINT `Personaggi_ibfk_1` FOREIGN KEY (`fk_id_opera`) REFERENCES `Opere` (`id_opera`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
