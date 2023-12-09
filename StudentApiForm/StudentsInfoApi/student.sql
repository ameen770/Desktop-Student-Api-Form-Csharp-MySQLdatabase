-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 08 نوفمبر 2022 الساعة 11:29
-- إصدار الخادم: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student`
--

-- --------------------------------------------------------

--
-- بنية الجدول `student_table`
--

CREATE TABLE `student_table` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Reg` varchar(50) NOT NULL,
  `Class` varchar(50) NOT NULL,
  `Section` varchar(50) NOT NULL,
  `CreateAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `student_table`
--

INSERT INTO `student_table` (`ID`, `Name`, `Password`, `Reg`, `Class`, `Section`, `CreateAt`) VALUES
(1, 'Ameen Hameed', '123', '20_0016', '6', 'CS_AM', '2022-10-04 02:12:14'),
(18, 'Laith', '123', '20_0108', '6', 'CS_AM', '2022-10-07 00:32:35'),
(32, 'Nader', '123', '20_3019', '2', 'CS_PM', '2022-10-07 22:22:29'),
(33, 'Hasan', '123', '20_0047', '4', 'CS_AM', '2022-10-07 22:28:29'),
(34, 'Saleh mohammed ahmed', '123', '20_0133', '666666', 'CS_AM', '2022-10-07 22:46:33'),
(35, 'Khulood Salah', '123', '20_0067', '6', 'CS_AM', '2022-10-08 17:38:39'),
(73, 'Ameen', 'ameen', 'S', 'Cs', 'cs', '2022-11-03 23:07:40'),
(74, 'meeno', 'meeno', 'meeno', 'meeno', 'meeno', '2022-11-03 23:26:34'),
(91, 'امين ', 'امين', '٣٣', '٤', '٦', '2022-11-05 17:55:30'),
(93, 'Ameen Hameed', 'ameen', 'Sanaa', '6', 'CS4', '2022-11-05 20:08:00'),
(98, 'y', 'y', 'y', 'y', 'y', '2022-11-06 23:21:31'),
(100, 'g', 'h', 'h', 'h', 'h', '2022-11-07 01:15:45'),
(101, 'hhhhhh', 'h', 'h', 'h', 'h', '2022-11-07 01:15:47'),
(110, 'مينو', 'مينو', 'مينو', 'مينو', 'مينو', '2022-11-07 22:23:22'),
(111, 'عزي', 'عزي', 'v', 'v', 'v', '2022-11-08 01:29:33');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student_table`
--
ALTER TABLE `student_table`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `student_table`
--
ALTER TABLE `student_table`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=113;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
