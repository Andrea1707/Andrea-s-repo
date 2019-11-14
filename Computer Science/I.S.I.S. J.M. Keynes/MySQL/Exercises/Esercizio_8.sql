-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 02, 2019 at 09:08 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Esercizio_8`
--

-- --------------------------------------------------------

--
-- Table structure for table `Corsi`
--

CREATE TABLE `Corsi` (
  `codcorso` int(11) NOT NULL,
  `numerocorso` int(11) DEFAULT NULL,
  `coddocente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `CorsiDiLaurea`
--

CREATE TABLE `CorsiDiLaurea` (
  `corsodilaurea` varchar(45) NOT NULL,
  `tipodilaurea` enum('Magistrale','Master') DEFAULT NULL,
  `facolta` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Docenti`
--

CREATE TABLE `Docenti` (
  `coddocente` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `dipartimento` enum('Informatica','Medicina','Ingegneria') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Frequenta`
--

CREATE TABLE `Frequenta` (
  `matricola` int(11) DEFAULT NULL,
  `codcorso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Studenti`
--

CREATE TABLE `Studenti` (
  `matricola` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `corsodilaurea` varchar(45) DEFAULT NULL,
  `anno` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Corsi`
--
ALTER TABLE `Corsi`
  ADD PRIMARY KEY (`codcorso`),
  ADD KEY `coddocente` (`coddocente`);

--
-- Indexes for table `CorsiDiLaurea`
--
ALTER TABLE `CorsiDiLaurea`
  ADD PRIMARY KEY (`corsodilaurea`);

--
-- Indexes for table `Docenti`
--
ALTER TABLE `Docenti`
  ADD PRIMARY KEY (`coddocente`);

--
-- Indexes for table `Frequenta`
--
ALTER TABLE `Frequenta`
  ADD KEY `matricola` (`matricola`),
  ADD KEY `codcorso` (`codcorso`);

--
-- Indexes for table `Studenti`
--
ALTER TABLE `Studenti`
  ADD PRIMARY KEY (`matricola`),
  ADD KEY `corsodilaurea` (`corsodilaurea`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Corsi`
--
ALTER TABLE `Corsi`
  ADD CONSTRAINT `Corsi_ibfk_1` FOREIGN KEY (`coddocente`) REFERENCES `Docenti` (`coddocente`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `Frequenta`
--
ALTER TABLE `Frequenta`
  ADD CONSTRAINT `Frequenta_ibfk_1` FOREIGN KEY (`matricola`) REFERENCES `Studenti` (`matricola`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `Frequenta_ibfk_2` FOREIGN KEY (`codcorso`) REFERENCES `Corsi` (`codcorso`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `Studenti`
--
ALTER TABLE `Studenti`
  ADD CONSTRAINT `Studenti_ibfk_1` FOREIGN KEY (`corsodilaurea`) REFERENCES `CorsiDiLaurea` (`corsodilaurea`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
