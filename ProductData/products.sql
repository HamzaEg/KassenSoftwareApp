-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 30. Nov 2020 um 12:52
-- Server-Version: 10.4.16-MariaDB
-- PHP-Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kassensoftware`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `products`
--

CREATE TABLE `products` (
  `ProductId` int(11) NOT NULL,
  `ProductKategorie` varchar(35) NOT NULL,
  `productName` varchar(25) NOT NULL,
  `productSN` varchar(20) NOT NULL,
  `productDescription` varchar(20) NOT NULL,
  `productbildpath` varchar(20) NOT NULL,
  `productPreis` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `products`
--

INSERT INTO `products` (`ProductId`, `ProductKategorie`, `productName`, `productSN`, `productDescription`, `productbildpath`, `productPreis`) VALUES
(1, 'Notebooks & Zubehör', 'Notebooks', '2659358', 'LENOVO IdeaPad 3, No', 'laptop', 548.81),
(2, 'Notebooks & Zubehör', 'Ultrabooks', '2674775', 'ACER Swift 3 (SF313-', 'laptop', 1198.02),
(3, 'Notebooks & Zubehör', 'Apple MacBook', '2616169', 'APPLE MVVK2D/A MacBo', 'laptop', 2823.74),
(4, 'Notebooks & Zubehör', 'Gaming-Notebooks', '2698319', 'RAZER Blade Stealth ', 'laptop', 2247.75),
(5, 'Notebooks & Zubehör', 'Netbooks', '2618137', 'LENOVO IdeaPad Slim ', 'laptop', 243.69),
(6, 'PCs & Zubehör', 'Tastaturen', '2048835', 'LOGITECH MK235 Combo', 'PC', 9.99),
(7, 'PCs & Zubehör', 'PC Mäuse', '2515357', 'ISY IMW-501 Funkmaus', 'PC', 9.99),
(8, 'PCs & Zubehör', 'USB-Zubehör', '2496611', 'GOOBAY USB 2.0 Hi-Sp', 'PC', 9.99),
(9, 'PCs & Zubehör', 'PC Lautsprecher', '1704168', 'BOSE Companion 2 Ser', 'PC', 9.99),
(10, 'PCs & Zubehör', 'Webcams', '2697699', 'CONCEPTRONIC AMDIS 1', 'PC', 9.99),
(11, 'Tablets & Zubehör', 'Tablets', '2674928', 'SAMSUNG TAB A7 Wi-Fi', 'Tablet', 99),
(12, 'Tablets & Zubehör', 'Tablets', '254617', 'APPLE iPad mini (201', 'Tablet', 99),
(13, 'Tablets & Zubehör', 'Tablets', '254612', 'AMAZON Fire 7, Table', 'Tablet', 38),
(14, 'Tablets & Zubehör', 'Tablets', '254613', ' ', 'Tablet', 19),
(15, 'Tablets & Zubehör', 'Tablets', '2697699', 'CONCEPTRONIC AMDIS 1', 'Tablet', 49),
(16, 'Drucker & Scanner', 'Drucker', '254615', ' ', 'printer', 99),
(17, 'Drucker & Scanner', 'Drucker', '254616', '', 'printer', 99),
(18, 'Drucker & Scanner', 'Drucker', '254617', '', 'printer', 99),
(19, 'Drucker & Scanner', 'Drucker', '254616', '', 'printer', 99),
(20, 'Drucker & Scanner', 'Drucker', '254617', '', 'printer', 99),
(21, 'Gaming & Gaming-Zubehör', 'Gaming ', '254615', '', 'GamingPC', 99),
(22, 'Gaming & Gaming-Zubehör', 'Gaming ', '254616', '', 'GamingPC', 99),
(23, 'Gaming & Gaming-Zubehör', 'Gaming ', '254617', '', 'GamingPC', 99),
(24, 'Gaming & Gaming-Zubehör', 'Gaming ', '254616', '', 'GamingPC', 99),
(25, 'Gaming & Gaming-Zubehör', 'Gaming ', '254617', '', 'GamingPC', 99),
(26, 'Monitore', 'Monitore', '254615', '', 'Monitore', 99),
(27, 'Monitore', 'Monitor', '254616', '', 'Monitore', 99),
(28, 'Monitore', 'Monitore', '254617', '', 'Monitore', 99),
(29, 'Monitore', 'Monitore', '254616', '', 'Monitore', 99),
(30, 'Monitore', 'Monitore', '254617', '', 'Monitore', 99),
(31, 'Speichermedien', 'Speichermedien', '254615', '', 'speichermedien', 99),
(32, 'Speichermedien', 'Speichermedien', '254616', '', 'speichermedien', 99),
(33, 'Speichermedien', 'Speichermedien', '254617', '', 'speichermedien', 99),
(34, 'Speichermedien', 'Speichermedien', '254616', '', 'speichermedien', 99),
(35, 'Speichermedien', 'Speichermedien', '254617', '', 'speichermedien', 99),
(36, 'Apple & Zubehör', 'Macbook pro ', '254615', ' ', 'Apple', 99),
(37, 'Apple & Zubehör', 'Macbook pro ', '254616', ' ', 'Apple', 99),
(38, 'Apple & Zubehör', 'Macbook pro ', '254617', ' ', 'Apple', 99),
(39, 'Apple & Zubehör', 'Macbook pro ', '254616', ' ', 'Apple', 99),
(40, 'Apple & Zubehör', 'Macbook pro ', '254617', ' ', 'Apple', 99),
(41, 'Software', 'Software', '254615', '', 'Software', 99),
(42, 'Software', 'Software', '254616', '', 'Software', 99),
(43, 'Software', 'Software', '254617', '', 'Software', 99),
(44, 'Software', 'Software', '254616', ' ', 'Software', 99),
(45, 'Software', 'Software', '254617', ' ', 'Software', 99),
(46, 'Netzwerk', 'Netzwerk', '254615', ' ', 'Network', 99),
(47, 'Netzwerk', 'Netzwerk', '254616', ' ', 'Network', 99),
(48, 'Netzwerk', 'Netzwerk', '254617', ' ', 'Network', 99),
(49, 'Netzwerk', 'Netzwerk', '254616', ' ', 'Network', 99),
(50, 'Netzwerk', 'Netzwerk', '254617', '', 'Network', 99);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductId`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `products`
--
ALTER TABLE `products`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
