-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2021 at 07:36 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_toko`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `kodeb` varchar(11) NOT NULL,
  `nama` varchar(15) NOT NULL,
  `satuan` varchar(11) NOT NULL,
  `hargab` float NOT NULL,
  `hargaj` float NOT NULL,
  `stock` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`kodeb`, `nama`, `satuan`, `hargab`, `hargaj`, `stock`) VALUES
('B001', 'Kartu IM3', 'Pcs', 5000, 7000, 1000),
('B002', 'Kartu Telkomsel', 'Pcs', 6000, 8000, 2000);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `kodec` varchar(5) NOT NULL,
  `nama` varchar(10) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `telpon` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`kodec`, `nama`, `alamat`, `telpon`) VALUES
('C001', 'Angga', 'Padang, Indonesia', '082389455'),
('C002', 'Ayunita', 'Baso , Agam', '085232323131'),
('C003', 'Rahmat', 'Padang Pangjang , Sumbar', '08213434345');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `nofak` varchar(20) NOT NULL,
  `tfak` date NOT NULL,
  `kodeb` varchar(5) NOT NULL,
  `kodec` varchar(5) NOT NULL,
  `jjual` int(11) NOT NULL,
  `jbayar` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `kodes` varchar(5) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `telpon` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`kodes`, `nama`, `alamat`, `telpon`) VALUES
('S001', 'PT.Telkomsel', 'Padang, Indonesia', '0800080967'),
('S002', 'PT.Indosat', 'Padang, Indonesia', '07527843'),
('S003', 'PT.Smartfren', 'Padang Sidempuan', '072183453');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`kodeb`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`kodec`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`kodeb`,`kodec`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`kodes`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
