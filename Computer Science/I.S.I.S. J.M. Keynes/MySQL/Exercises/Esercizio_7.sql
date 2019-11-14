-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 29, 2019 at 08:57 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Esercizio_7`
--

-- --------------------------------------------------------

--
-- Table structure for table `Assicurazioni`
--

CREATE TABLE `Assicurazioni` (
  `codassic` int(10) NOT NULL,
  `nome` char(20) DEFAULT NULL,
  `residenza` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Auto`
--

CREATE TABLE `Auto` (
  `targa` varchar(7) NOT NULL,
  `marca` char(20) DEFAULT NULL,
  `cilindrata` int(5) DEFAULT NULL,
  `potenza` int(5) DEFAULT NULL,
  `cf` varchar(20) DEFAULT NULL,
  `codassic` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Autocoinvolte`
--

CREATE TABLE `Autocoinvolte` (
  `importodeldanno` int(7) DEFAULT NULL,
  `targa` varchar(7) DEFAULT NULL,
  `cods` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Proprietari`
--

CREATE TABLE `Proprietari` (
  `cf` varchar(20) NOT NULL,
  `nome` char(20) DEFAULT NULL,
  `residenza` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Sinistro`
--

CREATE TABLE `Sinistro` (
  `cods` int(10) NOT NULL,
  `localita` varchar(20) DEFAULT NULL,
  `datasin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Assicurazioni`
--
ALTER TABLE `Assicurazioni`
  ADD PRIMARY KEY (`codassic`);

--
-- Indexes for table `Auto`
--
ALTER TABLE `Auto`
  ADD PRIMARY KEY (`targa`),
  ADD KEY `CF` (`cf`),
  ADD KEY `CodAssic` (`codassic`);

--
-- Indexes for table `Autocoinvolte`
--
ALTER TABLE `Autocoinvolte`
  ADD KEY `cods` (`cods`),
  ADD KEY `targa` (`targa`);

--
-- Indexes for table `Proprietari`
--
ALTER TABLE `Proprietari`
  ADD PRIMARY KEY (`cf`);

--
-- Indexes for table `Sinistro`
--
ALTER TABLE `Sinistro`
  ADD PRIMARY KEY (`cods`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Auto`
--
ALTER TABLE `Auto`
  ADD CONSTRAINT `Auto_ibfk_1` FOREIGN KEY (`CF`) REFERENCES `Proprietari` (`CF`),
  ADD CONSTRAINT `Auto_ibfk_2` FOREIGN KEY (`CodAssic`) REFERENCES `Assicurazioni` (`CodAssic`);

--
-- Constraints for table `Autocoinvolte`
--
ALTER TABLE `Autocoinvolte`
  ADD CONSTRAINT `Autocoinvolte_ibfk_1` FOREIGN KEY (`cods`) REFERENCES `Sinistro` (`CodS`),
  ADD CONSTRAINT `Autocoinvolte_ibfk_2` FOREIGN KEY (`targa`) REFERENCES `Auto` (`Targa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
