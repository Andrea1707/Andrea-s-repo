-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 30, 2019 at 08:19 PM
-- Server version: 10.1.39-MariaDB
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Esercizio_11`
--

-- --------------------------------------------------------

--
-- Table structure for table `Prodotti`
--

CREATE TABLE `Prodotti` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `prezzo` varchar(100) DEFAULT NULL,
  `quantita` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Prodotti`
--

INSERT INTO `Prodotti` (`id`, `nome`, `prezzo`, `quantita`) VALUES
(1, 'Grande', '100$', 10);

-- --------------------------------------------------------

--
-- Table structure for table `Utenti`
--

CREATE TABLE `Utenti` (
  `username` varchar(45) NOT NULL,
  `pass` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Utenti`
--

INSERT INTO `Utenti` (`username`, `pass`) VALUES
('andrea', '$2y$10$SW0PUjlnBDD7yCJxFPSDHO1yiVGKhMATVsdtCnixq5g7nkcM4D.Rm');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Prodotti`
--
ALTER TABLE `Prodotti`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Utenti`
--
ALTER TABLE `Utenti`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Prodotti`
--
ALTER TABLE `Prodotti`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
