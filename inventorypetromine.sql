-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 19, 2019 at 05:37 AM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `inventorypetromine`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE IF NOT EXISTS `tbl_account` (
  `accountID` int(50) NOT NULL AUTO_INCREMENT,
  `fname` varchar(100) NOT NULL,
  `mname` char(3) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `designationID` int(11) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `passKey` varchar(100) NOT NULL,
  `userTypeID` int(11) NOT NULL,
  `is_active` tinyint(2) NOT NULL,
  PRIMARY KEY (`accountID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`accountID`, `fname`, `mname`, `lname`, `designationID`, `UserName`, `passKey`, `userTypeID`, `is_active`) VALUES
(1, 'Marth', 'L.', 'Enriquez', 1, 'lokaloka', 'akoyun', 1, 1),
(6, 'Jessamine', 'D.', 'Pingol', 10, 'JDP@22', 'kingsolomon', 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_area`
--

CREATE TABLE IF NOT EXISTS `tbl_area` (
  `areaID` int(20) NOT NULL AUTO_INCREMENT,
  `areaDesc` varchar(100) NOT NULL,
  PRIMARY KEY (`areaID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=32 ;

--
-- Dumping data for table `tbl_area`
--

INSERT INTO `tbl_area` (`areaID`, `areaDesc`) VALUES
(3, 'Rotary'),
(5, 'Office'),
(9, 'Stock Room'),
(28, 'Warehouse'),
(29, 'Eng'''),
(30, 'Engg'),
(31, '(SELECT areaDesc FROM tbl_area WHERE areaID = 30)''');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE IF NOT EXISTS `tbl_category` (
  `catID` int(20) NOT NULL AUTO_INCREMENT,
  `catDesc` varchar(100) NOT NULL,
  PRIMARY KEY (`catID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`catID`, `catDesc`) VALUES
(1, 'PPE'),
(3, 'Office'),
(5, 'Rotary'),
(6, 'Lab'),
(7, 'Warehouse'),
(9, 'WWTF'),
(11, 'Production'),
(13, 'ENGG'),
(15, 'sa');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_city`
--

CREATE TABLE IF NOT EXISTS `tbl_city` (
  `cityID` int(20) NOT NULL AUTO_INCREMENT,
  `cityDesc` varchar(255) NOT NULL,
  PRIMARY KEY (`cityID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `tbl_city`
--

INSERT INTO `tbl_city` (`cityID`, `cityDesc`) VALUES
(1, 'Caloocan City'),
(2, 'Queztion City'),
(4, 'Bacolod City');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_client`
--

CREATE TABLE IF NOT EXISTS `tbl_client` (
  `clientID` int(20) NOT NULL AUTO_INCREMENT,
  `clientCode` varchar(50) NOT NULL,
  `Company` varchar(255) NOT NULL,
  `clientName` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `ContactPerson` int(11) NOT NULL,
  `cnum` int(11) NOT NULL,
  `Email` varchar(255) NOT NULL,
  PRIMARY KEY (`clientID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `tbl_client`
--

INSERT INTO `tbl_client` (`clientID`, `clientCode`, `Company`, `clientName`, `Address`, `ContactPerson`, `cnum`, `Email`) VALUES
(1, 'CD001', 'Daedck Phils. Inc.', 'golo', 'Malaysia', 2147483647, 97420392, 'DeadckPI@yahoo.com'),
(3, 'CD002', 'San Technology inc.', 'Vidal', 'China', 9203810, 927324, 'SanTecInc@yahoo.com'),
(4, 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', 2147483647, 272324, 'PalaisadaanInc@yahoo.com'),
(5, 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', 2147483647, 8232442, 'MessiahHardware@yahoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE IF NOT EXISTS `tbl_customer` (
  `custID` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(255) NOT NULL,
  `mi` char(3) DEFAULT NULL,
  `lname` varchar(255) NOT NULL,
  `sex` varchar(7) NOT NULL,
  `age` int(3) NOT NULL,
  `lot.` varchar(255) NOT NULL,
  `pkg.` varchar(255) NOT NULL,
  `street` varchar(255) NOT NULL,
  `brgy` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `contact` varchar(255) NOT NULL,
  PRIMARY KEY (`custID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `tbl_customer`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_department`
--

CREATE TABLE IF NOT EXISTS `tbl_department` (
  `deptID` int(20) NOT NULL AUTO_INCREMENT,
  `deptDesc` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`deptID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tbl_department`
--

INSERT INTO `tbl_department` (`deptID`, `deptDesc`) VALUES
(1, 'HR department'),
(2, 'Office Department'''),
(4, 'Warehouse Factory'),
(5, 'Accounting Department'),
(6, 'office department''');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_designation`
--

CREATE TABLE IF NOT EXISTS `tbl_designation` (
  `designationID` int(20) NOT NULL AUTO_INCREMENT,
  `designationDesc` varchar(255) NOT NULL,
  `deptDesc` varchar(255) NOT NULL,
  PRIMARY KEY (`designationID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tbl_designation`
--

INSERT INTO `tbl_designation` (`designationID`, `designationDesc`, `deptDesc`) VALUES
(1, 'HR', 'HR Department'),
(5, 'Production Manager', 'Office '),
(6, 'Accounting', 'Account Department'),
(9, 'Worker', 'Logistic Department'),
(10, 'Inventory Clerk', 'Office');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

CREATE TABLE IF NOT EXISTS `tbl_employee` (
  `empID` int(20) NOT NULL AUTO_INCREMENT,
  `fname` varchar(30) NOT NULL,
  `mi` varchar(5) DEFAULT NULL,
  `lname` varchar(30) NOT NULL,
  `bday` date DEFAULT NULL,
  `blk` varchar(50) DEFAULT NULL,
  `lot` varchar(50) DEFAULT NULL,
  `street` varchar(50) DEFAULT NULL,
  `brgy` varchar(50) NOT NULL,
  `cityID` int(11) NOT NULL,
  `cnum` int(12) DEFAULT NULL,
  `designationID` int(20) NOT NULL,
  `deptID` int(20) NOT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `tbl_employee`
--

INSERT INTO `tbl_employee` (`empID`, `fname`, `mi`, `lname`, `bday`, `blk`, `lot`, `street`, `brgy`, `cityID`, `cnum`, `designationID`, `deptID`) VALUES
(11, 'Hannah', 'P.', 'Mativo', '1997-09-16', '12', '12', 'Carmel St.', '183', 1, 2147483647, 1, 1),
(12, 'Erick', 'A.', 'Golo', '1994-10-06', '06', '21', 'Steve Street', 'Manggahan', 2, 2147483647, 6, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_endproductonhand`
--

CREATE TABLE IF NOT EXISTS `tbl_endproductonhand` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_Name` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `catID` int(11) NOT NULL,
  `unitID` int(11) NOT NULL,
  `price` double(10,2) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `tbl_endproductonhand`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_finishedproducts`
--

CREATE TABLE IF NOT EXISTS `tbl_finishedproducts` (
  `finprodID` int(11) NOT NULL AUTO_INCREMENT,
  `prodName` varchar(255) NOT NULL,
  `descrip` varchar(255) NOT NULL,
  `catID` int(11) NOT NULL,
  `unitID` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`finprodID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Dumping data for table `tbl_finishedproducts`
--

INSERT INTO `tbl_finishedproducts` (`finprodID`, `prodName`, `descrip`, `catID`, `unitID`, `price`, `qty`) VALUES
(15, 'COPPER', 'mineral', 14, 12, '100.00', 345),
(22, 'SURIF', 'Equipments', 14, 6, '50.00', 15),
(14, 'Industrial Waste', 'Non-Toxic And Toxic Waste', 8, 2, '45.00', 5201),
(25, 'Ferrous', 'Non-Metallic', 1, 8, '455.00', 79),
(18, 'Alloy', 'Scraps', 13, 1, '125.00', 490),
(21, 'Metal', 'Best Programming', 3, 1, '220.00', 1318);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login`
--

CREATE TABLE IF NOT EXISTS `tbl_login` (
  `logId` int(11) NOT NULL AUTO_INCREMENT,
  `_Username` varchar(255) NOT NULL,
  `_Password` varchar(255) NOT NULL,
  `Emp_name` int(255) NOT NULL,
  PRIMARY KEY (`logId`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbl_login`
--

INSERT INTO `tbl_login` (`logId`, `_Username`, `_Password`, `Emp_name`) VALUES
(1, 'admin', 'admin', 1),
(2, 'edmin', 'edmin', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_loginhistory`
--

CREATE TABLE IF NOT EXISTS `tbl_loginhistory` (
  `loginID` int(11) NOT NULL AUTO_INCREMENT,
  `accountID` int(50) NOT NULL,
  `dateIn` datetime DEFAULT NULL,
  `dateOut` datetime DEFAULT NULL,
  PRIMARY KEY (`loginID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tbl_loginhistory`
--

INSERT INTO `tbl_loginhistory` (`loginID`, `accountID`, `dateIn`, `dateOut`) VALUES
(1, 1, '2019-12-02 10:10:10', '2019-12-02 10:10:10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_mainreqsupplies`
--

CREATE TABLE IF NOT EXISTS `tbl_mainreqsupplies` (
  `reqSupID` int(11) NOT NULL AUTO_INCREMENT,
  `reqSupNo` int(100) NOT NULL,
  `reqBy` varchar(150) NOT NULL,
  `dept` varchar(150) NOT NULL,
  `remarks` varchar(250) NOT NULL,
  `dateRequest` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `unitID` int(11) NOT NULL,
  `qty` float NOT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`reqSupID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=300 ;

--
-- Dumping data for table `tbl_mainreqsupplies`
--

INSERT INTO `tbl_mainreqsupplies` (`reqSupID`, `reqSupNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `rawmaterialID`, `unitID`, `qty`, `is_active`) VALUES
(1, 1, 'ASDS', 'ASDSA', 'ASDASD', '2018-09-09', 9, 0, 12, 1),
(2, 2, 'Grace P. Mativo', 'Office Department', '11', '2018-10-18', 11, 0, 11, 0),
(235, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 0, 2, 1),
(236, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 10, 0, 11, 1),
(237, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 9, 0, 2, 1),
(239, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 0, 2, 1),
(240, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 0, 12, 1),
(241, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 0, 2, 1),
(242, 119, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-07', 9, 0, 18, 1),
(243, 119, 'Hannah P. Mativo', 'HR department', 'ds', '2019-02-07', 9, 0, 9, 1),
(244, 119, 'Hannah P. Mativo', 'HR department', '2', '2019-02-07', 9, 0, 6, 1),
(245, 119, 'Hannah P. Mativo', 'HR department', 'asdasd', '2019-02-07', 10, 0, 12, 1),
(246, 119, 'Hannah P. Mativo', 'HR department', 'asda', '2019-02-07', 10, 0, 12, 1),
(247, 119, 'Hannah P. Mativo', 'HR department', 'asda', '2019-02-07', 9, 0, 11, 1),
(248, 119, 'Hannah P. Mativo', 'HR department', 'asdas', '2019-02-07', 9, 0, 24, 1),
(249, 119, 'Hannah P. Mativo', 'HR department', 'asdas', '2019-02-07', 10, 0, 11, 1),
(257, 120, 'Hannah P. Mativo', 'HR department', 'asdad', '2019-02-07', 10, 0, 11, 1),
(258, 120, 'Hannah P. Mativo', 'HR department', 'asdas', '2019-02-07', 8, 0, 11, 1),
(259, 120, 'Hannah P. Mativo', 'HR department', 'asd', '2019-02-07', 9, 0, 12, 1),
(260, 120, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-07', 8, 0, 12, 1),
(261, 120, 'Hannah P. Mativo', 'HR department', 'jkhjkh', '2019-02-07', 8, 0, 7, 1),
(262, 120, 'Hannah P. Mativo', 'HR department', 'asdasd', '2019-02-07', 8, 0, 24, 1),
(263, 120, 'Hannah P. Mativo', 'HR department', '3', '2019-02-09', 9, 0, 2, 1),
(264, 120, 'Hannah P. Mativo', 'HR department', '2', '2019-02-09', 9, 0, 2, 1),
(272, 121, 'Hannah P. Mativo', 'HR department', 'fer', '2019-02-09', 9, 0, 3, 1),
(273, 122, 'Hannah P. Mativo', 'HR department', '3', '2019-02-09', 9, 0, 6, 1),
(274, 122, 'Hannah P. Mativo', 'HR department', 'fr', '2019-02-09', 0, 0, 6, 1),
(276, 123, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-10', 8, 0, 2, 1),
(277, 123, 'Hannah P. Mativo', 'HR department', 'h', '2019-02-10', 9, 0, 9, 1),
(278, 123, 'Hannah P. Mativo', 'HR department', 'e', '2019-02-10', 8, 0, 6, 1),
(279, 123, 'Hannah P. Mativo', 'HR department', 'rem', '2019-02-10', 10, 0, 37, 1),
(280, 123, 'Hannah P. Mativo', 'HR department', 'rem', '2019-02-10', 9, 0, 62, 1),
(283, 124, 'Hannah P. Mativo', 'HR department', 'rekos', '2019-02-10', 10, 0, 37, 1),
(284, 125, 'Hannah P. Mativo', 'HR department', 'Erick''s Business', '2019-02-10', 9, 0, 61, 1),
(285, 126, 'Hannah P. Mativo', 'HR department', 'Godzilla Business', '2019-02-10', 9, 0, 61, 1),
(286, 127, 'Hannah P. Mativo', 'HR department', 'dear', '2019-02-10', 8, 0, 5, 1),
(287, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 0, 2, 1),
(288, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 0, 2, 1),
(290, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 0, 2, 1),
(291, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 0, 2, 1),
(293, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 0, 2, 1),
(294, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 0, 2, 1),
(295, 23, 'Hannah P. Mativo', 'HR department', 'rer', '2019-02-13', 9, 0, 810, 1),
(296, 23, 'Hannah P. Mativo', 'HR department', 'FOODRAGS', '2019-02-15', 9, 0, 65, 1),
(297, 23, 'Hannah P. Mativo', 'HR department', 'WAREHOUSE', '2019-02-15', 11, 0, 50, 1),
(298, 24, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 0, 5, 1),
(299, 25, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 8, 0, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_maintransaction`
--

CREATE TABLE IF NOT EXISTS `tbl_maintransaction` (
  `salesID` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `endProduct` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `unit` varchar(255) NOT NULL,
  `qty` int(11) NOT NULL,
  `untPrice` varchar(50) NOT NULL,
  `totalPrice` varchar(50) DEFAULT NULL,
  `vat` varchar(50) DEFAULT NULL,
  `NoOfItems` int(11) DEFAULT NULL,
  `sDate` date DEFAULT NULL,
  `empID` int(11) DEFAULT NULL,
  `clientID` int(11) DEFAULT NULL,
  `total` varchar(50) DEFAULT NULL,
  `totalVat` varchar(50) DEFAULT NULL,
  `grandTotal` varchar(50) DEFAULT NULL,
  `amountTendered` varchar(50) DEFAULT NULL,
  `change` varchar(50) DEFAULT NULL,
  `sTime` time DEFAULT NULL,
  PRIMARY KEY (`salesID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=45 ;

--
-- Dumping data for table `tbl_maintransaction`
--

INSERT INTO `tbl_maintransaction` (`salesID`, `itemID`, `endProduct`, `description`, `category`, `unit`, `qty`, `untPrice`, `totalPrice`, `vat`, `NoOfItems`, `sDate`, `empID`, `clientID`, `total`, `totalVat`, `grandTotal`, `amountTendered`, `change`, `sTime`) VALUES
(1, 100, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 3, '20.00', '60.00', '9.00', 15, '2019-02-09', 0, 4, '300.00', '9.00', '309.00', '350', '41.00', '00:31:45'),
(2, 101, 'Non-Ferrous Metals', 'Equipments', 'Warehouse', 'cm', 2, '45.00', '90.00', '13.50', 2, '2019-02-09', 11, 3, '90.00', '13.50', '103.50', '120', '-16.50', '00:35:22'),
(3, 102, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 5, '20.00', '100.00', '15.00', 5, '2019-02-09', 0, 5, '100.00', '15.00', '115.00', '130', '15.00', '00:38:02'),
(4, 103, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 3, '2019-02-09', 11, 5, '660.00', '99.00', '759.00', '1000', '241.00', '00:58:00'),
(5, 104, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 4, '20.00', '80.00', '12.00', 7, '2019-02-10', 11, 4, '740.00', '111.00', '851.00', '1000', '149.00', '15:54:54'),
(6, 104, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 7, '2019-02-10', 11, 4, '740.00', '111.00', '851.00', '1000', '149.00', '15:54:54'),
(7, 105, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 4, '20.00', '80.00', '12.00', 4, '2019-02-11', 11, 3, '80.00', '12.00', '92.00', '100', '8.00', '03:27:45'),
(8, 106, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 3, '20.00', '60.00', '9.00', 6, '2019-02-11', 11, 5, '720.00', '99.00', '819.00', '500', '-319.00', '03:31:08'),
(9, 106, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 6, '2019-02-11', 11, 5, '720.00', '99.00', '819.00', '500', '-319.00', '03:31:08'),
(10, 107, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 2, '20.00', '40.00', '6.00', 2, '2019-02-11', 11, 4, '40.00', '6.00', '46.00', '20', '-26.00', '03:35:03'),
(11, 108, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 1, '20.00', '20.00', '3.00', 1, '2019-02-11', 11, 1, '20.00', '3.00', '23.00', '30', '7.00', '03:47:12'),
(12, 109, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 3, '20.00', '60.00', '9.00', 8, '2019-02-11', 11, 4, '1,160.00', '174.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(13, 109, 'Metal', 'Best Programming', 'Office', 'cm', 5, '220.00', '1100.00', '165.00', 8, '2019-02-11', 11, 4, '1,160.00', '174.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(43, 125, 'Ferrous', 'Non-Metallic', 'PPE', 'Weight', 2, '455.00', '910.00', '136.50', 4, '2019-02-19', 6, 4, '1,160.00', '174.00', '1,334.00', '1334.09', '0.09', '09:19:47'),
(42, 124, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 6, '2019-02-18', 6, 5, '940.00', '141.00', '1,081.00', '1081', '0.00', '23:39:48'),
(41, 124, 'Alloy', 'Scraps', 'ENGG', 'cm', 4, '125.00', '500.00', '75.00', 6, '2019-02-18', 6, 5, '940.00', '141.00', '1,081.00', '1081', '0.00', '23:39:48'),
(40, 123, 'Ferrous', 'Non-Metallic', 'PPE', 'Weight', 9, '455.00', '4095.00', '614.25', 9, '2019-02-18', 6, 4, '4,095.00', '614.25', '4,709.25', '4710', '0.75', '11:03:55'),
(18, 112, 'Non-Ferrous Metals', 'Equipments', 'Warehouse', 'cm', 1, '45.00', '45.00', '6.75', 1, '2019-02-13', 11, 5, '45.00', '6.75', '51.75', '100', '48.25', '03:24:05'),
(19, 113, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 5, '2019-02-13', 11, 5, '815.00', '122.25', '937.25', '1000', '62.75', '03:31:58'),
(20, 113, 'Alloy', 'Scraps', 'ENGG', 'cm', 3, '125.00', '375.00', '56.25', 5, '2019-02-13', 11, 5, '815.00', '122.25', '937.25', '1000', '62.75', '03:31:58'),
(21, 114, 'Alloy', 'Scraps', 'ENGG', 'cm', 495, '125.00', '61875.00', '9281.25', 495, '2019-02-13', 11, 5, '61,875.00', '9281.25', '71,156.25', '100000', '28,843.75', '03:33:56'),
(22, 115, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 1, '20.00', '20.00', '3.00', 51, '2019-02-14', 11, 4, '11,020.00', '1653.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(23, 115, 'Metal', 'Best Programming', 'Office', 'cm', 50, '220.00', '11000.00', '1650.00', 51, '2019-02-14', 11, 4, '11,020.00', '1653.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(24, 116, 'Ferrous-Non', 'Waste', 'Rotary', 'lbs', 2, '560.00', '1120.00', '168.00', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(25, 117, 'Ferrous-Non', 'Waste', 'Rotary', 'lbs', 8, '560.00', '4480.00', '672.00', 10, '2019-02-15', 11, 4, '5,600.00', '672.00', '6,272.00', '7000', '728.00', '20:02:27'),
(26, 118, 'Alloy', 'Scraps', 'ENGG', 'cm', 2, '125.00', '250.00', '37.50', 5, '2019-02-17', 1, 4, '910.00', '99.00', '1,009.00', '1200', '191.00', '13:57:45'),
(27, 118, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 5, '2019-02-17', 1, 4, '910.00', '99.00', '1,009.00', '1200', '191.00', '13:57:45'),
(28, 119, 'Metal', 'Best Programming', 'Office', 'cm', 7, '220.00', '1540.00', '231.00', 7, '2019-02-17', 1, 5, '1,540.00', '231.00', '1,771.00', '2000', '229.00', '14:02:27'),
(29, 120, 'Alloy', 'Scraps', 'ENGG', 'cm', 2, '125.00', '250.00', '37.50', 2, '2019-02-17', 1, 5, '250.00', '37.50', '287.50', '289', '1.50', '14:05:51'),
(30, 121, 'Ferrous-Non', 'Waste', 'Rotary', 'lbs', 2, '560.00', '1120.00', '168.00', 463, '2019-02-17', 1, 5, '258,260.00', '38538.00', '296,798.00', '300000', '3,202.00', '14:13:00'),
(31, 121, 'Metal', 'Best Programming', 'Office', 'cm', 1, '220.00', '220.00', '33.00', 463, '2019-02-17', 1, 5, '258,260.00', '38538.00', '296,798.00', '300000', '3,202.00', '14:13:00'),
(32, 121, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 463, '2019-02-17', 1, 5, '258,260.00', '38538.00', '296,798.00', '300000', '3,202.00', '14:13:00'),
(33, 121, 'Ferrous-Non', 'Waste', 'Rotary', 'lbs', 458, '560.00', '256480.00', '38472.00', 463, '2019-02-17', 1, 5, '258,260.00', '38538.00', '296,798.00', '300000', '3,202.00', '14:13:00'),
(34, 122, 'Metal', 'Best Programming', 'Office', 'cm', 1, '220.00', '220.00', '33.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(35, 122, 'Metal', 'Best Programming', 'Office', 'cm', 56, '220.00', '12320.00', '1848.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(36, 122, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(37, 122, 'Metal', 'Best Programming', 'Office', 'cm', 5, '220.00', '1100.00', '165.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(38, 122, 'Metal', 'Best Programming', 'Office', 'cm', 1, '220.00', '220.00', '33.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(39, 122, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 67, '2019-02-17', 1, 4, '14,740.00', '66.00', '14,806.00', '14806', '0.00', '14:39:00'),
(44, 125, 'Alloy', 'Scraps', 'ENGG', 'cm', 2, '125.00', '250.00', '37.50', 4, '2019-02-19', 6, 4, '1,160.00', '174.00', '1,334.00', '1334.09', '0.09', '09:19:47');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchasereq`
--

CREATE TABLE IF NOT EXISTS `tbl_purchasereq` (
  `purchaseID` int(11) NOT NULL AUTO_INCREMENT,
  `purchaseNo` int(100) NOT NULL,
  `reqBy` varchar(100) NOT NULL,
  `dept` varchar(100) NOT NULL,
  `remarks` varchar(250) DEFAULT NULL,
  `dateRequest` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  `supplierID` int(11) NOT NULL,
  `is_active` tinyint(2) NOT NULL,
  PRIMARY KEY (`purchaseID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=49 ;

--
-- Dumping data for table `tbl_purchasereq`
--

INSERT INTO `tbl_purchasereq` (`purchaseID`, `purchaseNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `rawmaterialID`, `qty`, `supplierID`, `is_active`) VALUES
(1, 1, 'asd', 'asd', 'asdads', '2019-01-09', 8, 12, 0, 1),
(48, 35, 'Hannah P. Mativo', 'HR department', 'Wala kang bilang brad', '2019-02-11', 9, 10, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchasereqmain`
--

CREATE TABLE IF NOT EXISTS `tbl_purchasereqmain` (
  `purchaseID` int(11) NOT NULL AUTO_INCREMENT,
  `purchaseNo` int(100) NOT NULL,
  `reqBy` varchar(100) NOT NULL,
  `dept` varchar(100) NOT NULL,
  `remarks` varchar(250) DEFAULT NULL,
  `dateRequest` date NOT NULL,
  `supplierID` int(20) NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  `is_active` tinyint(2) NOT NULL,
  PRIMARY KEY (`purchaseID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=107 ;

--
-- Dumping data for table `tbl_purchasereqmain`
--

INSERT INTO `tbl_purchasereqmain` (`purchaseID`, `purchaseNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `supplierID`, `rawmaterialID`, `qty`, `is_active`) VALUES
(99, 63, 'Hannah P. Mativo', 'HR department', 'PRODCUT', '2019-02-15', 5, 9, 60, 1),
(100, 64, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-15', 3, 8, 25, 1),
(101, 65, 'Hannah P. Mativo', 'HR department', 'JUNK', '2019-02-15', 3, 10, 20, 1),
(102, 65, 'Hannah P. Mativo', 'HR department', 'JUNK', '2019-02-15', 3, 9, 20, 1),
(103, 66, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-15', 1, 9, 20, 1),
(104, 67, 'Erick A. Golo', 'Accounting Department', '', '2019-02-18', 5, 9, 221, 1),
(105, 68, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 5, 9, 441, 1),
(106, 69, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 4, 9, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchaserequestrelease`
--

CREATE TABLE IF NOT EXISTS `tbl_purchaserequestrelease` (
  `POreqID` int(11) NOT NULL AUTO_INCREMENT,
  `purchaseID` int(11) NOT NULL,
  `supplierID` int(11) NOT NULL,
  `deliverReportNo` varchar(255) NOT NULL,
  `deliveryReportDate` date NOT NULL,
  `receivedBy` varchar(255) NOT NULL,
  `dateReceived` date NOT NULL,
  `rTime` time NOT NULL,
  PRIMARY KEY (`POreqID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=45 ;

--
-- Dumping data for table `tbl_purchaserequestrelease`
--

INSERT INTO `tbl_purchaserequestrelease` (`POreqID`, `purchaseID`, `supplierID`, `deliverReportNo`, `deliveryReportDate`, `receivedBy`, `dateReceived`, `rTime`) VALUES
(1, 17, 6, 'def', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '12:27:21'),
(2, 14, 6, '', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '12:44:39'),
(3, 18, 7, '3e', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '12:47:23'),
(5, 25, 5, '432', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '16:31:52'),
(6, 33, 6, '3', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '16:38:00'),
(7, 33, 7, '32', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '16:42:44'),
(8, 34, 5, 'e2', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '16:46:55'),
(9, 39, 7, '11990-321', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '17:02:46'),
(10, 39, 4, '0028-21', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '17:07:13'),
(11, 18, 5, '44-19', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '17:58:19'),
(12, 18, 5, '0909090', '2018-03-08', 'Hannah Mativo P.', '2019-02-10', '18:08:16'),
(24, 43, 0, 'e324', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:41:14'),
(14, 39, 7, '32', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '00:24:37'),
(15, 39, 7, '1231241', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '10:31:27'),
(16, 39, 7, '9090-92', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '14:39:38'),
(18, 86, 7, '00097', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '15:31:26'),
(19, 39, 1, '123131', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '17:08:58'),
(20, 39, 3, '23141', '2018-03-08', 'Hannah Mativo P.', '2019-02-11', '17:10:42'),
(23, 41, 0, '4334', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:38:57'),
(22, 0, 0, '', '2018-03-08', 'Hannah Mativo P.', '2019-02-12', '00:02:51'),
(25, 40, 0, '543', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:43:20'),
(26, 43, 0, '542', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:46:00'),
(27, 43, 0, '333', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:47:34'),
(28, 46, 0, '432', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '02:49:28'),
(29, 46, 0, 'RWR', '2018-03-08', 'Hannah Mativo P.', '2019-02-13', '03:44:43'),
(30, 45, 0, '0789-8BC', '2018-03-08', 'Hannah Mativo P.', '2019-02-14', '23:03:33'),
(31, 99, 0, '123124', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '02:36:21'),
(32, 99, 0, '32', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '02:42:00'),
(33, 99, 0, '23', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '02:43:51'),
(34, 99, 0, '342', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '02:45:27'),
(35, 99, 0, '43', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '02:47:26'),
(36, 99, 0, '0394', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '19:48:16'),
(37, 100, 0, '0980-432', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '19:56:47'),
(38, 101, 0, '424', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '19:59:01'),
(39, 100, 0, '00011', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '20:08:54'),
(40, 101, 0, '111111', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '20:09:31'),
(41, 100, 0, '1111111', '2018-03-08', 'Hannah Mativo P.', '2019-02-15', '20:11:07'),
(42, 100, 0, '09889-9', '2018-03-08', 'Marth L. Enriquez', '2019-02-17', '05:43:44'),
(43, 104, 0, '0993', '2018-03-08', 'Jessamine D. Pingol', '2019-02-18', '02:12:54'),
(44, 104, 0, '54', '2018-03-08', 'Jessamine D. Pingol', '2019-02-18', '02:15:45');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rawmaterial`
--

CREATE TABLE IF NOT EXISTS `tbl_rawmaterial` (
  `rawmaterialID` int(50) NOT NULL AUTO_INCREMENT,
  `rawmaterialName` varchar(100) NOT NULL,
  `desc` varchar(150) DEFAULT NULL,
  `catID` int(20) NOT NULL,
  `unitID` int(20) NOT NULL,
  `is_active` tinyint(2) NOT NULL,
  PRIMARY KEY (`rawmaterialID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `tbl_rawmaterial`
--

INSERT INTO `tbl_rawmaterial` (`rawmaterialID`, `rawmaterialName`, `desc`, `catID`, `unitID`, `is_active`) VALUES
(8, 'Cobalt', 'Alloys', 11, 3, 1),
(9, 'Monel', 'alloys', 11, 3, 1),
(10, 'Nimonic', 'Alloys', 11, 3, 1),
(11, 'Pewter', 'Alloys', 11, 3, 1),
(13, 'bronze', 'asdas', 7, 3, 1),
(14, 'Copper', 'Mineral', 13, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rawmaterialmonitoring`
--

CREATE TABLE IF NOT EXISTS `tbl_rawmaterialmonitoring` (
  `rawmaterialOnHandID` int(11) NOT NULL AUTO_INCREMENT,
  `transactionNo` int(11) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(255) NOT NULL,
  `supplierName` varchar(255) NOT NULL,
  `deliveryRepNo` int(11) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(255) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=126 ;

--
-- Dumping data for table `tbl_rawmaterialmonitoring`
--

INSERT INTO `tbl_rawmaterialmonitoring` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `qty`) VALUES
(123, 169, '2019-02-19', 'Phcp inc', 'Emily', 1312331, '2019-02-02', 'Hannah Mativo P.', '2019-02-02', 9, 44),
(124, 170, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', 445, '2019-02-06', 'Hannah Mativo P.', '2019-02-06', 9, 34),
(125, 170, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', 445, '2019-02-06', 'Hannah Mativo P.', '2019-02-06', 10, 12),
(122, 168, '2019-02-19', 'kedica', 'Golo', 0, '2019-02-01', 'Hannah Mativo P.', '2019-02-01', 10, 5000),
(121, 167, '2019-02-19', 'kedica', 'Golo', 2, '2019-02-01', '', '2019-02-01', 10, 25),
(120, 166, '2019-02-19', 'Nidec copal phils corp', 'Vidal', 0, '2019-02-01', 'Hannah Mativo P.', '2019-02-01', 9, 500),
(119, 165, '2019-02-19', 'Phcp inc', 'Emily', 43, '2019-02-01', '', '2019-02-01', 10, 3000),
(118, 164, '2019-02-19', 'Phcp inc', 'Emily', 0, '2019-02-01', '', '2019-02-01', 10, 1),
(117, 163, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', 3, '2019-02-01', '', '2019-02-01', 10, 1),
(116, 162, '2019-02-19', 'Phcp inc', 'Emily', 3, '2019-02-01', '', '2019-02-01', 10, 1),
(90, 136, '2019-02-19', 'pcp', 'EMILYA', 2, '2019-03-03', 'Hannah Mativo P.', '2019-03-01', 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rawmaterialonhand`
--

CREATE TABLE IF NOT EXISTS `tbl_rawmaterialonhand` (
  `rawmaterialOnHandID` int(100) NOT NULL AUTO_INCREMENT,
  `transactionNo` int(100) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(250) NOT NULL,
  `supplierName` varchar(150) NOT NULL,
  `deliveryRepNo` int(100) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(200) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `tbl_rawmaterialonhand`
--

INSERT INTO `tbl_rawmaterialonhand` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `qty`) VALUES
(1, 117, '2019-01-19', 'e', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 0),
(5, 120, '2019-01-19', 'Phcp inc', 'Allen', 4, '2019-01-22', 'Emely S. Illano', '2019-01-22', 5, 179),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 21916),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 662),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 831),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 450),
(12, 128, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 12, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 3571);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rawmaterialonhandmain`
--

CREATE TABLE IF NOT EXISTS `tbl_rawmaterialonhandmain` (
  `rawmaterialOnHandID` int(100) NOT NULL DEFAULT '0',
  `transactionNo` int(100) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(250) NOT NULL,
  `supplierName` varchar(150) NOT NULL,
  `deliveryRepNo` int(100) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(200) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_rawmaterialonhandmain`
--

INSERT INTO `tbl_rawmaterialonhandmain` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `qty`) VALUES
(0, 161, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 3, '2019-01-26', 'Emely S. Illano', '2019-01-26', 10, 12),
(1, 117, '2019-01-19', 'Daeduc Phils. Inc', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 5),
(2, 118, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 1),
(3, 119, '2019-01-19', 'Phcp inc', 'Allen', 3, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 4),
(4, 120, '2019-01-19', 'Phcp inc', 'Allen', 4, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 55),
(6, 122, '2019-01-19', 'Phcp inc', 'Allen', 6, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 2),
(7, 123, '2019-01-19', 'Nidec copal phils corp', 'zaito', 7, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 2),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 3638),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 4787),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 13884),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 7938),
(12, 128, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 12, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 2654),
(15, 155, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 10, 20),
(16, 156, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 8, 20),
(17, 157, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 4),
(18, 158, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rawmaterialqty`
--

CREATE TABLE IF NOT EXISTS `tbl_rawmaterialqty` (
  `rawmaterialqtyID` int(11) NOT NULL AUTO_INCREMENT,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  PRIMARY KEY (`rawmaterialqtyID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tbl_rawmaterialqty`
--

INSERT INTO `tbl_rawmaterialqty` (`rawmaterialqtyID`, `rawmaterialID`, `qty`) VALUES
(1, 1, 21);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_receiving`
--

CREATE TABLE IF NOT EXISTS `tbl_receiving` (
  `receivingID` int(100) NOT NULL AUTO_INCREMENT,
  `reqNo` int(100) NOT NULL,
  `areaID` int(20) NOT NULL,
  `dateIn` date NOT NULL,
  PRIMARY KEY (`receivingID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `tbl_receiving`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_recordrawmaterialonhand`
--

CREATE TABLE IF NOT EXISTS `tbl_recordrawmaterialonhand` (
  `rawmaterialOnHandID` int(100) NOT NULL DEFAULT '0',
  `transactionNo` int(100) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(250) NOT NULL,
  `supplierName` varchar(150) NOT NULL,
  `deliveryRepNo` int(100) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(200) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_recordrawmaterialonhand`
--

INSERT INTO `tbl_recordrawmaterialonhand` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `qty`) VALUES
(0, 121, '2019-01-19', 'Phcp inc', 'Allen', 5, '2019-01-22', 'Emely S. Illano', '2019-01-22', 5, 500),
(1, 117, '2019-01-19', 'Daeduc Phils. Inc', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 5),
(2, 118, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 1),
(3, 119, '2019-01-19', 'Phcp inc', 'Allen', 3, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 4),
(4, 120, '2019-01-19', 'Phcp inc', 'Allen', 4, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 55),
(6, 122, '2019-01-19', 'Phcp inc', 'Allen', 6, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 2),
(7, 123, '2019-01-19', 'Nidec copal phils corp', 'zaito', 7, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 2),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 3638),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 4787),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 13884),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 7938),
(12, 128, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 12, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 2654),
(15, 155, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 10, 20),
(16, 156, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 8, 20),
(17, 157, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 4),
(18, 158, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_recrawmaterialonhand`
--

CREATE TABLE IF NOT EXISTS `tbl_recrawmaterialonhand` (
  `rawmaterialOnHandID` int(100) NOT NULL DEFAULT '0',
  `transactionNo` int(100) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(250) NOT NULL,
  `supplierName` varchar(150) NOT NULL,
  `deliveryRepNo` int(100) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(200) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_recrawmaterialonhand`
--

INSERT INTO `tbl_recrawmaterialonhand` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `qty`) VALUES
(0, 121, '2019-01-19', 'Phcp inc', 'Allen', 5, '2019-01-22', 'Emely S. Illano', '2019-01-22', 5, 500),
(1, 117, '2019-01-19', 'Daeduc Phils. Inc', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 5),
(2, 118, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 1),
(3, 119, '2019-01-19', 'Phcp inc', 'Allen', 3, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 4),
(4, 120, '2019-01-19', 'Phcp inc', 'Allen', 4, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 55),
(6, 122, '2019-01-19', 'Phcp inc', 'Allen', 6, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 2),
(7, 123, '2019-01-19', 'Nidec copal phils corp', 'zaito', 7, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 2),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 3638),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 4787),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 13884),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 7938),
(12, 128, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 12, '2019-01-22', 'Emely S. Illano', '2019-01-22', 12, 2654),
(15, 155, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 10, 20),
(16, 156, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 8, 20),
(17, 157, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 4),
(18, 158, '2019-01-19', 'Phcp inc', 'Allen', 2, '2019-01-25', 'Emely S. Illano', '2019-01-25', 12, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_releasing`
--

CREATE TABLE IF NOT EXISTS `tbl_releasing` (
  `releasingID` int(100) NOT NULL AUTO_INCREMENT,
  `reqSupNo` int(100) NOT NULL,
  `releaseBy` varchar(150) NOT NULL,
  `deptEmp` varchar(250) NOT NULL,
  `dateReleased` date NOT NULL,
  PRIMARY KEY (`releasingID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=189 ;

--
-- Dumping data for table `tbl_releasing`
--

INSERT INTO `tbl_releasing` (`releasingID`, `reqSupNo`, `releaseBy`, `deptEmp`, `dateReleased`) VALUES
(1, 1, 'Mae D. Lopez', 'Warehouse Factory', '2018-10-16'),
(2, 12, 'Drexler E. Veydal', 'HR department', '2018-12-09'),
(3, 11, 'Drexler E. Veydal', 'HR department', '2018-12-09'),
(4, 1, 'Drexler E. Veydal', 'HR department', '2018-12-10'),
(5, 14, 'Jorielyn I. Enriquez', 'Office Department', '2018-12-15'),
(6, 15, 'Drexler E. Veydal', 'HR department', '2018-12-22'),
(7, 15, 'Drexler E. Veydal', 'HR department', '2018-12-22'),
(8, 10, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-02'),
(9, 3, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-04'),
(10, 3, 'Drexler E. Veydal', 'HR department', '2019-01-04'),
(11, 16, '', '', '2019-01-04'),
(12, 14, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-04'),
(13, 8, 'Drexler E. Veydal', 'HR department', '2019-01-04'),
(14, 3, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-04'),
(15, 9, 'Drexler E. Veydal', 'HR department', '2019-01-04'),
(16, 20, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-04'),
(17, 21, 'Grace P. Mativo', 'Office Department', '2019-01-04'),
(18, 17, 'Drexler E. Veydal', 'HR department', '2019-01-06'),
(19, 14, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-06'),
(20, 20, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-06'),
(21, 18, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-06'),
(22, 20, 'Drexler E. Veydal', 'HR department', '2019-01-06'),
(23, 21, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-06'),
(24, 21, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-06'),
(25, 22, 'Drexler E. Veydal', 'HR department', '2019-01-06'),
(26, 22, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-06'),
(27, 22, 'Ericka   N.   Malone', 'Office Department', '2019-01-06'),
(28, 22, 'Drexler E. Veydal', 'HR department', '2019-01-06'),
(29, 20, 'Drexler E. Veydal', 'HR department', '2019-01-06'),
(30, 17, 'Drexler E. Veydal', 'HR department', '2019-01-07'),
(31, 21, 'Drexler E. Veydal', 'HR department', '2019-01-07'),
(32, 17, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-07'),
(33, 14, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-07'),
(34, 22, 'Drexler E. Veydal', 'HR department', '2019-01-09'),
(35, 0, '', '', '2019-01-09'),
(36, 20, 'Grace P. Mativo', 'HR department', '2019-01-09'),
(37, 22, 'Grace P. Mativo', 'HR department', '2019-01-09'),
(38, 25, 'Grace P. Mativo', 'HR department', '2019-01-09'),
(39, 18, 'Grace Mativo P.', 'Office Department', '2019-01-10'),
(40, 12, 'Mae Lopez D.', 'Warehouse Factory', '2019-01-10'),
(41, 24, 'Grace Mativo P.', 'Office Department', '2019-01-10'),
(42, 21, 'Ericka   Malone   N.', 'Office Department', '2019-01-10'),
(43, 17, 'Mae Lopez D.', 'Warehouse Factory', '2019-01-11'),
(44, 29, 'Grace Mativo P.', 'Office Department', '2019-01-13'),
(45, 34, 'Grace Mativo P.', 'Office Department', '2019-01-13'),
(46, 33, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-14'),
(47, 37, 'Ericka   N.   Malone', 'Office Department', '2019-01-14'),
(48, 37, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-15'),
(49, 30, 'Grace Mativo P.', 'Office Department', '2019-01-15'),
(50, 37, 'Drexler E. Veydal', 'HR department', '2019-01-15'),
(51, 37, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-15'),
(52, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(53, 27, 'Grace Mativo P.', 'Office Department', '2019-01-15'),
(54, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(55, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-15'),
(56, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(57, 38, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-15'),
(58, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(59, 38, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-15'),
(60, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-15'),
(61, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(62, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-15'),
(63, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-15'),
(64, 38, 'Drexler E. Veydal', 'HR department', '2019-01-15'),
(65, 38, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-15'),
(66, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(67, 38, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-15'),
(68, 38, 'Drexler E. Veydal', 'HR department', '2019-01-15'),
(69, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-15'),
(70, 38, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-16'),
(71, 38, 'Ericka   N.   Malone', 'Office Department', '2019-01-16'),
(72, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(73, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(74, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(75, 39, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-16'),
(76, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(77, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(78, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(79, 39, 'Ericka   N.   Malone', 'Office Department', '2019-01-16'),
(80, 39, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-16'),
(81, 39, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-16'),
(82, 39, 'Ericka   N.   Malone', 'Office Department', '2019-01-16'),
(83, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(84, 39, 'Grace P. Mativo', 'Office Department', '2019-01-16'),
(85, 16, '', '', '2019-01-17'),
(86, 1, '', '', '2019-01-17'),
(87, 39, '', '', '2019-01-17'),
(88, 38, '', '', '2019-01-17'),
(89, 37, '', '', '2019-01-17'),
(90, 36, '', '', '2019-01-17'),
(91, 32, '', '', '2019-01-17'),
(92, 32, '', '', '2019-01-17'),
(93, 36, '', '', '2019-01-17'),
(94, 37, 'Ericka   N.   Malone', 'Office Department', '2019-01-17'),
(95, 37, '', '', '2019-01-17'),
(96, 37, '', '', '2019-01-17'),
(97, 37, '', '', '2019-01-17'),
(98, 37, '', '', '2019-01-17'),
(99, 37, '', '', '2019-01-17'),
(100, 38, 'Grace P. Mativo', 'Office Department', '2019-01-17'),
(101, 39, 'Ericka   N.   Malone', 'Office Department', '2019-01-17'),
(102, 40, 'Ericka   N.   Malone', 'Office Department', '2019-01-17'),
(103, 41, 'Grace P. Mativo', 'Office Department', '2019-01-17'),
(104, 42, 'Ericka   N.   Malone', 'Office Department', '2019-01-18'),
(105, 44, 'Grace Mativo P.', 'Office Department', '2019-01-22'),
(106, 45, 'Grace P. Mativo', 'Office Department', '2019-01-22'),
(107, 46, 'Drexler E. Veydal', 'HR department', '2019-01-22'),
(108, 47, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-22'),
(109, 48, 'Drexler E. Veydal', 'HR department', '2019-01-22'),
(110, 50, 'Grace P. Mativo', 'Office Department', '2019-01-22'),
(111, 50, 'Grace P. Mativo', 'Office Department', '2019-01-22'),
(112, 53, 'Grace P. Mativo', 'Office Department', '2019-01-22'),
(113, 54, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-22'),
(114, 55, 'Grace P. Mativo', 'Office Department', '2019-01-23'),
(115, 57, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-24'),
(116, 59, 'Grace P. Mativo', 'Office Department', '2019-01-24'),
(117, 61, 'Jorielyn I. Enriquez', 'Office Department', '2019-01-24'),
(118, 62, 'Grace P. Mativo', 'Office Department', '2019-01-24'),
(119, 62, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(120, 63, 'Grace P. Mativo', 'Office Department', '2019-01-24'),
(121, 63, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(122, 63, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(123, 63, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(124, 63, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(125, 64, 'Grace P. Mativo', 'Office Department', '2019-01-24'),
(126, 64, '', '', '2019-01-24'),
(127, 64, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(128, 64, 'Grace Mativo P.', 'Office Department', '2019-01-24'),
(129, 64, 'Grace Mativo P.', 'Office Department', '2019-01-25'),
(130, 65, 'Grace P. Mativo', 'Office Department', '2019-01-25'),
(131, 68, 'Grace P. Mativo', 'Office Department', '2019-01-26'),
(132, 69, 'Mae D. Lopez', 'Warehouse Factory', '2019-01-26'),
(133, 72, 'Drexler E. Veydal', 'HR department', '2019-01-26'),
(134, 73, 'Drexler E. Veydal', 'HR department', '2019-01-26'),
(135, 75, 'Grace P. Mativo', 'Office Department', '2019-01-27'),
(136, 79, 'Grace P. Mativo', 'Office Department', '2019-01-27'),
(137, 106, 'Emily S. Ilano', 'Warehouse Factory', '2019-01-27'),
(138, 107, 'Drexler E. Veydal', 'HR department', '2019-01-27'),
(139, 106, 'Rein C. Collada', 'Office Department', '2019-01-27'),
(140, 107, 'Grace Mativo P.', 'Office Department', '2019-01-28'),
(141, 79, 'Grace Mativo P.', 'Office Department', '2019-01-28'),
(142, 109, '', '', '2019-01-28'),
(143, 110, 'Drexler E. Veydal', 'HR department', '2019-01-28'),
(144, 111, 'Annalyn G. Gonzales', 'Warehouse Factory', '2019-01-28'),
(145, 112, 'Emily S. Ilano', 'Warehouse Factory', '2019-01-28'),
(146, 110, 'Grace Mativo P.', 'Office Department', '2019-01-28'),
(147, 113, 'Grace Mativo P.', 'Office Department', '2019-01-28'),
(148, 114, 'Grace P. Mativo', 'Office Department', '2019-01-29'),
(149, 116, 'Hannah P. Mativo', 'HR department', '2019-01-30'),
(150, 113, 'Hannah P. Mativo', 'HR department', '2019-01-31'),
(151, 117, 'Hannah P. Mativo', 'HR department', '2019-01-31'),
(152, 118, 'Hannah P. Mativo', 'HR department', '2019-01-31'),
(153, 114, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(154, 118, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(155, 113, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(156, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(157, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(158, 101, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(159, 103, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(160, 101, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(161, 100, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(162, 100, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(163, 100, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(164, 100, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(165, 100, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(166, 102, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(167, 103, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(168, 104, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(169, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(170, 101, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(171, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(172, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(173, 100, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(174, 120, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(175, 121, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(176, 121, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(177, 124, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(178, 126, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(179, 3, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(180, 3, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(182, 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(183, 21, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(184, 21, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(185, 21, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(186, 23, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(187, 23, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(188, 23, 'Hannah P. Mativo', 'HR department', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reqsupplies`
--

CREATE TABLE IF NOT EXISTS `tbl_reqsupplies` (
  `reqSupID` int(11) NOT NULL AUTO_INCREMENT,
  `reqSupNo` int(100) NOT NULL,
  `reqBy` varchar(150) NOT NULL,
  `dept` varchar(150) NOT NULL,
  `remarks` varchar(250) NOT NULL,
  `dateRequest` date NOT NULL,
  `rawmaterialID` int(50) NOT NULL,
  `qty` float NOT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`reqSupID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

--
-- Dumping data for table `tbl_reqsupplies`
--

INSERT INTO `tbl_reqsupplies` (`reqSupID`, `reqSupNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `rawmaterialID`, `qty`, `is_active`) VALUES
(6, 1, 'Hannah P. Mativo', 'HR department', 'febibgig', '2019-02-11', 8, 1, 1),
(8, 2, 'Hannah P. Mativo', 'HR department', 'hayup ka', '2019-02-11', 8, 5, 1),
(9, 3, 'Hannah P. Mativo', 'HR department', '2', '2019-02-11', 9, 5, 1),
(10, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 5, 1),
(11, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 5, 1),
(12, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 5, 1),
(13, 5, 'Hannah P. Mativo', 'HR department', 'ghhu', '2019-02-11', 9, 30, 1),
(14, 6, 'Hannah P. Mativo', 'HR department', 'plastic', '2019-02-11', 8, 35, 1),
(15, 7, 'Hannah P. Mativo', 'HR department', 'gyu', '2019-02-11', 8, 15, 1),
(16, 8, 'Hannah P. Mativo', 'HR department', 'ft', '2019-02-11', 9, 17, 1),
(17, 9, 'Hannah P. Mativo', 'HR department', 'fake', '2019-02-11', 9, 13, 1),
(18, 10, 'Hannah P. Mativo', 'HR department', '12', '2019-02-11', 10, 13, 1),
(19, 11, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 8, 5, 1),
(20, 11, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 10, 5, 1),
(21, 12, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 9, 5, 1),
(22, 13, 'Hannah P. Mativo', 'HR department', 'fr', '2019-02-11', 8, 4, 1),
(23, 13, 'Hannah P. Mativo', 'HR department', 'fr', '2019-02-11', 11, 10, 1),
(24, 14, 'Hannah P. Mativo', 'HR department', '2', '2019-02-11', 10, 2, 1),
(25, 15, 'Hannah P. Mativo', 'HR department', 'ff', '2019-02-11', 9, 2, 1),
(26, 16, 'Hannah P. Mativo', 'HR department', 'e', '2019-02-11', 8, 4, 1),
(27, 17, 'Hannah P. Mativo', 'HR department', '3', '2019-02-11', 8, 3, 1),
(28, 18, 'Hannah P. Mativo', 'HR department', '3', '2019-02-11', 9, 4, 1),
(29, 19, 'Hannah P. Mativo', 'HR department', 'ffg', '2019-02-11', 9, 2, 1),
(30, 20, 'Hannah P. Mativo', 'HR department', 'g', '2019-02-11', 10, 15, 1),
(31, 21, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-12', 9, 97, 1),
(32, 21, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-12', 11, 11, 1),
(33, 22, 'Hannah P. Mativo', 'HR department', 'STOCKROOM3', '2019-02-12', 10, 25, 1),
(34, 22, 'Hannah P. Mativo', 'HR department', 'STOCKROOM3', '2019-02-12', 8, 10, 1),
(35, 23, 'Hannah P. Mativo', 'HR department', 'DYNAMIC', '2019-02-17', 9, 2, 1),
(36, 24, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 5, 1),
(37, 25, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 8, 2, 1),
(38, 26, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 1052, 1),
(39, 27, 'Erick A. Golo', 'Accounting Department', 'DF', '2019-02-18', 11, 451, 1),
(40, 28, 'Erick A. Golo', 'Accounting Department', 'PURCHASED', '2019-02-18', 10, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stocktaking`
--

CREATE TABLE IF NOT EXISTS `tbl_stocktaking` (
  `stockID` int(100) NOT NULL AUTO_INCREMENT,
  `rawmaterialID` int(50) NOT NULL,
  `qty` int(20) DEFAULT NULL,
  `dateInOut` date NOT NULL,
  PRIMARY KEY (`stockID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tbl_stocktaking`
--

INSERT INTO `tbl_stocktaking` (`stockID`, `rawmaterialID`, `qty`, `dateInOut`) VALUES
(1, 1, 12, '2018-02-13'),
(2, 2, 19, '2018-08-11'),
(3, 0, 2, '2018-08-11'),
(4, 0, 2, '2018-08-11'),
(6, 3, 10, '2018-08-13');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE IF NOT EXISTS `tbl_supplier` (
  `supplierID` int(20) NOT NULL AUTO_INCREMENT,
  `SupplierCode` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `supplierName` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `contactPerson` int(11) NOT NULL,
  `cnum` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  PRIMARY KEY (`supplierID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`supplierID`, `SupplierCode`, `company`, `supplierName`, `Address`, `contactPerson`, `cnum`, `email`) VALUES
(1, 'CD001', 'Daeduc Phils. Inc', 'Zaito', 'Malaysia', 8595848, 73291823, 'DaeducPhils@yahoo.com'),
(3, 'CD002', 'Phcp inc', 'Emily', 'Thailand', 9898898, 8726352, 'PhcpInc@yahoo.com'),
(4, 'CD003', 'Samsung Electro Mechanics', 'Hannah', 'Philippine', 94984747, 73736746, 'SamsungEM@yahoo.com'),
(5, 'CD004', 'kedica', 'Golo', 'Singapore', 3463768, 6384672, 'Kedica@yahoo.com'),
(6, 'CD005', 'Nidec copal phils corp', 'Vidal', 'China', 2345545, 3466454, 'NidecCP@yahoo.com'),
(7, 'CD006', 'Petromine (M) SDN.BHD', 'Jorielyn', 'Victoria Wave, tala caloocan City', 2147483647, 2147483647, 'Petromine@yahoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tempfinishedproducts`
--

CREATE TABLE IF NOT EXISTS `tbl_tempfinishedproducts` (
  `finprodID` int(11) NOT NULL AUTO_INCREMENT,
  `prodName` varchar(255) NOT NULL,
  `descrip` varchar(255) NOT NULL,
  `catID` int(11) NOT NULL,
  `unitID` int(11) NOT NULL,
  `price` double(10,2) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`finprodID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `tbl_tempfinishedproducts`
--

INSERT INTO `tbl_tempfinishedproducts` (`finprodID`, `prodName`, `descrip`, `catID`, `unitID`, `price`, `qty`) VALUES
(4, 'Drun', 'drum', 6, 2, 100.00, 0),
(5, 'junk', 'Garbage', 8, 20, 100.00, 10),
(6, 'helium', 'fe', 3, 20, 190.00, 15),
(7, 'Aluminum', 'Bro', 8, 20, 80.00, 50),
(8, 'fer', 'fer', 8, 20, 16.90, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_temprawmaterialonhand`
--

CREATE TABLE IF NOT EXISTS `tbl_temprawmaterialonhand` (
  `rawmaterialOnHandID` int(11) NOT NULL AUTO_INCREMENT,
  `transactionNo` int(11) NOT NULL,
  `requestDate` date NOT NULL,
  `comSupplier` varchar(250) NOT NULL,
  `supplierName` varchar(150) NOT NULL,
  `deliveryRepNo` int(100) NOT NULL,
  `deliveryRepDate` date NOT NULL,
  `receiveBy` varchar(200) NOT NULL,
  `dateReceive` date NOT NULL,
  `rawmaterialID` int(11) NOT NULL,
  `qty` decimal(10,1) NOT NULL,
  `temptotal` decimal(10,1) NOT NULL,
  PRIMARY KEY (`rawmaterialOnHandID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `tbl_temprawmaterialonhand`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_temptransaction`
--

CREATE TABLE IF NOT EXISTS `tbl_temptransaction` (
  `salesID` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `endProduct` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `unit` varchar(255) NOT NULL,
  `qty` int(11) NOT NULL,
  `untPrice` decimal(15,2) NOT NULL,
  `totalPrice` decimal(15,2) NOT NULL,
  `vat` decimal(15,2) NOT NULL,
  `NoOfItems` int(11) DEFAULT NULL,
  `sDate` date DEFAULT NULL,
  `clientID` int(11) DEFAULT NULL,
  `total` double(12,2) DEFAULT NULL,
  `totalVat` double(12,2) DEFAULT NULL,
  `grandTotal` double(12,2) DEFAULT NULL,
  `amountTendered` double(12,2) DEFAULT NULL,
  `change` double(12,2) DEFAULT NULL,
  `sTime` time DEFAULT NULL,
  `ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`salesID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `tbl_temptransaction`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE IF NOT EXISTS `tbl_transaction` (
  `transID` int(100) NOT NULL AUTO_INCREMENT,
  `finprodID` int(100) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `unitID` int(11) NOT NULL,
  `clientID` int(20) NOT NULL,
  PRIMARY KEY (`transID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tbl_transaction`
--

INSERT INTO `tbl_transaction` (`transID`, `finprodID`, `categoryID`, `unitID`, `clientID`) VALUES
(1, 12, 5, 8, 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_unit`
--

CREATE TABLE IF NOT EXISTS `tbl_unit` (
  `unitID` int(20) NOT NULL AUTO_INCREMENT,
  `unitDesc` varchar(40) NOT NULL,
  PRIMARY KEY (`unitID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Dumping data for table `tbl_unit`
--

INSERT INTO `tbl_unit` (`unitID`, `unitDesc`) VALUES
(1, 'cm'),
(2, 'Roll'),
(3, 'cm'),
(4, 'cm'),
(6, 'cm'),
(7, 'cm'),
(8, 'Weight'),
(9, 'lbs'),
(10, 'cm'),
(11, 'cm'),
(12, 'cm'),
(13, 'cm'),
(14, 'pcs'),
(15, 'Gal'),
(16, 'cm'),
(17, 'cm'),
(18, 'cm'),
(19, 'cm'),
(20, 'cm'),
(21, 'Pack'),
(22, 'Kg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_usertype`
--

CREATE TABLE IF NOT EXISTS `tbl_usertype` (
  `userTypeID` int(10) NOT NULL AUTO_INCREMENT,
  `userDesc` varchar(255) NOT NULL,
  PRIMARY KEY (`userTypeID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbl_usertype`
--

INSERT INTO `tbl_usertype` (`userTypeID`, `userDesc`) VALUES
(1, 'Admin'),
(2, 'ProdMan'),
(3, 'InventoryClerk');

-- --------------------------------------------------------

--
-- Table structure for table `tlb_loghis`
--

CREATE TABLE IF NOT EXISTS `tlb_loghis` (
  `loghisID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(255) NOT NULL,
  `logIn` datetime NOT NULL,
  `logout` datetime DEFAULT NULL,
  `designation` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  PRIMARY KEY (`loghisID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=800 ;

--
-- Dumping data for table `tlb_loghis`
--

INSERT INTO `tlb_loghis` (`loghisID`, `UserName`, `logIn`, `logout`, `designation`, `department`) VALUES
(15, 'Grace Mativo P.', '2019-01-10 04:54:26', NULL, 'Department', 'Office Department'),
(3, 'Grace Mativo P.', '2019-01-09 22:14:54', NULL, 'Department', 'Office Department'),
(4, ' Ericka   Malone   N. ', '2019-01-09 23:27:02', NULL, 'HR Department', 'Office Department'),
(5, 'Grace Mativo P.', '2019-01-10 00:41:55', NULL, 'Department', 'Office Department'),
(6, 'Grace Mativo P.', '2019-01-10 00:44:56', NULL, 'Department', 'Office Department'),
(7, 'Jorielyn Enriquez I.', '2019-01-10 00:46:10', NULL, 'Department', 'Office Department'),
(8, 'Grace Mativo P.', '2019-01-10 00:51:58', NULL, 'Department', 'Office Department'),
(9, 'Grace Mativo P.', '2019-01-10 00:56:22', NULL, 'Department', 'Office Department'),
(10, 'Grace Mativo P.', '2019-01-10 00:58:19', NULL, 'Department', 'Office Department'),
(11, 'Grace Mativo P.', '2019-01-10 01:01:13', NULL, 'Department', 'Office Department'),
(12, 'Grace Mativo P.', '2019-01-10 01:02:56', NULL, 'Department', 'Office Department'),
(13, 'Grace Mativo P.', '2019-01-10 01:05:08', NULL, 'Department', 'Office Department'),
(14, 'Grace Mativo P.', '2019-01-10 01:07:36', NULL, 'Department', 'Office Department'),
(16, 'Grace Mativo P.', '2019-01-10 04:56:40', NULL, 'Department', 'Office Department'),
(17, 'Grace Mativo P.', '2019-01-10 04:57:16', NULL, 'Department', 'Office Department'),
(18, 'Grace Mativo P.', '2019-01-10 05:12:51', NULL, 'Department', 'Office Department'),
(19, 'Grace Mativo P.', '2019-01-10 05:14:38', NULL, 'Department', 'Office Department'),
(20, 'Grace Mativo P.', '2019-01-10 06:24:26', NULL, 'Department', 'Office Department'),
(21, 'Grace Mativo P.', '2019-01-10 06:25:34', NULL, 'Department', 'Office Department'),
(22, 'Grace Mativo P.', '2019-01-10 06:26:21', NULL, 'Department', 'Office Department'),
(23, 'Grace Mativo P.', '2019-01-10 06:27:23', NULL, 'Department', 'Office Department'),
(24, 'Grace Mativo P.', '2019-01-10 06:32:49', NULL, 'Department', 'Office Department'),
(25, 'Grace Mativo P.', '2019-01-10 06:33:54', NULL, 'Department', 'Office Department'),
(26, 'Grace Mativo P.', '2019-01-10 06:37:11', NULL, 'Department', 'Office Department'),
(27, 'Grace Mativo P.', '2019-01-10 06:40:03', NULL, 'Department', 'Office Department'),
(28, 'Grace Mativo P.', '2019-01-10 06:44:52', NULL, 'Department', 'Office Department'),
(29, 'Grace Mativo P.', '2019-01-10 06:47:27', NULL, 'Department', 'Office Department'),
(30, 'Grace Mativo P.', '2019-01-10 06:48:21', NULL, 'Department', 'Office Department'),
(31, ' Ericka   Malone   N. ', '2019-01-10 06:50:18', NULL, 'HR Department', 'Office Department'),
(32, 'Grace Mativo P.', '2019-01-10 06:51:26', '2019-01-10 06:54:35', 'Department', 'Office Department'),
(33, '', '2019-01-10 06:56:07', NULL, '', ''),
(34, ' Ericka   Malone   N. ', '2019-01-10 06:56:16', '2019-01-10 06:56:20', 'HR Department', 'Office Department'),
(35, 'Grace Mativo P.', '2019-01-10 13:49:21', NULL, 'Department', 'Office Department'),
(36, 'Grace Mativo P.', '2019-01-10 13:55:09', '2019-01-10 13:55:56', 'Department', 'Office Department'),
(37, 'Grace Mativo P.', '2019-01-10 14:46:41', '2019-01-10 14:47:53', 'Department', 'Office Department'),
(38, 'Mae Lopez D.', '2019-01-10 15:25:35', NULL, 'Department', 'Warehouse Factory'),
(39, 'Mae Lopez D.', '2019-01-10 15:28:44', NULL, 'Department', 'Warehouse Factory'),
(40, 'Grace Mativo P.', '2019-01-10 15:31:32', NULL, 'Department', 'Office Department'),
(41, 'Grace Mativo P.', '2019-01-10 15:33:49', NULL, 'Department', 'Office Department'),
(42, 'Grace Mativo P.', '2019-01-10 15:34:38', NULL, 'Department', 'Office Department'),
(43, 'Grace Mativo P.', '2019-01-10 15:39:24', NULL, 'Department', 'Office Department'),
(44, 'Grace Mativo P.', '2019-01-10 15:40:25', NULL, 'Department', 'Office Department'),
(45, 'Mae Lopez D.', '2019-01-10 15:41:22', '2019-01-10 15:41:46', 'Department', 'Warehouse Factory'),
(46, 'Grace Mativo P.', '2019-01-10 19:30:58', '2019-01-10 19:31:20', 'Department', 'Office Department'),
(47, ' Ericka   Malone   N. ', '2019-01-10 20:16:07', '2019-01-10 20:16:56', 'HR Department', 'Office Department'),
(48, 'Grace Mativo P.', '2019-01-10 20:19:44', '2019-01-10 20:29:09', 'Department', 'Office Department'),
(49, '', '2019-01-10 23:38:13', NULL, '', ''),
(50, '', '2019-01-10 23:38:22', NULL, '', ''),
(51, 'Jorielyn Enriquez I.', '2019-01-10 23:38:38', '2019-01-10 23:42:41', 'Department', 'Office Department'),
(52, 'Grace Mativo P.', '2019-01-10 23:46:56', '2019-01-10 23:47:14', 'Department', 'Office Department'),
(53, 'Drexler Veydal E.', '2019-01-10 23:48:15', '2019-01-10 23:48:33', 'Department', 'HR department'),
(54, 'Mae Lopez D.', '2019-01-10 23:51:01', '2019-01-10 23:52:37', 'Department', 'Warehouse Factory'),
(55, 'Mae Lopez D.', '2019-01-11 00:00:44', '2019-01-11 00:04:13', 'Department', 'Warehouse Factory'),
(56, '', '2019-01-11 00:06:50', NULL, '', ''),
(57, 'Grace Mativo P.', '2019-01-11 00:08:24', '2019-01-11 00:09:09', 'Department', 'Office Department'),
(58, 'Grace Mativo P.', '2019-01-11 00:12:45', '2019-01-11 00:13:27', 'Department', 'Office Department'),
(59, 'Drexler Veydal E.', '2019-01-11 00:17:48', '2019-01-11 00:48:41', 'Department', 'HR department'),
(60, 'Grace Mativo P.', '2019-01-11 02:07:07', '2019-01-11 02:17:33', 'Department', 'Office Department'),
(61, 'Grace Mativo P.', '2019-01-11 02:36:23', NULL, 'Department', 'Office Department'),
(62, 'Grace Mativo P.', '2019-01-11 02:36:49', '2019-01-11 02:37:08', 'Department', 'Office Department'),
(63, 'Mae Lopez D.', '2019-01-11 02:38:56', '2019-01-11 02:39:36', 'Department', 'Warehouse Factory'),
(64, 'Grace Mativo P.', '2019-01-11 02:42:58', '2019-01-11 02:44:08', 'Department', 'Office Department'),
(65, 'Grace Mativo P.', '2019-01-11 02:44:20', '2019-01-11 02:47:40', 'Department', 'Office Department'),
(66, ' Ericka   Malone   N. ', '2019-01-11 02:47:58', '2019-01-11 02:52:38', 'HR Department', 'Office Department'),
(67, 'Grace Mativo P.', '2019-01-11 02:51:52', '2019-01-11 02:53:35', 'Department', 'Office Department'),
(68, 'Drexler Veydal E.', '2019-01-11 02:53:10', '2019-01-11 02:54:00', 'Department', 'HR department'),
(69, ' Ericka   Malone   N. ', '2019-01-11 02:53:47', NULL, 'HR Department', 'Office Department'),
(70, 'Grace Mativo P.', '2019-01-11 02:54:36', '2019-01-11 02:54:50', 'Department', 'Office Department'),
(71, 'Grace Mativo P.', '2019-01-11 02:55:00', '2019-01-11 02:55:38', 'Department', 'Office Department'),
(72, 'Grace Mativo P.', '2019-01-11 13:32:01', '2019-01-11 13:32:50', 'Department', 'Office Department'),
(73, 'Grace Mativo P.', '2019-01-11 20:13:33', '2019-01-11 20:16:04', 'Department', 'Office Department'),
(74, ' Ericka   Malone   N. ', '2019-01-11 20:16:19', '2019-01-11 20:17:31', 'HR Department', 'Office Department'),
(75, 'Mae Lopez D.', '2019-01-11 22:22:52', '2019-01-11 22:23:27', 'Department', 'Warehouse Factory'),
(76, 'Drexler Veydal E.', '2019-01-11 23:52:38', '2019-01-11 23:52:56', 'Department', 'HR department'),
(77, ' Ericka   Malone   N. ', '2019-01-11 23:53:35', '2019-01-11 23:54:56', 'HR Department', 'Office Department'),
(78, 'Grace Mativo P.', '2019-01-12 00:01:55', '2019-01-12 00:02:15', 'Department', 'Office Department'),
(79, 'Grace Mativo P.', '2019-01-12 00:29:37', '2019-01-12 00:30:32', 'Department', 'Office Department'),
(80, 'Grace Mativo P.', '2019-01-12 00:30:54', '2019-01-12 00:31:22', 'Department', 'Office Department'),
(81, 'Grace Mativo P.', '2019-01-12 00:32:38', '2019-01-12 00:33:42', 'Department', 'Office Department'),
(82, 'Grace Mativo P.', '2019-01-12 00:34:07', '2019-01-12 00:34:59', 'Department', 'Office Department'),
(83, 'Grace Mativo P.', '2019-01-12 00:36:34', '2019-01-12 00:37:03', 'Department', 'Office Department'),
(84, 'Grace Mativo P.', '2019-01-12 00:39:36', NULL, 'Department', 'Office Department'),
(85, 'Grace Mativo P.', '2019-01-12 00:53:05', '2019-01-12 00:54:25', 'Department', 'Office Department'),
(86, 'Grace Mativo P.', '2019-01-12 02:44:32', '2019-01-12 02:45:01', 'Department', 'Office Department'),
(87, 'Mae Lopez D.', '2019-01-12 02:45:14', '2019-01-12 02:48:03', 'Department', 'Warehouse Factory'),
(88, 'Grace Mativo P.', '2019-01-12 02:48:22', '2019-01-12 02:52:52', 'Department', 'Office Department'),
(89, 'Grace Mativo P.', '2019-01-12 08:32:19', '2019-01-12 08:39:40', 'Department', 'Office Department'),
(90, 'Jorielyn Enriquez I.', '2019-01-12 09:55:35', '2019-01-12 09:57:10', 'Department', 'Office Department'),
(91, 'Grace Mativo P.', '2019-01-13 01:25:58', '2019-01-13 01:31:26', 'Department', 'Office Department'),
(92, 'Jorielyn Enriquez I.', '2019-01-13 01:33:32', '2019-01-13 01:36:13', 'Department', 'Office Department'),
(93, 'Grace Mativo P.', '2019-01-13 02:29:52', '2019-01-13 02:30:37', 'Department', 'Office Department'),
(94, 'Grace Mativo P.', '2019-01-13 02:38:22', '2019-01-13 02:39:27', 'Department', 'Office Department'),
(95, 'Grace Mativo P.', '2019-01-13 02:40:36', '2019-01-13 02:41:27', 'Department', 'Office Department'),
(96, 'Grace Mativo P.', '2019-01-13 02:43:09', '2019-01-13 02:43:59', 'Department', 'Office Department'),
(97, 'Grace Mativo P.', '2019-01-13 02:44:34', '2019-01-13 02:45:08', 'Department', 'Office Department'),
(98, 'Mae Lopez D.', '2019-01-13 02:47:20', '2019-01-13 02:48:44', 'Department', 'Warehouse Factory'),
(99, ' Ericka   Malone   N. ', '2019-01-13 03:07:06', '2019-01-13 03:09:53', 'HR Department', 'Office Department'),
(100, 'Grace Mativo P.', '2019-01-13 17:50:59', '2019-01-13 17:51:19', 'Department', 'Office Department'),
(101, 'Grace Mativo P.', '2019-01-13 17:51:39', '2019-01-13 17:52:08', 'Department', 'Office Department'),
(102, 'Grace Mativo P.', '2019-01-13 17:56:03', '2019-01-13 18:00:40', 'Department', 'Office Department'),
(103, 'Mae Lopez D.', '2019-01-13 18:02:17', '2019-01-13 18:02:56', 'Department', 'Warehouse Factory'),
(104, 'Grace Mativo P.', '2019-01-13 18:09:56', '2019-01-13 18:10:14', 'Department', 'Office Department'),
(105, 'Grace Mativo P.', '2019-01-13 18:10:37', '2019-01-13 18:10:46', 'Department', 'Office Department'),
(106, 'Grace Mativo P.', '2019-01-13 18:11:44', '2019-01-13 18:11:51', 'Department', 'Office Department'),
(107, 'Grace Mativo P.', '2019-01-13 19:08:13', '2019-01-13 19:08:37', 'Department', 'Office Department'),
(108, 'Grace Mativo P.', '2019-01-13 20:30:41', '2019-01-13 20:32:22', 'Department', 'Office Department'),
(109, 'Grace Mativo P.', '2019-01-13 22:31:59', '2019-01-13 23:02:53', 'Department', 'Office Department'),
(110, 'Grace Mativo P.', '2019-01-13 23:07:37', '2019-01-13 23:07:57', 'Department', 'Office Department'),
(111, 'Grace Mativo P.', '2019-01-13 23:29:41', '2019-01-13 23:30:26', 'Department', 'Office Department'),
(116, 'Grace Mativo P.', '2019-01-14 00:34:49', '2019-01-14 00:51:57', 'Department', 'Office Department'),
(113, 'Grace Mativo P.', '2019-01-13 23:30:49', '2019-01-13 23:31:15', 'Department', 'Office Department'),
(115, 'Grace Mativo P.', '2019-01-13 23:54:50', '2019-01-13 23:54:55', 'Department', 'Office Department'),
(117, 'Grace Mativo P.', '2019-01-14 00:53:40', '2019-01-14 00:53:50', 'Department', 'Office Department'),
(118, 'Grace Mativo P.', '2019-01-14 01:02:26', '2019-01-14 01:37:01', 'Department', 'Office Department'),
(119, 'Grace Mativo P.', '2019-01-14 01:37:56', '2019-01-14 01:38:15', 'Department', 'Office Department'),
(120, 'Jorielyn Enriquez I.', '2019-01-14 01:57:34', '2019-01-14 01:58:24', 'Department', 'Office Department'),
(121, 'Grace Mativo P.', '2019-01-14 02:04:22', '2019-01-14 02:24:36', 'Department', 'Office Department'),
(122, ' Ericka   Malone   N. ', '2019-01-14 02:30:07', '2019-01-14 02:31:45', 'HR Department', 'Office Department'),
(123, 'Jorielyn Enriquez I.', '2019-01-14 02:57:28', '2019-01-14 03:01:29', 'Department', 'Office Department'),
(124, 'Grace Mativo P.', '2019-01-14 03:58:54', '2019-01-14 04:02:19', 'Department', 'Office Department'),
(125, ' Ericka   Malone   N. ', '2019-01-14 12:11:15', NULL, 'HR Department', 'Office Department'),
(126, 'Grace Mativo P.', '2019-01-14 12:11:56', '2019-01-14 12:15:31', 'Department', 'Office Department'),
(127, 'Grace Mativo P.', '2019-01-14 12:21:34', '2019-01-14 12:58:19', 'Department', 'Office Department'),
(128, 'Grace Mativo P.', '2019-01-14 12:58:44', '2019-01-14 13:00:36', 'Department', 'Office Department'),
(129, 'Grace Mativo P.', '2019-01-14 13:09:06', '2019-01-14 13:09:22', 'Department', 'Office Department'),
(130, 'Mae Lopez D.', '2019-01-14 13:09:50', '2019-01-14 13:10:03', 'Department', 'Warehouse Factory'),
(131, 'Grace Mativo P.', '2019-01-14 13:10:43', '2019-01-14 13:10:57', 'Department', 'Office Department'),
(132, 'Grace Mativo P.', '2019-01-14 13:12:53', '2019-01-14 13:13:01', 'Department', 'Office Department'),
(133, 'Mae Lopez D.', '2019-01-14 13:13:58', '2019-01-14 13:14:08', 'Department', 'Warehouse Factory'),
(134, 'Grace Mativo P.', '2019-01-14 13:14:59', '2019-01-14 13:15:06', 'Department', 'Office Department'),
(135, 'Grace Mativo P.', '2019-01-14 13:23:06', '2019-01-14 13:23:14', 'Department', 'Office Department'),
(136, 'Grace Mativo P.', '2019-01-14 13:23:28', '2019-01-14 13:23:40', 'Department', 'Office Department'),
(137, 'Grace Mativo P.', '2019-01-14 13:24:21', '2019-01-14 13:24:30', 'Department', 'Office Department'),
(138, 'Grace Mativo P.', '2019-01-14 13:41:07', NULL, 'Department', 'Office Department'),
(139, 'Grace Mativo P.', '2019-01-14 13:41:51', NULL, 'Department', 'Office Department'),
(140, 'Mae Lopez D.', '2019-01-14 13:44:45', NULL, 'Department', 'Warehouse Factory'),
(141, 'Grace Mativo P.', '2019-01-14 13:46:27', NULL, 'Department', 'Office Department'),
(142, 'Grace Mativo P.', '2019-01-14 13:51:20', NULL, 'Department', 'Office Department'),
(143, 'Grace Mativo P.', '2019-01-14 13:55:21', '2019-01-14 13:55:58', 'Department', 'Office Department'),
(144, 'Grace Mativo P.', '2019-01-14 13:57:14', '2019-01-14 13:57:58', 'Department', 'Office Department'),
(145, 'Grace Mativo P.', '2019-01-14 14:01:39', NULL, 'Department', 'Office Department'),
(146, 'Mae Lopez D.', '2019-01-14 14:04:14', NULL, 'Department', 'Warehouse Factory'),
(147, 'Grace Mativo P.', '2019-01-14 14:06:33', NULL, 'Department', 'Office Department'),
(148, 'Grace Mativo P.', '2019-01-14 14:08:29', NULL, 'Department', 'Office Department'),
(149, 'Grace Mativo P.', '2019-01-14 14:23:31', '2019-01-14 14:24:53', 'Department', 'Office Department'),
(150, 'Grace Mativo P.', '2019-01-14 18:59:43', '2019-01-14 19:10:32', 'Department', 'Office Department'),
(151, 'Grace Mativo P.', '2019-01-14 19:19:56', '2019-01-14 22:27:15', 'Department', 'Office Department'),
(152, 'Grace Mativo P.', '2019-01-15 02:38:41', '2019-01-15 02:40:05', 'Department', 'Office Department'),
(153, 'Grace Mativo P.', '2019-01-15 02:42:38', NULL, 'Department', 'Office Department'),
(154, 'Grace Mativo P.', '2019-01-15 02:43:51', '2019-01-15 02:45:09', 'Department', 'Office Department'),
(155, 'Grace Mativo P.', '2019-01-15 02:45:34', '2019-01-15 02:47:48', 'Department', 'Office Department'),
(156, 'Grace Mativo P.', '2019-01-15 02:48:54', '2019-01-15 02:49:29', 'Department', 'Office Department'),
(157, 'Grace Mativo P.', '2019-01-15 02:59:15', '2019-01-15 03:00:29', 'Department', 'Office Department'),
(158, 'Grace Mativo P.', '2019-01-15 03:05:17', '2019-01-15 03:05:33', 'Department', 'Office Department'),
(159, 'Grace Mativo P.', '2019-01-15 03:07:15', '2019-01-15 03:08:59', 'Department', 'Office Department'),
(160, 'Grace Mativo P.', '2019-01-15 03:13:24', '2019-01-15 03:16:08', 'Department', 'Office Department'),
(161, 'Grace Mativo P.', '2019-01-15 12:28:52', '2019-01-15 12:29:02', 'Department', 'Office Department'),
(162, 'Grace Mativo P.', '2019-01-15 12:29:30', '2019-01-15 12:31:30', 'Department', 'Office Department'),
(163, 'Grace Mativo P.', '2019-01-15 12:33:05', '2019-01-15 12:38:44', 'Department', 'Office Department'),
(164, 'Grace Mativo P.', '2019-01-15 12:39:37', '2019-01-15 12:42:37', 'Department', 'Office Department'),
(165, 'Grace Mativo P.', '2019-01-15 12:46:51', '2019-01-15 12:47:35', 'Department', 'Office Department'),
(166, 'Grace Mativo P.', '2019-01-15 12:56:19', NULL, 'Department', 'Office Department'),
(167, 'Grace Mativo P.', '2019-01-15 13:04:05', '2019-01-15 13:06:14', 'Department', 'Office Department'),
(168, 'Grace Mativo P.', '2019-01-15 13:15:54', '2019-01-15 13:17:03', 'Department', 'Office Department'),
(169, 'Grace Mativo P.', '2019-01-15 13:20:56', '2019-01-15 13:21:16', 'Department', 'Office Department'),
(170, 'Grace Mativo P.', '2019-01-15 13:23:02', '2019-01-15 13:23:55', 'Department', 'Office Department'),
(171, 'Grace Mativo P.', '2019-01-15 13:46:36', '2019-01-16 01:57:21', 'Department', 'Office Department'),
(172, 'Grace Mativo P.', '2019-01-16 01:57:58', '2019-01-16 02:01:18', 'Department', 'Office Department'),
(173, 'Grace Mativo P.', '2019-01-16 02:11:11', '2019-01-16 02:12:32', 'Department', 'Office Department'),
(174, 'Mae Lopez D.', '2019-01-16 02:50:52', NULL, 'Department', 'Warehouse Factory'),
(175, 'Grace Mativo P.', '2019-01-16 02:58:14', '2019-01-16 04:08:00', 'Department', 'Office Department'),
(176, 'Grace Mativo P.', '2019-01-16 04:22:36', '2019-01-16 04:26:40', 'Department', 'Office Department'),
(177, 'Grace Mativo P.', '2019-01-16 04:35:05', '2019-01-16 04:37:36', 'Department', 'Office Department'),
(178, 'Grace Mativo P.', '2019-01-16 04:45:41', '2019-01-16 04:46:05', 'Department', 'Office Department'),
(179, 'Grace Mativo P.', '2019-01-16 05:06:23', '2019-01-16 05:08:26', 'Department', 'Office Department'),
(180, 'Grace Mativo P.', '2019-01-16 05:26:16', '2019-01-16 05:33:09', 'Department', 'Office Department'),
(181, 'Grace Mativo P.', '2019-01-16 05:56:20', '2019-01-16 05:57:46', 'Department', 'Office Department'),
(182, 'Grace Mativo P.', '2019-01-16 09:12:29', '2019-01-16 09:12:44', 'Department', 'Office Department'),
(183, 'Grace Mativo P.', '2019-01-16 09:53:50', '2019-01-16 09:55:13', 'Department', 'Office Department'),
(184, 'Grace Mativo P.', '2019-01-16 09:57:18', '2019-01-16 09:59:54', 'Department', 'Office Department'),
(185, 'Grace Mativo P.', '2019-01-16 10:01:38', '2019-01-16 10:03:18', 'Department', 'Office Department'),
(186, 'Grace Mativo P.', '2019-01-16 10:08:58', '2019-01-16 10:09:50', 'Department', 'Office Department'),
(187, 'Grace Mativo P.', '2019-01-16 10:10:30', '2019-01-16 10:11:10', 'Department', 'Office Department'),
(188, 'Grace Mativo P.', '2019-01-16 10:14:47', '2019-01-16 10:16:45', 'Department', 'Office Department'),
(189, 'Grace Mativo P.', '2019-01-16 10:16:55', '2019-01-16 10:17:14', 'Department', 'Office Department'),
(190, 'Grace Mativo P.', '2019-01-16 10:19:38', '2019-01-16 10:20:58', 'Department', 'Office Department'),
(191, 'Grace Mativo P.', '2019-01-16 14:02:33', '2019-01-16 14:36:00', 'Department', 'Office Department'),
(192, 'Grace Mativo P.', '2019-01-16 14:37:35', '2019-01-16 14:37:53', 'Department', 'Office Department'),
(193, 'Grace Mativo P.', '2019-01-16 17:26:46', '2019-01-16 17:30:46', 'Department', 'Office Department'),
(194, 'Jorielyn Enriquez I.', '2019-01-16 17:31:16', '2019-01-16 17:32:38', 'Department', 'Office Department'),
(195, 'Grace Mativo P.', '2019-01-16 17:34:42', '2019-01-16 17:35:28', 'Department', 'Office Department'),
(196, 'Grace Mativo P.', '2019-01-16 17:39:33', '2019-01-16 17:52:47', 'Department', 'Office Department'),
(197, 'Grace Mativo P.', '2019-01-16 19:49:15', '2019-01-16 19:53:57', 'Department', 'Office Department'),
(198, 'Grace Mativo P.', '2019-01-16 21:24:33', '2019-01-16 21:25:21', 'Department', 'Office Department'),
(199, 'Grace Mativo P.', '2019-01-16 21:27:04', '2019-01-18 21:46:45', 'Department', 'Office Department'),
(200, 'Grace Mativo P.', '2019-01-18 21:47:11', '2019-01-19 01:57:53', 'Department', 'Office Department'),
(201, 'Grace Mativo P.', '2019-01-19 02:35:13', NULL, 'Department', 'Office Department'),
(202, 'Mae Lopez D.', '2019-01-19 02:44:59', '2019-01-19 02:56:09', 'Department', 'Warehouse Factory'),
(203, 'Grace Mativo P.', '2019-01-19 02:58:28', '2019-01-19 03:09:33', 'Department', 'Office Department'),
(204, 'Grace Mativo P.', '2019-01-19 03:14:28', '2019-01-19 03:15:17', 'Department', 'Office Department'),
(205, 'Grace Mativo P.', '2019-01-19 03:15:22', '2019-01-19 03:16:47', 'Department', 'Office Department'),
(206, 'Grace Mativo P.', '2019-01-19 08:20:24', '2019-01-19 08:22:03', 'Department', 'Office Department'),
(207, 'Grace Mativo P.', '2019-01-19 08:23:45', NULL, 'Department', 'Office Department'),
(208, 'Grace Mativo P.', '2019-01-19 08:27:06', '2019-01-19 08:29:06', 'Department', 'Office Department'),
(209, 'Grace Mativo P.', '2019-01-19 08:29:09', '2019-01-19 08:30:26', 'Department', 'Office Department'),
(210, 'Grace Mativo P.', '2019-01-19 08:31:12', NULL, 'Department', 'Office Department'),
(211, 'Grace Mativo P.', '2019-01-19 08:46:51', '2019-01-19 08:48:15', 'Department', 'Office Department'),
(212, 'Grace Mativo P.', '2019-01-19 08:53:11', '2019-01-19 08:54:39', 'Department', 'Office Department'),
(213, 'Grace Mativo P.', '2019-01-19 08:56:36', '2019-01-19 08:58:23', 'Department', 'Office Department'),
(214, 'Grace Mativo P.', '2019-01-19 08:59:36', '2019-01-19 09:00:23', 'Department', 'Office Department'),
(215, 'Grace Mativo P.', '2019-01-19 09:03:47', NULL, 'Department', 'Office Department'),
(216, 'Grace Mativo P.', '2019-01-19 09:05:16', NULL, 'Department', 'Office Department'),
(217, 'Grace Mativo P.', '2019-01-19 09:06:42', '2019-01-19 09:07:46', 'Department', 'Office Department'),
(218, 'Grace Mativo P.', '2019-01-19 09:10:58', '2019-01-19 09:11:42', 'Department', 'Office Department'),
(219, 'Grace Mativo P.', '2019-01-19 09:12:19', '2019-01-19 09:12:36', 'Department', 'Office Department'),
(220, 'Grace Mativo P.', '2019-01-19 09:13:14', '2019-01-19 09:13:54', 'Department', 'Office Department'),
(221, 'Grace Mativo P.', '2019-01-19 09:59:11', NULL, 'Department', 'Office Department'),
(222, 'Grace Mativo P.', '2019-01-19 10:00:44', '2019-01-19 10:05:48', 'Department', 'Office Department'),
(223, 'Grace Mativo P.', '2019-01-19 10:07:23', '2019-01-19 10:07:43', 'Department', 'Office Department'),
(224, 'Grace Mativo P.', '2019-01-19 10:12:02', '2019-01-19 10:21:35', 'Department', 'Office Department'),
(225, 'Grace Mativo P.', '2019-01-19 11:51:39', '2019-01-19 13:51:19', 'Department', 'Office Department'),
(226, 'Grace Mativo P.', '2019-01-19 13:51:50', '2019-01-19 13:53:18', 'Department', 'Office Department'),
(227, ' Ericka   Malone   N. ', '2019-01-19 14:00:53', '2019-01-19 14:01:11', 'HR Department', 'Office Department'),
(228, 'Grace Mativo P.', '2019-01-19 19:11:03', '2019-01-19 19:11:49', 'Department', 'Office Department'),
(229, 'Mae Lopez D.', '2019-01-19 19:12:30', '2019-01-19 19:14:49', 'Department', 'Warehouse Factory'),
(230, 'Grace Mativo P.', '2019-01-19 19:16:20', '2019-01-19 19:19:36', 'Department', 'Office Department'),
(231, ' Ericka   Malone   N. ', '2019-01-19 19:20:34', '2019-01-19 19:21:43', 'HR Department', 'Office Department'),
(232, 'Grace Mativo P.', '2019-01-19 19:25:25', NULL, 'Department', 'Office Department'),
(233, 'Grace Mativo P.', '2019-01-19 19:39:06', '2019-01-19 19:40:24', 'Department', 'Office Department'),
(234, 'Grace Mativo P.', '2019-01-19 19:42:29', '2019-01-19 19:43:04', 'Department', 'Office Department'),
(235, 'Grace Mativo P.', '2019-01-19 19:47:32', '2019-01-19 19:48:12', 'Department', 'Office Department'),
(236, 'Grace Mativo P.', '2019-01-19 19:49:25', '2019-01-19 19:49:53', 'Department', 'Office Department'),
(237, 'Grace Mativo P.', '2019-01-19 19:51:24', '2019-01-19 19:55:59', 'Department', 'Office Department'),
(238, 'Grace Mativo P.', '2019-01-19 19:58:02', '2019-01-19 19:58:29', 'Department', 'Office Department'),
(239, 'Grace Mativo P.', '2019-01-19 19:59:15', '2019-01-19 20:00:56', 'Department', 'Office Department'),
(240, 'Grace Mativo P.', '2019-01-19 20:09:20', '2019-01-19 20:09:55', 'Department', 'Office Department'),
(241, 'Grace Mativo P.', '2019-01-19 20:11:21', '2019-01-19 20:11:44', 'Department', 'Office Department'),
(242, 'Grace Mativo P.', '2019-01-19 20:12:24', '2019-01-19 20:12:50', 'Department', 'Office Department'),
(243, 'Grace Mativo P.', '2019-01-19 20:16:35', '2019-01-19 20:16:54', 'Department', 'Office Department'),
(244, 'Grace Mativo P.', '2019-01-19 20:18:44', '2019-01-19 20:19:13', 'Department', 'Office Department'),
(245, 'Grace Mativo P.', '2019-01-19 20:20:02', '2019-01-19 20:21:41', 'Department', 'Office Department'),
(246, 'Grace Mativo P.', '2019-01-19 21:43:22', NULL, 'Department', 'Office Department'),
(247, 'Grace Mativo P.', '2019-01-19 21:47:04', '2019-01-19 21:54:54', 'Department', 'Office Department'),
(248, 'Grace Mativo P.', '2019-01-19 22:08:56', '2019-01-19 22:09:45', 'Department', 'Office Department'),
(249, 'Grace Mativo P.', '2019-01-19 22:09:49', '2019-01-20 05:56:42', 'Department', 'Office Department'),
(250, 'Grace Mativo P.', '2019-01-20 05:57:12', '2019-01-20 05:59:46', 'Department', 'Office Department'),
(251, 'Grace Mativo P.', '2019-01-20 06:01:50', '2019-01-20 06:02:36', 'Department', 'Office Department'),
(252, 'Grace Mativo P.', '2019-01-20 06:03:23', '2019-01-20 06:04:19', 'Department', 'Office Department'),
(253, 'Grace Mativo P.', '2019-01-20 06:07:15', '2019-01-20 06:08:17', 'Department', 'Office Department'),
(254, 'Grace Mativo P.', '2019-01-20 06:10:20', '2019-01-20 06:11:55', 'Department', 'Office Department'),
(255, 'Grace Mativo P.', '2019-01-20 06:15:49', '2019-01-20 06:16:38', 'Department', 'Office Department'),
(256, 'Grace Mativo P.', '2019-01-20 06:17:35', '2019-01-20 06:18:29', 'Department', 'Office Department'),
(257, 'Grace Mativo P.', '2019-01-20 06:28:34', '2019-01-20 06:29:18', 'Department', 'Office Department'),
(258, 'Grace Mativo P.', '2019-01-20 06:30:21', '2019-01-20 06:30:55', 'Department', 'Office Department'),
(259, 'Grace Mativo P.', '2019-01-20 06:50:43', '2019-01-20 06:51:26', 'Department', 'Office Department'),
(260, 'Grace Mativo P.', '2019-01-20 08:39:25', '2019-01-20 08:39:39', 'Department', 'Office Department'),
(261, 'Grace Mativo P.', '2019-01-20 12:00:51', '2019-01-20 12:02:02', 'Department', 'Office Department'),
(262, 'Grace Mativo P.', '2019-01-20 12:04:33', '2019-01-20 12:04:56', 'Department', 'Office Department'),
(263, 'Grace Mativo P.', '2019-01-22 02:35:58', NULL, 'Department', 'Office Department'),
(264, 'Grace Mativo P.', '2019-01-22 02:39:40', NULL, 'Department', 'Office Department'),
(265, 'Grace Mativo P.', '2019-01-22 02:40:48', NULL, 'Department', 'Office Department'),
(266, 'Grace Mativo P.', '2019-01-22 02:43:43', NULL, 'Department', 'Office Department'),
(267, 'Grace Mativo P.', '2019-01-22 02:45:12', '2019-01-22 02:45:22', 'Department', 'Office Department'),
(268, 'Mae Lopez D.', '2019-01-22 02:45:36', '2019-01-22 02:46:16', 'Department', 'Warehouse Factory'),
(269, 'Grace Mativo P.', '2019-01-22 02:51:49', NULL, 'Department', 'Office Department'),
(270, 'Grace Mativo P.', '2019-01-22 02:52:01', '2019-01-22 02:52:34', 'Department', 'Office Department'),
(271, 'Grace Mativo P.', '2019-01-22 02:58:16', NULL, 'Department', 'Office Department'),
(272, 'Grace Mativo P.', '2019-01-22 02:59:38', '2019-01-22 03:00:03', 'Department', 'Office Department'),
(273, 'Grace Mativo P.', '2019-01-22 03:00:56', NULL, 'Department', 'Office Department'),
(274, 'Grace Mativo P.', '2019-01-22 03:08:25', '2019-01-22 03:08:49', 'Department', 'Office Department'),
(275, 'Grace Mativo P.', '2019-01-22 03:27:07', '2019-01-22 04:35:54', 'Department', 'Office Department'),
(276, 'Grace Mativo P.', '2019-01-22 08:06:32', '2019-01-22 08:14:57', 'Department', 'Office Department'),
(277, 'Grace Mativo P.', '2019-01-22 08:30:22', '2019-01-22 08:31:10', 'Department', 'Office Department'),
(278, 'Grace Mativo P.', '2019-01-22 08:31:14', '2019-01-22 08:31:37', 'Department', 'Office Department'),
(279, 'Grace Mativo P.', '2019-01-22 08:33:56', '2019-01-22 08:34:09', 'Department', 'Office Department'),
(280, 'Grace Mativo P.', '2019-01-22 08:35:28', NULL, 'Department', 'Office Department'),
(281, 'Grace Mativo P.', '2019-01-22 09:02:25', NULL, 'Department', 'Office Department'),
(282, 'Grace Mativo P.', '2019-01-22 09:02:38', '2019-01-22 09:02:50', 'Department', 'Office Department'),
(283, 'Grace Mativo P.', '2019-01-22 09:03:31', NULL, 'Department', 'Office Department'),
(284, 'Grace Mativo P.', '2019-01-22 09:03:56', NULL, 'Department', 'Office Department'),
(285, 'Grace Mativo P.', '2019-01-22 09:04:05', '2019-01-22 09:04:09', 'Department', 'Office Department'),
(286, 'Grace Mativo P.', '2019-01-22 09:05:15', '2019-01-22 09:05:58', 'Department', 'Office Department'),
(287, 'Grace Mativo P.', '2019-01-22 09:06:50', NULL, 'Department', 'Office Department'),
(288, 'Grace Mativo P.', '2019-01-22 09:07:02', NULL, 'Department', 'Office Department'),
(289, 'Grace Mativo P.', '2019-01-22 09:07:26', '2019-01-22 09:08:30', 'Department', 'Office Department'),
(290, 'Grace Mativo P.', '2019-01-22 09:09:08', NULL, 'Department', 'Office Department'),
(291, 'Grace Mativo P.', '2019-01-22 09:10:02', '2019-01-22 09:10:14', 'Department', 'Office Department'),
(292, 'Grace Mativo P.', '2019-01-22 09:10:38', NULL, 'Department', 'Office Department'),
(293, 'Grace Mativo P.', '2019-01-22 09:11:46', NULL, 'Department', 'Office Department'),
(294, 'Grace Mativo P.', '2019-01-22 09:12:28', '2019-01-22 09:12:57', 'Department', 'Office Department'),
(295, 'Grace Mativo P.', '2019-01-22 09:22:54', NULL, 'Department', 'Office Department'),
(296, 'Grace Mativo P.', '2019-01-22 10:16:02', '2019-01-22 10:16:27', 'Department', 'Office Department'),
(297, 'Grace Mativo P.', '2019-01-22 10:18:31', '2019-01-22 10:19:38', 'Department', 'Office Department'),
(298, 'Grace Mativo P.', '2019-01-22 10:20:44', '2019-01-22 10:23:22', 'Department', 'Office Department'),
(299, 'Grace Mativo P.', '2019-01-22 10:32:21', '2019-01-22 10:32:35', 'Department', 'Office Department'),
(300, 'Grace Mativo P.', '2019-01-22 10:33:27', '2019-01-22 10:33:41', 'Department', 'Office Department'),
(301, 'Grace Mativo P.', '2019-01-22 10:53:08', '2019-01-22 10:53:52', 'Department', 'Office Department'),
(302, 'Grace Mativo P.', '2019-01-22 10:54:06', '2019-01-22 10:58:16', 'Department', 'Office Department'),
(303, 'Grace Mativo P.', '2019-01-22 11:02:43', '2019-01-22 11:04:16', 'Department', 'Office Department'),
(304, 'Grace Mativo P.', '2019-01-22 11:04:44', '2019-01-22 11:06:22', 'Department', 'Office Department'),
(305, 'Grace Mativo P.', '2019-01-22 11:06:56', '2019-01-22 11:10:40', 'Department', 'Office Department'),
(306, 'Grace Mativo P.', '2019-01-22 11:38:51', '2019-01-22 11:42:24', 'Department', 'Office Department'),
(307, 'Grace Mativo P.', '2019-01-22 11:46:01', '2019-01-22 11:46:58', 'Department', 'Office Department'),
(308, 'Grace Mativo P.', '2019-01-22 11:48:32', '2019-01-22 11:53:36', 'Department', 'Office Department'),
(309, 'Grace Mativo P.', '2019-01-22 11:54:08', '2019-01-22 11:56:09', 'Department', 'Office Department'),
(310, 'Grace Mativo P.', '2019-01-22 15:45:21', '2019-01-22 16:07:38', 'Department', 'Office Department'),
(311, 'Mae Lopez D.', '2019-01-22 16:07:56', '2019-01-22 16:09:25', 'Department', 'Warehouse Factory'),
(312, 'Grace Mativo P.', '2019-01-22 16:21:08', '2019-01-22 16:21:35', 'Department', 'Office Department'),
(313, 'Grace Mativo P.', '2019-01-22 18:15:38', '2019-01-22 18:16:47', 'Department', 'Office Department'),
(314, 'Grace Mativo P.', '2019-01-22 18:28:20', '2019-01-22 18:29:21', 'Department', 'Office Department'),
(315, 'Grace Mativo P.', '2019-01-22 18:33:45', '2019-01-22 23:35:02', 'Department', 'Office Department'),
(316, 'Grace Mativo P.', '2019-01-22 23:39:57', '2019-01-22 23:44:32', 'Department', 'Office Department'),
(317, 'Grace Mativo P.', '2019-01-22 23:45:11', '2019-01-22 23:49:15', 'Department', 'Office Department'),
(318, 'Grace Mativo P.', '2019-01-22 23:51:04', '2019-01-22 23:51:26', 'Department', 'Office Department'),
(319, 'Grace Mativo P.', '2019-01-22 23:52:24', '2019-01-22 23:55:40', 'Department', 'Office Department'),
(320, 'Grace Mativo P.', '2019-01-22 23:56:56', NULL, 'Department', 'Office Department'),
(321, 'Grace Mativo P.', '2019-01-22 23:58:30', NULL, 'Department', 'Office Department'),
(322, 'Grace Mativo P.', '2019-01-22 23:59:20', NULL, 'Department', 'Office Department'),
(323, 'Grace Mativo P.', '2019-01-22 23:59:50', '2019-01-23 00:06:13', 'Department', 'Office Department'),
(324, 'Grace Mativo P.', '2019-01-23 00:22:07', '2019-01-23 00:22:42', 'Department', 'Office Department'),
(325, 'Grace Mativo P.', '2019-01-23 00:26:54', '2019-01-23 00:28:47', 'Department', 'Office Department'),
(326, 'Grace Mativo P.', '2019-01-23 00:30:30', '2019-01-23 00:30:50', 'Department', 'Office Department'),
(327, 'Grace Mativo P.', '2019-01-23 00:32:18', '2019-01-23 00:32:44', 'Department', 'Office Department'),
(328, 'Grace Mativo P.', '2019-01-23 00:35:21', '2019-01-23 00:36:01', 'Department', 'Office Department'),
(329, 'Grace Mativo P.', '2019-01-23 00:38:08', NULL, 'Department', 'Office Department'),
(330, 'Grace Mativo P.', '2019-01-23 00:43:28', '2019-01-23 00:43:50', 'Department', 'Office Department'),
(331, 'Grace Mativo P.', '2019-01-23 00:45:45', '2019-01-23 00:46:03', 'Department', 'Office Department'),
(332, 'Grace Mativo P.', '2019-01-23 00:46:44', '2019-01-23 00:47:00', 'Department', 'Office Department'),
(333, 'Grace Mativo P.', '2019-01-23 00:48:42', NULL, 'Department', 'Office Department'),
(334, 'Grace Mativo P.', '2019-01-23 01:03:11', '2019-01-23 01:03:40', 'Department', 'Office Department'),
(335, 'Grace Mativo P.', '2019-01-23 01:05:03', '2019-01-23 01:07:15', 'Department', 'Office Department'),
(336, 'Grace Mativo P.', '2019-01-23 01:08:40', NULL, 'Department', 'Office Department'),
(337, 'Grace Mativo P.', '2019-01-23 01:16:41', '2019-01-23 01:17:10', 'Department', 'Office Department'),
(338, 'Grace Mativo P.', '2019-01-23 01:19:30', '2019-01-23 01:19:59', 'Department', 'Office Department'),
(339, 'Grace Mativo P.', '2019-01-23 01:23:50', '2019-01-23 01:24:03', 'Department', 'Office Department'),
(340, 'Grace Mativo P.', '2019-01-23 01:24:56', '2019-01-23 01:25:10', 'Department', 'Office Department'),
(341, 'Grace Mativo P.', '2019-01-23 01:27:15', '2019-01-23 01:59:05', 'Department', 'Office Department'),
(342, 'Grace Mativo P.', '2019-01-23 02:01:07', '2019-01-23 02:01:44', 'Department', 'Office Department'),
(343, 'Grace Mativo P.', '2019-01-23 02:06:28', '2019-01-23 02:07:35', 'Department', 'Office Department'),
(344, 'Grace Mativo P.', '2019-01-23 02:08:26', '2019-01-23 02:08:53', 'Department', 'Office Department'),
(345, 'Grace Mativo P.', '2019-01-23 02:17:44', '2019-01-23 02:18:18', 'Department', 'Office Department'),
(346, 'Grace Mativo P.', '2019-01-23 02:25:50', '2019-01-23 02:29:54', 'Department', 'Office Department'),
(347, 'Grace Mativo P.', '2019-01-23 04:19:10', '2019-01-23 04:28:39', 'Department', 'Office Department'),
(348, 'Grace Mativo P.', '2019-01-23 05:02:40', '2019-01-23 05:07:07', 'Department', 'Office Department'),
(349, 'Grace Mativo P.', '2019-01-23 06:28:32', '2019-01-23 06:29:25', 'Department', 'Office Department'),
(350, 'Grace Mativo P.', '2019-01-23 06:36:03', '2019-01-23 06:36:47', 'Department', 'Office Department'),
(351, 'Grace Mativo P.', '2019-01-23 11:28:30', '2019-01-23 11:28:48', 'Department', 'Office Department'),
(352, 'Grace Mativo P.', '2019-01-23 11:34:30', '2019-01-23 11:34:49', 'Department', 'Office Department'),
(353, 'Grace Mativo P.', '2019-01-23 11:35:38', '2019-01-23 11:36:01', 'Department', 'Office Department'),
(354, 'Grace Mativo P.', '2019-01-23 11:37:20', NULL, 'Department', 'Office Department'),
(355, 'Grace Mativo P.', '2019-01-23 11:39:41', '2019-01-23 11:39:58', 'Department', 'Office Department'),
(356, 'Grace Mativo P.', '2019-01-23 11:59:34', '2019-01-23 11:59:54', 'Department', 'Office Department'),
(357, 'Grace Mativo P.', '2019-01-23 12:07:41', '2019-01-23 12:08:41', 'Department', 'Office Department'),
(358, 'Grace Mativo P.', '2019-01-23 12:11:52', '2019-01-23 12:13:17', 'Department', 'Office Department'),
(359, 'Grace Mativo P.', '2019-01-23 12:16:14', '2019-01-23 12:17:27', 'Department', 'Office Department'),
(360, 'Grace Mativo P.', '2019-01-23 12:22:26', '2019-01-23 12:25:31', 'Department', 'Office Department'),
(361, 'Grace Mativo P.', '2019-01-23 12:26:13', '2019-01-23 12:27:11', 'Department', 'Office Department'),
(362, 'Grace Mativo P.', '2019-01-23 12:34:30', '2019-01-23 12:34:50', 'Department', 'Office Department'),
(363, 'Grace Mativo P.', '2019-01-23 12:40:44', '2019-01-23 12:47:29', 'Department', 'Office Department'),
(364, 'Grace Mativo P.', '2019-01-23 13:38:16', '2019-01-23 13:39:58', 'Department', 'Office Department'),
(365, 'Grace Mativo P.', '2019-01-23 13:41:43', '2019-01-23 13:42:37', 'Department', 'Office Department'),
(366, 'Grace Mativo P.', '2019-01-23 13:46:41', '2019-01-23 13:47:06', 'Department', 'Office Department'),
(367, 'Grace Mativo P.', '2019-01-23 13:56:29', '2019-01-23 14:00:08', 'Department', 'Office Department'),
(368, 'Grace Mativo P.', '2019-01-23 14:02:56', '2019-01-23 14:03:17', 'Department', 'Office Department'),
(369, 'Grace Mativo P.', '2019-01-23 14:07:59', '2019-01-23 14:10:10', 'Department', 'Office Department'),
(370, 'Grace Mativo P.', '2019-01-23 14:11:13', '2019-01-23 14:11:44', 'Department', 'Office Department'),
(371, 'Grace Mativo P.', '2019-01-23 14:14:55', '2019-01-23 14:18:16', 'Department', 'Office Department'),
(372, 'Grace Mativo P.', '2019-01-23 14:18:20', '2019-01-23 14:19:07', 'Department', 'Office Department'),
(373, 'Grace Mativo P.', '2019-01-23 14:20:48', '2019-01-23 14:21:38', 'Department', 'Office Department'),
(374, 'Grace Mativo P.', '2019-01-23 14:26:35', NULL, 'Department', 'Office Department'),
(375, 'Grace Mativo P.', '2019-01-23 14:28:29', NULL, 'Department', 'Office Department'),
(376, 'Grace Mativo P.', '2019-01-23 14:33:29', '2019-01-23 14:34:25', 'Department', 'Office Department'),
(377, 'Grace Mativo P.', '2019-01-23 14:35:06', '2019-01-23 14:36:07', 'Department', 'Office Department'),
(378, 'Grace Mativo P.', '2019-01-23 14:37:53', '2019-01-23 14:39:03', 'Department', 'Office Department'),
(379, 'Grace Mativo P.', '2019-01-23 14:39:22', NULL, 'Department', 'Office Department'),
(380, 'Grace Mativo P.', '2019-01-23 14:42:28', NULL, 'Department', 'Office Department'),
(381, 'Grace Mativo P.', '2019-01-23 14:42:36', '2019-01-23 14:43:02', 'Department', 'Office Department'),
(382, 'Grace Mativo P.', '2019-01-23 14:44:49', NULL, 'Department', 'Office Department'),
(383, 'Grace Mativo P.', '2019-01-23 14:46:40', '2019-01-23 14:47:43', 'Department', 'Office Department'),
(384, 'Grace Mativo P.', '2019-01-23 14:53:30', '2019-01-23 14:53:48', 'Department', 'Office Department'),
(385, 'Grace Mativo P.', '2019-01-23 14:59:11', '2019-01-23 15:01:25', 'Department', 'Office Department'),
(386, 'Grace Mativo P.', '2019-01-23 15:12:57', '2019-01-23 15:14:02', 'Department', 'Office Department'),
(387, 'Grace Mativo P.', '2019-01-23 15:15:01', '2019-01-23 15:16:08', 'Department', 'Office Department'),
(388, 'Grace Mativo P.', '2019-01-23 15:17:22', '2019-01-23 15:18:42', 'Department', 'Office Department'),
(389, 'Grace Mativo P.', '2019-01-23 15:22:13', '2019-01-23 15:23:01', 'Department', 'Office Department'),
(390, 'Grace Mativo P.', '2019-01-23 15:26:07', '2019-01-23 15:39:52', 'Department', 'Office Department'),
(391, 'Grace Mativo P.', '2019-01-23 16:51:31', '2019-01-23 16:52:48', 'Department', 'Office Department'),
(392, 'Grace Mativo P.', '2019-01-23 16:53:33', '2019-01-23 16:54:13', 'Department', 'Office Department'),
(393, 'Grace Mativo P.', '2019-01-23 16:54:33', '2019-01-23 16:57:23', 'Department', 'Office Department'),
(394, 'Grace Mativo P.', '2019-01-23 16:58:46', NULL, 'Department', 'Office Department'),
(395, 'Grace Mativo P.', '2019-01-23 17:01:27', NULL, 'Department', 'Office Department'),
(396, 'Grace Mativo P.', '2019-01-23 17:02:39', '2019-01-23 17:03:23', 'Department', 'Office Department'),
(397, 'Grace Mativo P.', '2019-01-23 17:04:13', NULL, 'Department', 'Office Department'),
(398, 'Grace Mativo P.', '2019-01-23 17:04:39', NULL, 'Department', 'Office Department'),
(399, 'Grace Mativo P.', '2019-01-23 17:11:09', NULL, 'Department', 'Office Department'),
(400, 'Grace Mativo P.', '2019-01-23 17:33:11', NULL, 'Department', 'Office Department'),
(401, 'Grace Mativo P.', '2019-01-23 17:39:42', '2019-01-23 17:41:32', 'Department', 'Office Department'),
(402, 'Grace Mativo P.', '2019-01-24 08:43:00', '2019-01-24 08:43:26', 'Department', 'Office Department'),
(403, 'Grace Mativo P.', '2019-01-24 08:44:27', '2019-01-24 08:52:40', 'Department', 'Office Department'),
(404, 'Grace Mativo P.', '2019-01-24 13:24:02', '2019-01-24 22:18:40', 'Department', 'Office Department'),
(405, 'Grace Mativo P.', '2019-01-24 22:20:47', '2019-01-24 22:21:45', 'Department', 'Office Department'),
(406, 'Grace Mativo P.', '2019-01-24 22:21:50', '2019-01-24 22:23:44', 'Department', 'Office Department'),
(407, 'Grace Mativo P.', '2019-01-24 22:41:42', '2019-01-24 22:42:03', 'Department', 'Office Department'),
(408, 'Grace Mativo P.', '2019-01-24 23:15:35', '2019-01-24 23:15:44', 'Department', 'Office Department'),
(409, 'Grace Mativo P.', '2019-01-24 23:19:27', '2019-01-24 23:19:50', 'Department', 'Office Department'),
(410, 'Grace Mativo P.', '2019-01-24 23:20:29', '2019-01-24 23:20:54', 'Department', 'Office Department'),
(411, 'Grace Mativo P.', '2019-01-24 23:23:21', '2019-01-24 23:33:15', 'Department', 'Office Department'),
(412, 'Grace Mativo P.', '2019-01-24 23:38:07', '2019-01-24 23:40:31', 'Department', 'Office Department'),
(413, 'Grace Mativo P.', '2019-01-24 23:50:30', '2019-01-24 23:50:50', 'Department', 'Office Department'),
(414, 'Grace Mativo P.', '2019-01-24 23:51:55', '2019-01-24 23:52:14', 'Department', 'Office Department'),
(415, 'Grace Mativo P.', '2019-01-24 23:52:55', '2019-01-24 23:53:28', 'Department', 'Office Department'),
(416, 'Grace Mativo P.', '2019-01-24 23:55:00', '2019-01-24 23:55:25', 'Department', 'Office Department'),
(417, 'Grace Mativo P.', '2019-01-25 00:00:31', '2019-01-25 00:01:54', 'Department', 'Office Department'),
(418, 'Grace Mativo P.', '2019-01-25 00:23:20', '2019-01-25 00:23:58', 'Department', 'Office Department'),
(419, 'Grace Mativo P.', '2019-01-25 01:06:58', '2019-01-25 01:07:09', 'Department', 'Office Department'),
(420, 'Grace Mativo P.', '2019-01-25 01:09:45', '2019-01-25 01:10:02', 'Department', 'Office Department'),
(421, 'Grace Mativo P.', '2019-01-25 01:17:17', '2019-01-25 01:17:43', 'Department', 'Office Department'),
(422, 'Grace Mativo P.', '2019-01-25 01:18:23', '2019-01-25 01:18:40', 'Department', 'Office Department'),
(423, 'Grace Mativo P.', '2019-01-25 01:19:16', '2019-01-25 01:19:32', 'Department', 'Office Department'),
(424, 'Grace Mativo P.', '2019-01-25 01:20:35', '2019-01-25 01:21:16', 'Department', 'Office Department'),
(425, 'Grace Mativo P.', '2019-01-25 01:22:12', '2019-01-25 01:22:38', 'Department', 'Office Department'),
(426, 'Grace Mativo P.', '2019-01-25 01:24:03', '2019-01-25 01:24:17', 'Department', 'Office Department'),
(427, 'Grace Mativo P.', '2019-01-25 01:24:51', '2019-01-25 01:25:00', 'Department', 'Office Department'),
(428, 'Grace Mativo P.', '2019-01-25 01:27:57', '2019-01-25 01:28:15', 'Department', 'Office Department'),
(429, 'Grace Mativo P.', '2019-01-25 01:33:10', '2019-01-25 01:33:40', 'Department', 'Office Department'),
(430, 'Grace Mativo P.', '2019-01-25 01:37:55', NULL, 'Department', 'Office Department'),
(431, 'Grace Mativo P.', '2019-01-25 01:39:36', NULL, 'Department', 'Office Department'),
(432, 'Grace Mativo P.', '2019-01-25 02:02:15', '2019-01-25 02:02:56', 'Department', 'Office Department'),
(433, 'Grace Mativo P.', '2019-01-25 02:03:58', NULL, 'Department', 'Office Department'),
(434, 'Grace Mativo P.', '2019-01-25 02:05:30', NULL, 'Department', 'Office Department'),
(435, 'Grace Mativo P.', '2019-01-25 02:08:32', NULL, 'Department', 'Office Department'),
(436, 'Grace Mativo P.', '2019-01-25 02:12:47', NULL, 'Department', 'Office Department'),
(437, 'Grace Mativo P.', '2019-01-25 02:18:02', NULL, 'Department', 'Office Department'),
(438, 'Grace Mativo P.', '2019-01-25 02:25:09', '2019-01-25 02:26:54', 'Department', 'Office Department'),
(439, 'Grace Mativo P.', '2019-01-25 02:32:09', NULL, 'Department', 'Office Department'),
(440, 'Grace Mativo P.', '2019-01-25 02:37:00', NULL, 'Department', 'Office Department'),
(441, 'Grace Mativo P.', '2019-01-25 02:42:49', NULL, 'Department', 'Office Department'),
(442, 'Grace Mativo P.', '2019-01-25 02:44:22', NULL, 'Department', 'Office Department'),
(443, 'Grace Mativo P.', '2019-01-25 02:46:20', NULL, 'Department', 'Office Department'),
(444, 'Grace Mativo P.', '2019-01-25 02:50:40', '2019-01-25 02:51:41', 'Department', 'Office Department'),
(445, 'Grace Mativo P.', '2019-01-25 17:39:24', '2019-01-25 17:44:10', 'Department', 'Office Department'),
(446, 'Grace Mativo P.', '2019-01-25 17:46:48', NULL, 'Department', 'Office Department'),
(447, 'Grace Mativo P.', '2019-01-25 18:08:57', NULL, 'Department', 'Office Department'),
(448, 'Grace Mativo P.', '2019-01-25 22:02:00', NULL, 'Department', 'Office Department'),
(449, 'Grace Mativo P.', '2019-01-25 23:06:37', NULL, 'Department', 'Office Department'),
(450, 'Grace Mativo P.', '2019-01-25 23:17:12', NULL, 'Department', 'Office Department'),
(451, 'Grace Mativo P.', '2019-01-25 23:28:46', NULL, 'Department', 'Office Department'),
(452, 'Grace Mativo P.', '2019-01-25 23:35:51', '2019-01-25 23:36:59', 'Department', 'Office Department'),
(453, 'Grace Mativo P.', '2019-01-25 23:37:32', NULL, 'Department', 'Office Department'),
(454, 'Grace Mativo P.', '2019-01-25 23:38:25', '2019-01-25 23:39:36', 'Department', 'Office Department'),
(455, 'Grace Mativo P.', '2019-01-25 23:48:21', '2019-01-25 23:55:21', 'Department', 'Office Department'),
(456, 'Grace Mativo P.', '2019-01-26 00:22:55', '2019-01-26 00:26:19', 'Department', 'Office Department'),
(457, 'Grace Mativo P.', '2019-01-26 00:26:52', '2019-01-26 00:27:07', 'Department', 'Office Department'),
(458, 'Grace Mativo P.', '2019-01-26 00:36:21', NULL, 'Department', 'Office Department'),
(459, 'Grace Mativo P.', '2019-01-26 00:37:38', NULL, 'Department', 'Office Department'),
(460, 'Grace Mativo P.', '2019-01-26 00:47:45', NULL, 'Department', 'Office Department'),
(461, 'Grace Mativo P.', '2019-01-26 00:49:01', '2019-01-26 00:50:31', 'Department', 'Office Department'),
(462, 'Grace Mativo P.', '2019-01-26 00:52:58', NULL, 'Department', 'Office Department'),
(463, 'Grace Mativo P.', '2019-01-26 00:55:10', '2019-01-26 00:55:35', 'Department', 'Office Department'),
(464, 'Grace Mativo P.', '2019-01-26 00:59:19', NULL, 'Department', 'Office Department'),
(465, 'Grace Mativo P.', '2019-01-26 01:00:06', NULL, 'Department', 'Office Department'),
(466, 'Grace Mativo P.', '2019-01-26 01:02:25', NULL, 'Department', 'Office Department'),
(467, 'Grace Mativo P.', '2019-01-26 01:03:50', '2019-01-26 01:07:43', 'Department', 'Office Department'),
(468, 'Grace Mativo P.', '2019-01-26 01:09:47', NULL, 'Department', 'Office Department'),
(469, 'Grace Mativo P.', '2019-01-26 01:16:28', NULL, 'Department', 'Office Department'),
(470, 'Grace Mativo P.', '2019-01-26 02:59:06', NULL, 'Department', 'Office Department'),
(471, 'Grace Mativo P.', '2019-01-26 03:06:19', '2019-01-26 06:05:43', 'Department', 'Office Department'),
(472, 'Grace Mativo P.', '2019-01-26 08:46:05', NULL, 'Department', 'Office Department'),
(473, 'Grace Mativo P.', '2019-01-26 09:00:00', NULL, 'Department', 'Office Department'),
(474, 'Grace Mativo P.', '2019-01-26 09:01:28', NULL, 'Department', 'Office Department'),
(475, 'Grace Mativo P.', '2019-01-26 09:19:24', '2019-01-26 09:25:06', 'Department', 'Office Department'),
(476, 'Grace Mativo P.', '2019-01-26 09:27:56', '2019-01-26 09:31:12', 'Department', 'Office Department'),
(477, 'Grace Mativo P.', '2019-01-26 09:33:26', '2019-01-26 09:34:20', 'Department', 'Office Department'),
(478, 'Grace Mativo P.', '2019-01-26 09:40:24', '2019-01-26 09:40:54', 'Department', 'Office Department'),
(479, 'Grace Mativo P.', '2019-01-26 09:42:16', '2019-01-26 09:42:40', 'Department', 'Office Department'),
(480, 'Grace Mativo P.', '2019-01-26 17:02:31', '2019-01-26 17:03:09', 'Department', 'Office Department'),
(481, 'Grace Mativo P.', '2019-01-26 17:04:24', '2019-01-26 17:04:32', 'Department', 'Office Department'),
(482, 'Grace Mativo P.', '2019-01-26 17:05:24', '2019-01-26 17:05:32', 'Department', 'Office Department'),
(483, 'Grace Mativo P.', '2019-01-26 17:06:35', '2019-01-26 17:07:38', 'Department', 'Office Department'),
(484, 'Grace Mativo P.', '2019-01-26 17:09:09', '2019-01-26 17:09:25', 'Department', 'Office Department'),
(485, 'Grace Mativo P.', '2019-01-26 17:19:16', '2019-01-26 17:23:30', 'Department', 'Office Department'),
(486, 'Grace Mativo P.', '2019-01-26 17:38:57', '2019-01-26 17:39:51', 'Department', 'Office Department'),
(487, 'Grace Mativo P.', '2019-01-26 17:40:30', '2019-01-26 17:41:17', 'Department', 'Office Department'),
(488, 'Grace Mativo P.', '2019-01-26 17:41:36', NULL, 'Department', 'Office Department'),
(489, 'Grace Mativo P.', '2019-01-26 17:42:24', '2019-01-26 17:42:47', 'Department', 'Office Department'),
(490, 'Grace Mativo P.', '2019-01-26 17:43:52', '2019-01-26 17:44:29', 'Department', 'Office Department'),
(491, 'Grace Mativo P.', '2019-01-26 17:46:01', '2019-01-26 17:46:25', 'Department', 'Office Department'),
(492, 'Grace Mativo P.', '2019-01-26 17:48:12', NULL, 'Department', 'Office Department'),
(493, 'Grace Mativo P.', '2019-01-26 17:53:51', '2019-01-26 17:54:22', 'Department', 'Office Department'),
(494, 'Grace Mativo P.', '2019-01-26 18:07:54', '2019-01-26 18:07:59', 'Department', 'Office Department'),
(495, 'Grace Mativo P.', '2019-01-26 18:18:04', '2019-01-26 18:18:25', 'Department', 'Office Department'),
(496, 'Grace Mativo P.', '2019-01-26 18:22:37', '2019-01-26 18:22:57', 'Department', 'Office Department'),
(497, 'Grace Mativo P.', '2019-01-26 18:26:19', '2019-01-27 15:15:34', 'Department', 'Office Department'),
(498, 'Grace Mativo P.', '2019-01-27 15:16:00', '2019-01-27 15:20:59', 'Department', 'Office Department'),
(499, 'Grace Mativo P.', '2019-01-27 16:47:53', '2019-01-27 17:23:35', 'Department', 'Office Department'),
(500, 'Grace Mativo P.', '2019-01-27 17:31:01', '2019-01-27 17:38:37', 'Department', 'Office Department'),
(501, 'Grace Mativo P.', '2019-01-27 17:41:45', '2019-01-27 17:43:05', 'Department', 'Office Department'),
(502, 'Grace Mativo P.', '2019-01-27 17:43:43', '2019-01-27 17:43:54', 'Department', 'Office Department');
INSERT INTO `tlb_loghis` (`loghisID`, `UserName`, `logIn`, `logout`, `designation`, `department`) VALUES
(503, 'Grace Mativo P.', '2019-01-27 18:08:34', NULL, 'Department', 'Office Department'),
(504, 'Grace Mativo P.', '2019-01-27 18:10:00', NULL, 'Department', 'Office Department'),
(505, 'Grace Mativo P.', '2019-01-27 18:11:31', '2019-01-27 18:12:05', 'Department', 'Office Department'),
(506, 'Grace Mativo P.', '2019-01-27 18:12:36', NULL, 'Department', 'Office Department'),
(507, 'Grace Mativo P.', '2019-01-27 18:14:11', NULL, 'Department', 'Office Department'),
(508, 'Grace Mativo P.', '2019-01-27 18:18:29', '2019-01-27 18:19:00', 'Department', 'Office Department'),
(509, 'Grace Mativo P.', '2019-01-27 18:19:18', '2019-01-27 18:19:46', 'Department', 'Office Department'),
(510, 'Grace Mativo P.', '2019-01-27 18:21:57', '2019-01-27 18:25:08', 'Department', 'Office Department'),
(511, 'Grace Mativo P.', '2019-01-27 18:25:36', NULL, 'Department', 'Office Department'),
(512, 'Grace Mativo P.', '2019-01-27 18:26:14', NULL, 'Department', 'Office Department'),
(513, 'Grace Mativo P.', '2019-01-27 18:27:02', NULL, 'Department', 'Office Department'),
(514, 'Grace Mativo P.', '2019-01-27 18:27:47', NULL, 'Department', 'Office Department'),
(515, 'Grace Mativo P.', '2019-01-27 18:28:48', '2019-01-27 18:29:30', 'Department', 'Office Department'),
(516, 'Grace Mativo P.', '2019-01-27 18:46:32', NULL, 'Department', 'Office Department'),
(517, 'Grace Mativo P.', '2019-01-27 18:47:34', NULL, 'Department', 'Office Department'),
(518, 'Grace Mativo P.', '2019-01-27 18:48:06', NULL, 'Department', 'Office Department'),
(519, 'Grace Mativo P.', '2019-01-27 18:48:57', NULL, 'Department', 'Office Department'),
(520, 'Grace Mativo P.', '2019-01-27 18:51:13', NULL, 'Department', 'Office Department'),
(521, 'Grace Mativo P.', '2019-01-27 18:53:07', NULL, 'Department', 'Office Department'),
(522, 'Grace Mativo P.', '2019-01-27 18:54:03', NULL, 'Department', 'Office Department'),
(523, 'Grace Mativo P.', '2019-01-27 18:56:33', '2019-01-27 18:57:14', 'Department', 'Office Department'),
(524, 'Grace Mativo P.', '2019-01-27 18:57:48', '2019-01-27 18:58:20', 'Department', 'Office Department'),
(525, 'Grace Mativo P.', '2019-01-27 19:04:12', '2019-01-27 19:05:38', 'Department', 'Office Department'),
(526, 'Grace Mativo P.', '2019-01-27 19:06:13', '2019-01-27 19:07:18', 'Department', 'Office Department'),
(527, 'Grace Mativo P.', '2019-01-27 19:07:44', NULL, 'Department', 'Office Department'),
(528, 'Grace Mativo P.', '2019-01-27 19:12:00', NULL, 'Department', 'Office Department'),
(529, 'Grace Mativo P.', '2019-01-27 19:13:27', NULL, 'Department', 'Office Department'),
(530, 'Grace Mativo P.', '2019-01-27 19:20:45', '2019-01-27 19:22:27', 'Department', 'Office Department'),
(531, 'Grace Mativo P.', '2019-01-27 19:23:34', NULL, 'Department', 'Office Department'),
(532, 'Grace Mativo P.', '2019-01-27 19:35:11', NULL, 'Department', 'Office Department'),
(533, 'Grace Mativo P.', '2019-01-27 19:36:20', NULL, 'Department', 'Office Department'),
(534, 'Grace Mativo P.', '2019-01-27 19:41:21', NULL, 'Department', 'Office Department'),
(535, 'Grace Mativo P.', '2019-01-27 19:43:32', '2019-01-27 19:44:28', 'Department', 'Office Department'),
(536, 'Grace Mativo P.', '2019-01-27 19:45:12', '2019-01-27 19:45:43', 'Department', 'Office Department'),
(537, 'Grace Mativo P.', '2019-01-27 19:47:21', '2019-01-27 19:47:57', 'Department', 'Office Department'),
(538, 'Grace Mativo P.', '2019-01-27 19:56:40', '2019-01-27 19:57:34', 'Department', 'Office Department'),
(539, 'Grace Mativo P.', '2019-01-27 20:03:17', NULL, 'Department', 'Office Department'),
(540, 'Grace Mativo P.', '2019-01-27 20:04:23', '2019-01-27 20:04:58', 'Department', 'Office Department'),
(541, 'Grace Mativo P.', '2019-01-27 20:05:34', NULL, 'Department', 'Office Department'),
(542, 'Grace Mativo P.', '2019-01-27 20:06:21', NULL, 'Department', 'Office Department'),
(543, 'Grace Mativo P.', '2019-01-27 20:10:58', NULL, 'Department', 'Office Department'),
(544, 'Grace Mativo P.', '2019-01-27 20:28:46', '2019-01-27 20:29:24', 'Department', 'Office Department'),
(545, 'Grace Mativo P.', '2019-01-27 20:51:14', '2019-01-27 20:51:50', 'Department', 'Office Department'),
(546, 'Grace Mativo P.', '2019-01-27 20:55:27', NULL, 'Department', 'Office Department'),
(547, 'Grace Mativo P.', '2019-01-27 20:56:37', '2019-01-27 20:59:00', 'Department', 'Office Department'),
(548, 'Grace Mativo P.', '2019-01-27 20:59:31', '2019-01-27 21:01:33', 'Department', 'Office Department'),
(549, 'Grace Mativo P.', '2019-01-27 21:02:30', NULL, 'Department', 'Office Department'),
(550, 'Grace Mativo P.', '2019-01-27 21:03:23', '2019-01-27 21:03:30', 'Department', 'Office Department'),
(551, 'Grace Mativo P.', '2019-01-27 21:05:33', '2019-01-27 21:06:21', 'Department', 'Office Department'),
(552, 'Grace Mativo P.', '2019-01-27 21:07:04', '2019-01-27 21:07:38', 'Department', 'Office Department'),
(553, 'Grace Mativo P.', '2019-01-27 21:11:41', '2019-01-27 21:11:59', 'Department', 'Office Department'),
(554, 'Grace Mativo P.', '2019-01-27 21:13:22', '2019-01-27 21:13:46', 'Department', 'Office Department'),
(555, 'Grace Mativo P.', '2019-01-27 21:14:26', NULL, 'Department', 'Office Department'),
(556, 'Grace Mativo P.', '2019-01-27 21:18:23', '2019-01-27 21:19:32', 'Department', 'Office Department'),
(557, 'Grace Mativo P.', '2019-01-27 21:24:56', '2019-01-27 21:25:42', 'Department', 'Office Department'),
(558, 'Grace Mativo P.', '2019-01-27 21:26:52', NULL, 'Department', 'Office Department'),
(559, 'Grace Mativo P.', '2019-01-27 21:29:30', '2019-01-27 21:30:03', 'Department', 'Office Department'),
(560, 'Grace Mativo P.', '2019-01-27 21:43:00', NULL, 'Department', 'Office Department'),
(561, 'Grace Mativo P.', '2019-01-27 22:35:43', '2019-01-27 22:36:40', 'Department', 'Office Department'),
(562, 'Grace Mativo P.', '2019-01-27 22:37:12', '2019-01-27 22:39:51', 'Department', 'Office Department'),
(563, 'Grace Mativo P.', '2019-01-27 22:46:12', NULL, 'Department', 'Office Department'),
(564, 'Grace Mativo P.', '2019-01-27 22:47:21', '2019-01-27 22:51:33', 'Department', 'Office Department'),
(565, 'Grace Mativo P.', '2019-01-27 22:52:17', '2019-01-27 22:52:53', 'Department', 'Office Department'),
(566, 'Grace Mativo P.', '2019-01-27 22:53:39', '2019-01-27 22:54:14', 'Department', 'Office Department'),
(567, 'Grace Mativo P.', '2019-01-27 23:02:07', '2019-01-27 23:03:36', 'Department', 'Office Department'),
(568, 'Grace Mativo P.', '2019-01-27 23:11:14', '2019-01-27 23:12:11', 'Department', 'Office Department'),
(569, 'Grace Mativo P.', '2019-01-27 23:16:33', '2019-01-27 23:17:07', 'Department', 'Office Department'),
(570, 'Grace Mativo P.', '2019-01-27 23:17:35', NULL, 'Department', 'Office Department'),
(571, 'Grace Mativo P.', '2019-01-27 23:18:35', '2019-01-27 23:26:47', 'Department', 'Office Department'),
(572, 'Grace Mativo P.', '2019-01-27 23:30:07', NULL, 'Department', 'Office Department'),
(573, 'Grace Mativo P.', '2019-01-27 23:38:21', '2019-01-27 23:40:20', 'Department', 'Office Department'),
(574, 'Grace Mativo P.', '2019-01-27 23:42:25', NULL, 'Department', 'Office Department'),
(575, 'Grace Mativo P.', '2019-01-27 23:44:57', NULL, 'Department', 'Office Department'),
(576, 'Grace Mativo P.', '2019-01-27 23:45:48', '2019-01-27 23:45:58', 'Department', 'Office Department'),
(577, 'Grace Mativo P.', '2019-01-29 01:16:16', '2019-01-29 01:16:46', 'Department', 'Office Department'),
(578, 'Grace Mativo P.', '2019-01-29 01:25:03', '2019-01-29 01:25:12', 'Department', 'Office Department'),
(579, 'Grace Mativo P.', '2019-01-29 01:29:49', NULL, 'Department', 'Office Department'),
(580, 'Grace Mativo P.', '2019-01-29 01:41:40', '2019-01-29 01:42:47', 'Department', 'Office Department'),
(581, 'Grace Mativo P.', '2019-01-29 01:51:47', '2019-01-29 01:52:05', 'Department', 'Office Department'),
(582, 'Grace Mativo P.', '2019-01-29 01:52:36', '2019-01-29 01:52:46', 'Department', 'Office Department'),
(583, 'Grace Mativo P.', '2019-01-29 01:53:53', '2019-01-29 01:54:24', 'Department', 'Office Department'),
(584, 'Grace Mativo P.', '2019-01-29 02:02:00', '2019-01-29 02:07:03', 'Department', 'Office Department'),
(585, 'Grace Mativo P.', '2019-01-29 02:08:20', NULL, 'Department', 'Office Department'),
(586, 'Grace Mativo P.', '2019-01-29 02:10:18', NULL, 'Department', 'Office Department'),
(587, 'Grace Mativo P.', '2019-01-29 02:21:20', '2019-01-29 02:23:26', 'Department', 'Office Department'),
(588, 'Grace Mativo P.', '2019-01-29 02:24:33', '2019-01-29 02:24:40', 'Department', 'Office Department'),
(589, 'Grace Mativo P.', '2019-01-29 02:25:29', '2019-01-29 02:25:41', 'Department', 'Office Department'),
(590, 'Grace Mativo P.', '2019-01-29 02:43:08', NULL, 'Department', 'Office Department'),
(591, 'Grace Mativo P.', '2019-01-29 02:43:44', '2019-01-29 02:43:57', 'Department', 'Office Department'),
(592, 'Grace Mativo P.', '2019-01-29 02:55:37', '2019-01-29 02:56:36', 'Department', 'Office Department'),
(593, 'Grace Mativo P.', '2019-01-29 03:13:20', '2019-01-29 03:21:11', 'Department', 'Office Department'),
(594, 'Grace Mativo P.', '2019-01-29 03:21:47', '2019-01-29 03:22:08', 'Department', 'Office Department'),
(595, 'Grace Mativo P.', '2019-01-29 03:23:23', '2019-01-29 03:23:57', 'Department', 'Office Department'),
(596, 'Grace Mativo P.', '2019-01-29 03:36:26', '2019-01-29 03:36:39', 'Department', 'Office Department'),
(597, 'Grace Mativo P.', '2019-01-29 03:38:17', '2019-01-29 03:38:46', 'Department', 'Office Department'),
(598, 'Grace Mativo P.', '2019-01-29 03:43:03', '2019-01-29 03:43:55', 'Department', 'Office Department'),
(599, 'Grace Mativo P.', '2019-01-29 03:45:13', '2019-01-29 03:45:26', 'Department', 'Office Department'),
(600, 'Grace Mativo P.', '2019-01-29 03:45:52', '2019-01-29 03:46:00', 'Department', 'Office Department'),
(601, 'Grace Mativo P.', '2019-01-29 03:56:10', '2019-01-29 04:08:16', 'Department', 'Office Department'),
(602, 'Grace Mativo P.', '2019-01-29 04:09:30', '2019-01-29 04:10:12', 'Department', 'Office Department'),
(603, 'Grace Mativo P.', '2019-01-29 04:14:32', '2019-01-29 04:15:08', 'Department', 'Office Department'),
(604, 'Grace Mativo P.', '2019-01-29 04:19:18', NULL, 'Department', 'Office Department'),
(605, 'Grace Mativo P.', '2019-01-29 04:23:43', '2019-01-29 04:23:57', 'Department', 'Office Department'),
(606, 'Grace Mativo P.', '2019-01-29 04:24:55', '2019-01-29 04:26:45', 'Department', 'Office Department'),
(607, 'Grace Mativo P.', '2019-01-29 04:30:46', '2019-01-29 04:33:29', 'Department', 'Office Department'),
(608, 'Grace Mativo P.', '2019-01-29 04:43:00', '2019-01-29 04:47:05', 'Department', 'Office Department'),
(609, 'Grace Mativo P.', '2019-01-29 04:53:54', NULL, 'Department', 'Office Department'),
(610, 'Grace Mativo P.', '2019-01-29 05:04:24', '2019-01-29 05:11:05', 'Department', 'Office Department'),
(611, 'Grace Mativo P.', '2019-01-29 09:33:18', NULL, 'Department', 'Office Department'),
(612, 'Grace Mativo P.', '2019-01-29 09:51:12', NULL, 'Department', 'Office Department'),
(613, 'Grace Mativo P.', '2019-01-29 09:52:14', NULL, 'Department', 'Office Department'),
(614, 'Grace Mativo P.', '2019-01-29 09:54:18', NULL, 'Department', 'Office Department'),
(615, 'Grace Mativo P.', '2019-01-29 09:57:50', NULL, 'Department', 'Office Department'),
(616, 'Grace Mativo P.', '2019-01-29 09:58:35', NULL, 'Department', 'Office Department'),
(617, 'Grace Mativo P.', '2019-01-29 09:59:55', NULL, 'Department', 'Office Department'),
(618, 'Grace Mativo P.', '2019-01-29 10:03:21', '2019-01-29 10:17:50', 'Department', 'Office Department'),
(619, 'Hannah Mativo P.', '2019-01-29 10:22:42', '2019-01-29 10:39:39', 'HR Department', 'HR department'),
(620, 'Hannah Mativo P.', '2019-01-29 10:50:07', '2019-01-29 10:50:25', 'HR Department', 'HR department'),
(621, 'Hannah Mativo P.', '2019-01-29 10:53:04', '2019-01-29 10:53:29', 'HR Department', 'HR department'),
(622, 'Hannah Mativo P.', '2019-01-29 10:55:31', '2019-01-29 10:55:52', 'HR Department', 'HR department'),
(623, 'Hannah Mativo P.', '2019-01-29 10:57:32', '2019-01-29 10:57:43', 'HR Department', 'HR department'),
(624, 'Hannah Mativo P.', '2019-01-29 10:57:58', '2019-01-29 10:58:25', 'HR Department', 'HR department'),
(625, 'Hannah Mativo P.', '2019-01-29 10:58:58', '2019-01-29 10:59:27', 'HR Department', 'HR department'),
(626, 'Hannah Mativo P.', '2019-01-29 11:00:06', NULL, 'HR Department', 'HR department'),
(627, 'Hannah Mativo P.', '2019-01-29 11:06:51', '2019-01-29 11:07:18', 'HR Department', 'HR department'),
(628, 'Hannah Mativo P.', '2019-01-29 11:08:00', '2019-01-29 11:08:17', 'HR Department', 'HR department'),
(629, 'Hannah Mativo P.', '2019-01-29 11:10:07', '2019-01-29 11:10:31', 'HR Department', 'HR department'),
(630, 'Hannah Mativo P.', '2019-01-29 11:11:03', NULL, 'HR Department', 'HR department'),
(631, 'Hannah Mativo P.', '2019-01-29 11:38:39', '2019-01-29 11:55:46', 'HR Department', 'HR department'),
(632, 'Hannah Mativo P.', '2019-01-29 14:49:40', '2019-01-29 14:50:45', 'HR Department', 'HR department'),
(633, 'Hannah Mativo P.', '2019-01-29 14:51:20', '2019-01-29 14:52:07', 'HR Department', 'HR department'),
(634, 'Hannah Mativo P.', '2019-01-29 14:55:29', '2019-01-29 14:56:35', 'HR Department', 'HR department'),
(635, 'Hannah Mativo P.', '2019-01-29 14:56:48', '2019-01-29 14:57:20', 'HR Department', 'HR department'),
(636, 'Hannah Mativo P.', '2019-01-29 15:04:14', '2019-01-29 15:04:34', 'HR Department', 'HR department'),
(637, 'Hannah Mativo P.', '2019-01-29 15:06:03', '2019-01-29 15:06:22', 'HR Department', 'HR department'),
(638, 'Hannah Mativo P.', '2019-01-29 15:11:36', '2019-01-29 15:11:52', 'HR Department', 'HR department'),
(639, 'Hannah Mativo P.', '2019-01-29 15:14:39', '2019-01-29 15:15:06', 'HR Department', 'HR department'),
(640, 'Hannah Mativo P.', '2019-01-29 15:16:01', '2019-01-29 15:16:40', 'HR Department', 'HR department'),
(641, 'Hannah Mativo P.', '2019-01-29 15:16:59', '2019-01-29 15:18:13', 'HR Department', 'HR department'),
(642, 'Hannah Mativo P.', '2019-01-29 15:19:11', '2019-01-29 15:19:48', 'HR Department', 'HR department'),
(643, 'Hannah Mativo P.', '2019-01-29 15:20:11', '2019-01-29 15:20:36', 'HR Department', 'HR department'),
(644, 'Hannah Mativo P.', '2019-01-29 15:22:25', '2019-01-29 15:22:43', 'HR Department', 'HR department'),
(645, 'Hannah Mativo P.', '2019-01-29 15:23:08', '2019-01-29 15:23:53', 'HR Department', 'HR department'),
(646, 'Hannah Mativo P.', '2019-01-29 15:28:55', '2019-01-29 15:29:28', 'HR Department', 'HR department'),
(647, 'Hannah Mativo P.', '2019-01-29 15:30:36', '2019-01-29 15:30:51', 'HR Department', 'HR department'),
(648, 'Hannah Mativo P.', '2019-01-29 15:31:12', '2019-01-29 15:31:28', 'HR Department', 'HR department'),
(649, 'Hannah Mativo P.', '2019-01-29 15:31:47', '2019-01-29 15:32:01', 'HR Department', 'HR department'),
(650, 'Hannah Mativo P.', '2019-01-29 15:32:43', '2019-01-29 15:33:07', 'HR Department', 'HR department'),
(651, 'Hannah Mativo P.', '2019-01-29 15:33:36', '2019-01-29 15:34:12', 'HR Department', 'HR department'),
(652, 'Hannah Mativo P.', '2019-01-29 15:34:38', '2019-01-29 15:35:15', 'HR Department', 'HR department'),
(653, 'Hannah Mativo P.', '2019-01-29 15:35:45', '2019-01-29 15:36:30', 'HR Department', 'HR department'),
(654, 'Hannah Mativo P.', '2019-01-29 15:37:11', NULL, 'HR Department', 'HR department'),
(655, 'Hannah Mativo P.', '2019-01-29 15:38:31', '2019-01-29 15:41:33', 'HR Department', 'HR department'),
(656, 'Hannah Mativo P.', '2019-01-29 16:00:51', '2019-01-29 16:01:34', 'HR Department', 'HR department'),
(657, 'Hannah Mativo P.', '2019-01-29 16:02:55', '2019-01-29 16:03:21', 'HR Department', 'HR department'),
(658, 'Hannah Mativo P.', '2019-01-29 16:03:50', '2019-01-29 16:04:04', 'HR Department', 'HR department'),
(659, 'Hannah Mativo P.', '2019-01-29 16:04:42', '2019-01-29 16:04:51', 'HR Department', 'HR department'),
(660, 'Hannah Mativo P.', '2019-01-29 16:24:33', '2019-01-29 23:10:15', 'HR Department', 'HR department'),
(661, 'Hannah Mativo P.', '2019-01-30 01:36:30', NULL, 'HR', 'HR department'),
(662, 'Hannah Mativo P.', '2019-01-30 01:42:03', NULL, 'HR', 'HR department'),
(663, 'Hannah Mativo P.', '2019-01-30 01:43:11', NULL, 'HR', 'HR department'),
(664, 'Hannah Mativo P.', '2019-01-30 01:45:24', NULL, 'HR', 'HR department'),
(665, 'Hannah Mativo P.', '2019-01-30 01:47:01', NULL, 'HR', 'HR department'),
(666, 'Hannah Mativo P.', '2019-01-30 01:48:08', '2019-01-30 17:59:47', 'HR', 'HR department'),
(667, 'Hannah Mativo P.', '2019-01-30 18:16:40', '2019-01-30 18:16:51', 'HR', 'HR department'),
(668, 'Hannah Mativo P.', '2019-01-30 18:29:29', '2019-01-30 18:29:56', 'HR', 'HR department'),
(669, 'Hannah Mativo P.', '2019-01-30 18:31:56', '2019-01-30 18:35:20', 'HR', 'HR department'),
(670, 'Hannah Mativo P.', '2019-01-30 18:40:05', '2019-01-30 18:40:49', 'HR', 'HR department'),
(671, 'Hannah Mativo P.', '2019-01-30 22:25:55', '2019-01-30 22:26:30', 'HR', 'HR department'),
(672, 'Hannah Mativo P.', '2019-01-30 22:31:48', '2019-01-30 22:32:45', 'HR', 'HR department'),
(673, 'Hannah Mativo P.', '2019-01-30 22:33:46', '2019-01-30 22:34:38', 'HR', 'HR department'),
(674, 'Hannah Mativo P.', '2019-01-30 22:35:31', '2019-01-30 22:35:50', 'HR', 'HR department'),
(675, 'Hannah Mativo P.', '2019-01-30 22:37:34', '2019-01-30 22:37:53', 'HR', 'HR department'),
(676, 'Hannah Mativo P.', '2019-01-30 22:40:54', '2019-01-30 22:41:19', 'HR', 'HR department'),
(677, 'Hannah Mativo P.', '2019-01-30 22:47:12', '2019-01-30 22:47:32', 'HR', 'HR department'),
(678, 'Hannah Mativo P.', '2019-01-30 22:47:59', '2019-01-30 22:48:25', 'HR', 'HR department'),
(679, 'Hannah Mativo P.', '2019-01-30 22:48:56', '2019-01-30 22:49:27', 'HR', 'HR department'),
(680, 'Hannah Mativo P.', '2019-01-30 22:51:06', '2019-01-30 22:52:38', 'HR', 'HR department'),
(681, 'Hannah Mativo P.', '2019-01-30 22:59:03', '2019-01-30 22:59:14', 'HR', 'HR department'),
(682, 'Hannah Mativo P.', '2019-01-30 22:59:55', '2019-01-30 23:00:16', 'HR', 'HR department'),
(683, 'Hannah Mativo P.', '2019-01-30 23:08:05', '2019-01-30 23:09:23', 'HR', 'HR department'),
(684, 'Hannah Mativo P.', '2019-01-30 23:12:25', '2019-01-30 23:12:54', 'HR', 'HR department'),
(685, 'Hannah Mativo P.', '2019-01-30 23:15:54', '2019-01-30 23:17:33', 'HR', 'HR department'),
(686, 'Hannah Mativo P.', '2019-01-31 01:44:32', '2019-01-31 01:45:29', 'HR', 'HR department'),
(687, 'Hannah Mativo P.', '2019-01-31 03:36:31', '2019-01-31 03:40:52', 'HR', 'HR department'),
(688, 'Hannah Mativo P.', '2019-01-31 03:54:17', '2019-01-31 03:56:17', 'HR', 'HR department'),
(689, 'Hannah Mativo P.', '2019-01-31 04:08:23', '2019-01-31 04:09:01', 'HR', 'HR department'),
(690, 'Hannah Mativo P.', '2019-01-31 04:09:53', '2019-01-31 04:10:23', 'HR', 'HR department'),
(691, 'Hannah Mativo P.', '2019-01-31 04:11:23', '2019-01-31 04:12:02', 'HR', 'HR department'),
(692, 'Hannah Mativo P.', '2019-01-31 04:13:53', '2019-01-31 04:15:35', 'HR', 'HR department'),
(693, 'Hannah Mativo P.', '2019-01-31 04:17:53', '2019-01-31 04:19:06', 'HR', 'HR department'),
(694, 'Hannah Mativo P.', '2019-01-31 04:23:02', '2019-01-31 04:23:58', 'HR', 'HR department'),
(695, 'Hannah Mativo P.', '2019-01-31 04:25:40', NULL, 'HR', 'HR department'),
(696, 'Hannah Mativo P.', '2019-01-31 06:49:04', '2019-01-31 06:49:20', 'HR', 'HR department'),
(697, 'Hannah Mativo P.', '2019-01-31 06:49:57', '2019-01-31 06:50:45', 'HR', 'HR department'),
(698, 'Hannah Mativo P.', '2019-01-31 06:53:35', '2019-01-31 06:53:52', 'HR', 'HR department'),
(699, 'Hannah Mativo P.', '2019-01-31 06:54:31', '2019-01-31 06:54:52', 'HR', 'HR department'),
(700, 'Hannah Mativo P.', '2019-01-31 07:03:58', '2019-01-31 07:05:23', 'HR', 'HR department'),
(701, 'Hannah Mativo P.', '2019-01-31 07:06:59', '2019-01-31 07:07:54', 'HR', 'HR department'),
(702, 'Hannah Mativo P.', '2019-01-31 07:08:21', '2019-01-31 07:16:33', 'HR', 'HR department'),
(703, 'Hannah Mativo P.', '2019-01-31 07:17:48', NULL, 'HR', 'HR department'),
(704, 'Hannah Mativo P.', '2019-01-31 07:42:25', '2019-01-31 07:43:55', 'HR', 'HR department'),
(705, 'Hannah Mativo P.', '2019-01-31 07:47:07', NULL, 'HR', 'HR department'),
(706, 'Hannah Mativo P.', '2019-01-31 07:47:39', NULL, 'HR', 'HR department'),
(707, 'Hannah Mativo P.', '2019-01-31 07:48:26', '2019-01-31 07:48:41', 'HR', 'HR department'),
(708, 'Hannah Mativo P.', '2019-01-31 07:49:31', '2019-01-31 07:49:46', 'HR', 'HR department'),
(709, 'Hannah Mativo P.', '2019-01-31 07:50:20', '2019-01-31 07:50:37', 'HR', 'HR department'),
(710, 'Hannah Mativo P.', '2019-01-31 07:52:21', '2019-01-31 07:52:45', 'HR', 'HR department'),
(711, 'Hannah Mativo P.', '2019-01-31 07:53:43', '2019-01-31 07:54:01', 'HR', 'HR department'),
(712, 'Hannah Mativo P.', '2019-01-31 07:54:56', '2019-01-31 07:55:23', 'HR', 'HR department'),
(713, 'Hannah Mativo P.', '2019-01-31 07:56:20', '2019-01-31 08:05:35', 'HR', 'HR department'),
(714, 'Hannah Mativo P.', '2019-01-31 08:57:40', NULL, 'HR', 'HR department'),
(715, 'Hannah Mativo P.', '2019-01-31 08:58:32', '2019-01-31 09:09:38', 'HR', 'HR department'),
(716, 'Hannah Mativo P.', '2019-01-31 09:13:14', '2019-01-31 09:13:46', 'HR', 'HR department'),
(717, 'Hannah Mativo P.', '2019-01-31 09:23:46', '2019-01-31 09:24:26', 'HR', 'HR department'),
(718, 'Hannah Mativo P.', '2019-01-31 09:25:01', '2019-01-31 09:25:36', 'HR', 'HR department'),
(719, 'Hannah Mativo P.', '2019-01-31 09:31:36', '2019-01-31 09:32:03', 'HR', 'HR department'),
(720, 'Hannah Mativo P.', '2019-01-31 09:33:05', '2019-01-31 09:36:41', 'HR', 'HR department'),
(721, 'Hannah Mativo P.', '2019-01-31 09:40:26', '2019-01-31 09:43:19', 'HR', 'HR department'),
(722, 'Hannah Mativo P.', '2019-01-31 09:44:21', '2019-01-31 09:44:47', 'HR', 'HR department'),
(723, 'Hannah Mativo P.', '2019-01-31 09:57:32', '2019-01-31 09:58:55', 'HR', 'HR department'),
(724, 'Hannah Mativo P.', '2019-01-31 10:02:26', '2019-01-31 10:04:15', 'HR', 'HR department'),
(725, 'Hannah Mativo P.', '2019-01-31 10:05:30', '2019-01-31 10:07:46', 'HR', 'HR department'),
(726, 'Hannah Mativo P.', '2019-01-31 10:07:56', '2019-01-31 10:10:27', 'HR', 'HR department'),
(727, 'Hannah Mativo P.', '2019-01-31 10:13:49', NULL, 'HR', 'HR department'),
(728, 'Hannah Mativo P.', '2019-01-31 10:15:24', NULL, 'HR', 'HR department'),
(729, 'Hannah Mativo P.', '2019-01-31 10:20:13', '2019-01-31 10:20:32', 'HR', 'HR department'),
(730, 'Hannah Mativo P.', '2019-01-31 10:21:30', '2019-01-31 10:22:24', 'HR', 'HR department'),
(731, 'Hannah Mativo P.', '2019-01-31 10:22:47', '2019-01-31 10:23:51', 'HR', 'HR department'),
(732, 'Hannah Mativo P.', '2019-01-31 10:24:22', '2019-01-31 10:24:45', 'HR', 'HR department'),
(733, 'Hannah Mativo P.', '2019-01-31 10:25:12', '2019-01-31 10:25:24', 'HR', 'HR department'),
(734, 'Hannah Mativo P.', '2019-01-31 10:25:40', '2019-01-31 10:29:39', 'HR', 'HR department'),
(735, 'Hannah Mativo P.', '2019-01-31 10:30:25', '2019-01-31 10:30:50', 'HR', 'HR department'),
(736, 'Hannah Mativo P.', '2019-01-31 10:31:20', '2019-01-31 10:31:50', 'HR', 'HR department'),
(737, 'Hannah Mativo P.', '2019-01-31 10:33:22', '2019-01-31 10:33:40', 'HR', 'HR department'),
(738, 'Hannah Mativo P.', '2019-01-31 10:34:05', '2019-01-31 10:34:25', 'HR', 'HR department'),
(739, 'Hannah Mativo P.', '2019-01-31 10:34:58', '2019-01-31 10:35:37', 'HR', 'HR department'),
(740, 'Hannah Mativo P.', '2019-01-31 10:39:14', '2019-01-31 10:39:50', 'HR', 'HR department'),
(741, 'Hannah Mativo P.', '2019-01-31 10:42:22', NULL, 'HR', 'HR department'),
(742, 'Hannah Mativo P.', '2019-01-31 15:37:04', '2019-01-31 15:40:28', 'HR', 'HR department'),
(743, 'Hannah Mativo P.', '2019-01-31 15:41:45', '2019-01-31 15:43:31', 'HR', 'HR department'),
(744, 'Hannah Mativo P.', '2019-01-31 15:45:28', '2019-01-31 15:45:54', 'HR', 'HR department'),
(745, 'Hannah Mativo P.', '2019-01-31 15:47:30', '2019-01-31 15:47:52', 'HR', 'HR department'),
(746, 'Hannah Mativo P.', '2019-01-31 15:48:13', '2019-01-31 15:48:49', 'HR', 'HR department'),
(747, 'Hannah Mativo P.', '2019-01-31 15:50:02', NULL, 'HR', 'HR department'),
(748, 'Hannah Mativo P.', '2019-01-31 15:50:30', NULL, 'HR', 'HR department'),
(749, 'Hannah Mativo P.', '2019-01-31 15:51:19', NULL, 'HR', 'HR department'),
(750, 'Hannah Mativo P.', '2019-01-31 15:52:35', '2019-01-31 15:53:04', 'HR', 'HR department'),
(751, 'Hannah Mativo P.', '2019-01-31 15:55:01', NULL, 'HR', 'HR department'),
(752, 'Hannah Mativo P.', '2019-01-31 15:55:45', '2019-01-31 15:56:14', 'HR', 'HR department'),
(753, 'Hannah Mativo P.', '2019-01-31 15:59:35', '2019-01-31 16:00:03', 'HR', 'HR department'),
(754, 'Hannah Mativo P.', '2019-01-31 16:00:35', NULL, 'HR', 'HR department'),
(755, 'Hannah Mativo P.', '2019-01-31 16:04:01', NULL, 'HR', 'HR department'),
(756, 'Hannah Mativo P.', '2019-01-31 16:04:26', '2019-01-31 16:05:38', 'HR', 'HR department'),
(757, 'Hannah Mativo P.', '2019-01-31 16:07:15', '2019-01-31 16:08:29', 'HR', 'HR department'),
(758, 'Hannah Mativo P.', '2019-01-31 16:09:47', '2019-01-31 16:10:10', 'HR', 'HR department'),
(759, 'Hannah Mativo P.', '2019-01-31 16:10:59', NULL, 'HR', 'HR department'),
(760, 'Hannah Mativo P.', '2019-01-31 16:13:16', '2019-01-31 16:13:54', 'HR', 'HR department'),
(761, 'Hannah Mativo P.', '2019-01-31 16:16:47', '2019-01-31 16:17:18', 'HR', 'HR department'),
(762, 'Hannah Mativo P.', '2019-01-31 16:18:04', '2019-01-31 16:19:10', 'HR', 'HR department'),
(763, 'Hannah Mativo P.', '2019-01-31 16:21:47', '2019-01-31 16:24:21', 'HR', 'HR department'),
(764, 'Hannah Mativo P.', '2019-01-31 16:51:40', '2019-01-31 16:56:01', 'HR', 'HR department'),
(765, 'Hannah Mativo P.', '2019-01-31 17:08:24', '2019-01-31 18:07:38', 'HR', 'HR department'),
(766, 'Hannah Mativo P.', '2019-01-31 18:08:21', '2019-01-31 18:09:05', 'HR', 'HR department'),
(767, 'Hannah Mativo P.', '2019-01-31 18:12:22', '2019-01-31 18:13:04', 'HR', 'HR department'),
(768, 'Hannah Mativo P.', '2019-01-31 18:16:52', NULL, 'HR', 'HR department'),
(769, 'Hannah Mativo P.', '2019-01-31 18:18:41', NULL, 'HR', 'HR department'),
(770, 'Hannah Mativo P.', '2019-01-31 18:19:13', '2019-01-31 18:19:28', 'HR', 'HR department'),
(771, 'Hannah Mativo P.', '2019-01-31 18:19:45', NULL, 'HR', 'HR department'),
(772, 'Hannah Mativo P.', '2019-01-31 18:20:12', NULL, 'HR', 'HR department'),
(773, 'Hannah Mativo P.', '2019-01-31 18:20:37', '2019-01-31 18:20:51', 'HR', 'HR department'),
(774, 'Hannah Mativo P.', '2019-01-31 18:21:25', NULL, 'HR', 'HR department'),
(775, 'Hannah Mativo P.', '2019-01-31 18:22:31', NULL, 'HR', 'HR department'),
(776, 'Hannah Mativo P.', '2019-01-31 18:23:07', NULL, 'HR', 'HR department'),
(777, 'Hannah Mativo P.', '2019-01-31 18:24:59', NULL, 'HR', 'HR department'),
(778, 'Hannah Mativo P.', '2019-01-31 18:25:49', NULL, 'HR', 'HR department'),
(779, 'Hannah Mativo P.', '2019-01-31 18:26:18', '2019-01-31 18:26:39', 'HR', 'HR department'),
(780, 'Hannah Mativo P.', '2019-01-31 18:32:15', '2019-01-31 18:32:43', 'HR', 'HR department'),
(781, 'Hannah Mativo P.', '2019-01-31 18:33:46', NULL, 'HR', 'HR department'),
(782, 'Hannah Mativo P.', '2019-01-31 18:40:36', '2019-01-31 18:41:07', 'HR', 'HR department'),
(783, 'Hannah Mativo P.', '2019-01-31 18:44:17', '2019-01-31 18:45:00', 'HR', 'HR department'),
(784, 'Hannah Mativo P.', '2019-01-31 18:45:58', NULL, 'HR', 'HR department'),
(785, 'Hannah Mativo P.', '2019-01-31 18:50:32', '2019-01-31 18:51:14', 'HR', 'HR department'),
(786, 'Hannah Mativo P.', '2019-01-31 18:53:41', NULL, 'HR', 'HR department'),
(787, 'Hannah Mativo P.', '2019-01-31 18:54:13', '2019-01-31 18:55:08', 'HR', 'HR department'),
(788, 'Hannah Mativo P.', '2019-01-31 19:00:12', '2019-01-31 19:01:37', 'HR', 'HR department'),
(789, 'Hannah Mativo P.', '2019-01-31 19:02:11', '2019-01-31 19:03:03', 'HR', 'HR department'),
(790, 'Hannah Mativo P.', '2019-01-31 19:45:46', '2019-01-31 19:45:59', 'HR', 'HR department'),
(791, 'Hannah Mativo P.', '2019-01-31 19:46:21', '2019-01-31 19:47:25', 'HR', 'HR department'),
(792, 'Hannah Mativo P.', '2019-01-31 19:53:11', '2019-02-01 10:51:33', 'HR', 'HR department'),
(793, 'Hannah Mativo P.', '2019-02-01 10:52:38', '2019-02-01 10:53:00', 'HR', 'HR department'),
(794, 'Hannah Mativo P.', '2019-02-01 10:54:03', '2019-02-01 10:54:19', 'HR', 'HR department'),
(795, 'Hannah Mativo P.', '2019-02-01 10:54:50', '2019-02-01 10:55:10', 'HR', 'HR department'),
(796, 'Hannah Mativo P.', '2019-02-01 10:55:38', '2019-02-07 12:49:04', 'HR', 'HR department'),
(797, 'Hannah Mativo P.', '2019-02-07 12:52:21', '2019-02-08 12:36:18', 'HR', 'HR department'),
(798, 'Hannah Mativo P.', '2019-02-08 16:06:27', '2019-02-08 16:32:51', 'HR', 'HR department'),
(799, 'Hannah Mativo P.', '2019-02-08 16:33:06', '2019-02-19 03:00:20', 'HR', 'HR department');

-- --------------------------------------------------------

--
-- Table structure for table `vw_account`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_account` AS select `a`.`accountID` AS `accountID`,concat(`a`.`fname`,' ',`a`.`mname`,' ',`a`.`lname`) AS `fullname`,`d`.`designationDesc` AS `designationDesc`,`d`.`deptDesc` AS `deptDesc`,`a`.`UserName` AS `UserName`,`a`.`passKey` AS `passKey`,`u`.`userDesc` AS `userDesc`,`a`.`is_active` AS `is_active` from ((`inventorypetromine`.`tbl_account` `a` join `inventorypetromine`.`tbl_designation` `d` on((`a`.`designationID` = `d`.`designationID`))) join `inventorypetromine`.`tbl_usertype` `u` on((`a`.`userTypeID` = `u`.`userTypeID`)));

--
-- Dumping data for table `vw_account`
--

INSERT INTO `vw_account` (`accountID`, `fullname`, `designationDesc`, `deptDesc`, `UserName`, `passKey`, `userDesc`, `is_active`) VALUES
(1, 'Marth L. Enriquez', 'HR', 'HR Department', 'lokaloka', 'akoyun', 'Admin', 1),
(6, 'Jessamine D. Pingol', 'Inventory Clerk', 'Office', 'JDP@22', 'kingsolomon', 'InventoryClerk', 1);

-- --------------------------------------------------------

--
-- Table structure for table `vw_finishedproducts`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_finishedproducts` AS select `f`.`finprodID` AS `finprodID`,`f`.`prodName` AS `prodName`,`f`.`descrip` AS `descrip`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`f`.`price` AS `price`,`f`.`qty` AS `qty` from ((`inventorypetromine`.`tbl_finishedproducts` `f` join `inventorypetromine`.`tbl_category` `c` on((`f`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`f`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_finishedproducts`
--

INSERT INTO `vw_finishedproducts` (`finprodID`, `prodName`, `descrip`, `catDesc`, `unitDesc`, `price`, `qty`) VALUES
(25, 'Ferrous', 'Non-Metallic', 'PPE', 'Weight', '455.00', 79),
(18, 'Alloy', 'Scraps', 'ENGG', 'cm', '125.00', 490),
(21, 'Metal', 'Best Programming', 'Office', 'cm', '220.00', 1318);

-- --------------------------------------------------------

--
-- Table structure for table `vw_maintransaction`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_maintransaction` AS select `t`.`salesID` AS `salesID`,`t`.`itemID` AS `itemID`,`t`.`endProduct` AS `endProduct`,`t`.`category` AS `category`,`t`.`unit` AS `unit`,`t`.`qty` AS `qty`,`t`.`untPrice` AS `untPrice`,`t`.`totalPrice` AS `totalPrice`,`t`.`NoOfItems` AS `NoOfItems`,`t`.`sDate` AS `sDate`,concat(`e`.`fname`,' ',`e`.`mi`,' ',`e`.`lname`) AS `fullname`,`d`.`designationDesc` AS `designationDesc`,`d`.`deptDesc` AS `deptDesc`,`c`.`clientCode` AS `clientCode`,`c`.`Company` AS `Company`,`c`.`clientName` AS `clientName`,`c`.`Address` AS `Address`,`t`.`total` AS `total`,`t`.`totalVat` AS `totalVat`,`t`.`grandTotal` AS `grandTotal`,`t`.`amountTendered` AS `amountTendered`,`t`.`change` AS `change`,`t`.`sTime` AS `sTime` from (((`inventorypetromine`.`tbl_maintransaction` `t` join `inventorypetromine`.`tbl_employee` `e` on((`t`.`empID` = `e`.`empID`))) join `inventorypetromine`.`tbl_designation` `d` on((`e`.`designationID` = `d`.`designationID`))) join `inventorypetromine`.`tbl_client` `c` on((`t`.`clientID` = `c`.`clientID`)));

--
-- Dumping data for table `vw_maintransaction`
--

INSERT INTO `vw_maintransaction` (`salesID`, `itemID`, `endProduct`, `category`, `unit`, `qty`, `untPrice`, `totalPrice`, `NoOfItems`, `sDate`, `fullname`, `designationDesc`, `deptDesc`, `clientCode`, `Company`, `clientName`, `Address`, `total`, `totalVat`, `grandTotal`, `amountTendered`, `change`, `sTime`) VALUES
(11, 108, 'Ferrous Metals', 'Warehouse', 'cm', 1, '20.00', '20.00', 1, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD001', 'Daedck Phils. Inc.', 'golo', 'Malaysia', '20.00', '3.00', '23.00', '30', '7.00', '03:47:12'),
(2, 101, 'Non-Ferrous Metals', 'Warehouse', 'cm', 2, '45.00', '90.00', 2, '2019-02-09', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD002', 'San Technology inc.', 'Vidal', 'China', '90.00', '13.50', '103.50', '120', '-16.50', '00:35:22'),
(7, 105, 'Ferrous Metals', 'Warehouse', 'cm', 4, '20.00', '80.00', 4, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD002', 'San Technology inc.', 'Vidal', 'China', '80.00', '12.00', '92.00', '100', '8.00', '03:27:45'),
(5, 104, 'Ferrous Metals', 'Warehouse', 'cm', 4, '20.00', '80.00', 7, '2019-02-10', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '740.00', '111.00', '851.00', '1000', '149.00', '15:54:54'),
(6, 104, 'Metal', 'Office', 'cm', 3, '220.00', '660.00', 7, '2019-02-10', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '740.00', '111.00', '851.00', '1000', '149.00', '15:54:54'),
(10, 107, 'Ferrous Metals', 'Warehouse', 'cm', 2, '20.00', '40.00', 2, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '40.00', '6.00', '46.00', '20', '-26.00', '03:35:03'),
(12, 109, 'Ferrous Metals', 'Warehouse', 'cm', 3, '20.00', '60.00', 8, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '1,160.00', '174.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(13, 109, 'Metal', 'Office', 'cm', 5, '220.00', '1100.00', 8, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '1,160.00', '174.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(22, 115, 'Ferrous Metals', 'Warehouse', 'cm', 1, '20.00', '20.00', 51, '2019-02-14', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '11,020.00', '1653.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(23, 115, 'Metal', 'Office', 'cm', 50, '220.00', '11000.00', 51, '2019-02-14', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '11,020.00', '1653.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(25, 117, 'Ferrous-Non', 'Rotary', 'lbs', 8, '560.00', '4480.00', 10, '2019-02-15', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD003', 'Palaisdaan inc.', 'Malone', 'Singapore', '5,600.00', '672.00', '6,272.00', '7000', '728.00', '20:02:27'),
(4, 103, 'Metal', 'Office', 'cm', 3, '220.00', '660.00', 3, '2019-02-09', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '660.00', '99.00', '759.00', '1000', '241.00', '00:58:00'),
(8, 106, 'Ferrous Metals', 'Warehouse', 'cm', 3, '20.00', '60.00', 6, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '720.00', '99.00', '819.00', '500', '-319.00', '03:31:08'),
(9, 106, 'Metal', 'Office', 'cm', 3, '220.00', '660.00', 6, '2019-02-11', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '720.00', '99.00', '819.00', '500', '-319.00', '03:31:08'),
(18, 112, 'Non-Ferrous Metals', 'Warehouse', 'cm', 1, '45.00', '45.00', 1, '2019-02-13', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '45.00', '6.75', '51.75', '100', '48.25', '03:24:05'),
(19, 113, 'Metal', 'Office', 'cm', 2, '220.00', '440.00', 5, '2019-02-13', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '815.00', '122.25', '937.25', '1000', '62.75', '03:31:58'),
(20, 113, 'Alloy', 'ENGG', 'cm', 3, '125.00', '375.00', 5, '2019-02-13', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '815.00', '122.25', '937.25', '1000', '62.75', '03:31:58'),
(21, 114, 'Alloy', 'ENGG', 'cm', 495, '125.00', '61875.00', 495, '2019-02-13', 'Hannah P. Mativo', 'HR', 'HR Department', 'CD004', 'Ltd. Messiah Hardware Inc.', 'Mativo', 'Laos', '61,875.00', '9281.25', '71,156.25', '100000', '28,843.75', '03:33:56');

-- --------------------------------------------------------

--
-- Table structure for table `vw_newemployee`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_newemployee` AS select `e`.`empID` AS `empID`,`e`.`fname` AS `fname`,`e`.`mi` AS `mi`,`e`.`lname` AS `lname`,`e`.`bday` AS `bday`,`e`.`blk` AS `blk`,`e`.`street` AS `street`,`e`.`brgy` AS `brgy`,`c`.`cityDesc` AS `cityDesc`,`e`.`cnum` AS `cnum`,`d`.`designationDesc` AS `designationDesc`,`dep`.`deptDesc` AS `deptDesc`,concat(`e`.`fname`,' ',`e`.`lname`,' ',`e`.`mi`) AS `fullname` from (((`inventorypetromine`.`tbl_employee` `e` join `inventorypetromine`.`tbl_city` `c` on((`e`.`cityID` = `c`.`cityID`))) join `inventorypetromine`.`tbl_designation` `d` on((`e`.`designationID` = `d`.`designationID`))) join `inventorypetromine`.`tbl_department` `dep` on((`e`.`deptID` = `dep`.`deptID`)));

--
-- Dumping data for table `vw_newemployee`
--

INSERT INTO `vw_newemployee` (`empID`, `fname`, `mi`, `lname`, `bday`, `blk`, `street`, `brgy`, `cityDesc`, `cnum`, `designationDesc`, `deptDesc`, `fullname`) VALUES
(11, 'Hannah', 'P.', 'Mativo', '1997-09-16', '12', 'Carmel St.', '183', 'Caloocan City', 2147483647, 'HR', 'HR department', 'Hannah Mativo P.'),
(12, 'Erick', 'A.', 'Golo', '1994-10-06', '06', 'Steve Street', 'Manggahan', 'Queztion City', 2147483647, 'Accounting', 'Accounting Department', 'Erick Golo A.');

-- --------------------------------------------------------

--
-- Table structure for table `vw_purchasereqmain`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_purchasereqmain` AS select `p`.`purchaseID` AS `purchaseID`,`p`.`purchaseNo` AS `purchaseNo`,`p`.`reqBy` AS `reqBy`,`p`.`dept` AS `dept`,`p`.`remarks` AS `remarks`,`p`.`dateRequest` AS `dateRequest`,`s`.`supplierID` AS `supplierID`,`s`.`company` AS `company`,`s`.`supplierName` AS `supplierName`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`p`.`qty` AS `qty`,`p`.`is_active` AS `is_active` from ((((`inventorypetromine`.`tbl_purchasereqmain` `p` join `inventorypetromine`.`tbl_supplier` `s` on((`p`.`supplierID` = `s`.`supplierID`))) join `inventorypetromine`.`tbl_rawmaterial` `r` on((`p`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_purchasereqmain`
--

INSERT INTO `vw_purchasereqmain` (`purchaseID`, `purchaseNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `supplierID`, `company`, `supplierName`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`, `is_active`) VALUES
(100, 64, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-15', 3, 'Phcp inc', 'Emily', 'Cobalt', 'Alloys', 'Production', 'cm', 25, 1),
(99, 63, 'Hannah P. Mativo', 'HR department', 'PRODCUT', '2019-02-15', 5, 'kedica', 'Golo', 'Monel', 'alloys', 'Production', 'cm', 60, 1),
(102, 65, 'Hannah P. Mativo', 'HR department', 'JUNK', '2019-02-15', 3, 'Phcp inc', 'Emily', 'Monel', 'alloys', 'Production', 'cm', 20, 1),
(103, 66, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-15', 1, 'Daeduc Phils. Inc', 'Zaito', 'Monel', 'alloys', 'Production', 'cm', 20, 1),
(104, 67, 'Erick A. Golo', 'Accounting Department', '', '2019-02-18', 5, 'kedica', 'Golo', 'Monel', 'alloys', 'Production', 'cm', 221, 1),
(105, 68, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 5, 'kedica', 'Golo', 'Monel', 'alloys', 'Production', 'cm', 441, 1),
(106, 69, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 4, 'Samsung Electro Mechanics', 'Hannah', 'Monel', 'alloys', 'Production', 'cm', 2, 1),
(101, 65, 'Hannah P. Mativo', 'HR department', 'JUNK', '2019-02-15', 3, 'Phcp inc', 'Emily', 'Nimonic', 'Alloys', 'Production', 'cm', 20, 1);

-- --------------------------------------------------------

--
-- Table structure for table `vw_purchaserequestrelease`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_purchaserequestrelease` AS select `p`.`POreqID` AS `POreqID`,`m`.`purchaseNo` AS `purchaseNo`,`m`.`reqBy` AS `reqBy`,`m`.`dept` AS `dept`,`m`.`dateRequest` AS `dateRequest`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`m`.`qty` AS `qty`,`s`.`company` AS `company`,`s`.`supplierName` AS `supplierName`,`s`.`Address` AS `Address`,`s`.`contactPerson` AS `contactPerson`,`s`.`cnum` AS `cnum`,`p`.`deliverReportNo` AS `deliverReportNo`,`p`.`deliveryReportDate` AS `deliveryReportDate`,`p`.`dateReceived` AS `dateReceived`,`p`.`rTime` AS `rTime` from (((((`inventorypetromine`.`tbl_purchaserequestrelease` `p` join `inventorypetromine`.`tbl_purchasereqmain` `m` on((`p`.`purchaseID` = `m`.`purchaseID`))) join `inventorypetromine`.`tbl_rawmaterial` `r` on((`m`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`))) join `inventorypetromine`.`tbl_supplier` `s` on((`p`.`supplierID` = `s`.`supplierID`)));

--
-- Dumping data for table `vw_purchaserequestrelease`
--


-- --------------------------------------------------------

--
-- Table structure for table `vw_rawmaterial`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_rawmaterial` AS select `r`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`r`.`is_active` AS `is_active` from ((`inventorypetromine`.`tbl_rawmaterial` `r` join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_rawmaterial`
--

INSERT INTO `vw_rawmaterial` (`rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `is_active`) VALUES
(8, 'Cobalt', 'Alloys', 'Production', 'cm', 1),
(9, 'Monel', 'alloys', 'Production', 'cm', 1),
(10, 'Nimonic', 'Alloys', 'Production', 'cm', 1),
(11, 'Pewter', 'Alloys', 'Production', 'cm', 1),
(13, 'bronze', 'asdas', 'Warehouse', 'cm', 1),
(14, 'Copper', 'Mineral', 'ENGG', 'cm', 1);

-- --------------------------------------------------------

--
-- Table structure for table `vw_rawmaterialmonitoring`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_rawmaterialmonitoring` AS select `m`.`rawmaterialOnHandID` AS `rawmaterialOnHandID`,`m`.`transactionNo` AS `transactionNo`,`m`.`requestDate` AS `requestDate`,`m`.`comSupplier` AS `comSupplier`,`m`.`supplierName` AS `supplierName`,`m`.`deliveryRepDate` AS `deliveryRepDate`,`m`.`receiveBy` AS `receiveBy`,`m`.`dateReceive` AS `dateReceive`,`r`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`m`.`qty` AS `qty` from (((`inventorypetromine`.`tbl_rawmaterialmonitoring` `m` join `inventorypetromine`.`tbl_rawmaterial` `r` on((`m`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_rawmaterialmonitoring`
--

INSERT INTO `vw_rawmaterialmonitoring` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`) VALUES
(123, 169, '2019-02-19', 'Phcp inc', 'Emily', '2019-02-02', 'Hannah Mativo P.', '2019-02-02', 9, 'Monel', 'alloys', 'Production', 'cm', 44),
(124, 170, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', '2019-02-06', 'Hannah Mativo P.', '2019-02-06', 9, 'Monel', 'alloys', 'Production', 'cm', 34),
(120, 166, '2019-02-19', 'Nidec copal phils corp', 'Vidal', '2019-02-01', 'Hannah Mativo P.', '2019-02-01', 9, 'Monel', 'alloys', 'Production', 'cm', 500),
(125, 170, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', '2019-02-06', 'Hannah Mativo P.', '2019-02-06', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 12),
(122, 168, '2019-02-19', 'kedica', 'Golo', '2019-02-01', 'Hannah Mativo P.', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 5000),
(121, 167, '2019-02-19', 'kedica', 'Golo', '2019-02-01', '', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 25),
(119, 165, '2019-02-19', 'Phcp inc', 'Emily', '2019-02-01', '', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 3000),
(118, 164, '2019-02-19', 'Phcp inc', 'Emily', '2019-02-01', '', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 1),
(117, 163, '2019-02-19', 'Samsung Electro Mechanics', 'Hannah', '2019-02-01', '', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 1),
(116, 162, '2019-02-19', 'Phcp inc', 'Emily', '2019-02-01', '', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 1),
(90, 136, '2019-02-19', 'pcp', 'EMILYA', '2019-03-03', 'Hannah Mativo P.', '2019-03-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 1);

-- --------------------------------------------------------

--
-- Table structure for table `vw_rawmaterialonhand`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_rawmaterialonhand` AS select `o`.`rawmaterialOnHandID` AS `rawmaterialOnHandID`,`o`.`transactionNo` AS `transactionNo`,`o`.`requestDate` AS `requestDate`,`o`.`comSupplier` AS `comSupplier`,`o`.`supplierName` AS `supplierName`,`o`.`deliveryRepNo` AS `deliveryRepNo`,`o`.`deliveryRepDate` AS `deliveryRepDate`,`o`.`receiveBy` AS `receiveBy`,`o`.`dateReceive` AS `dateReceive`,`r`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`o`.`qty` AS `qty` from (((`inventorypetromine`.`tbl_rawmaterialonhand` `o` join `inventorypetromine`.`tbl_rawmaterial` `r` on((`o`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_rawmaterialonhand`
--

INSERT INTO `vw_rawmaterialonhand` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`) VALUES
(1, 117, '2019-01-19', 'e', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 0),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 21916),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 'Monel', 'alloys', 'Production', 'cm', 662),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 831),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 'Pewter', 'Alloys', 'Production', 'cm', 450);

-- --------------------------------------------------------

--
-- Table structure for table `vw_rawmaterialqty`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_rawmaterialqty` AS select `rq`.`rawmaterialqtyID` AS `rawmaterialqtyID`,`r`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`rq`.`qty` AS `qty` from (((`inventorypetromine`.`tbl_rawmaterialqty` `rq` join `inventorypetromine`.`tbl_rawmaterial` `r` on((`rq`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_rawmaterialqty`
--


-- --------------------------------------------------------

--
-- Table structure for table `vw_rawmterialonhand`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_rawmterialonhand` AS select `o`.`rawmaterialOnHandID` AS `rawmaterialOnHandID`,`o`.`transactionNo` AS `transactionNo`,`o`.`requestDate` AS `requestDate`,`o`.`comSupplier` AS `comSupplier`,`o`.`supplierName` AS `supplierName`,`o`.`deliveryRepNo` AS `deliveryRepNo`,`o`.`deliveryRepDate` AS `deliveryRepDate`,`o`.`receiveBy` AS `receiveBy`,`o`.`dateReceive` AS `dateReceive`,`r`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`o`.`qty` AS `qty` from (((`inventorypetromine`.`tbl_rawmaterialonhand` `o` join `inventorypetromine`.`tbl_rawmaterial` `r` on((`o`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_rawmterialonhand`
--

INSERT INTO `vw_rawmterialonhand` (`rawmaterialOnHandID`, `transactionNo`, `requestDate`, `comSupplier`, `supplierName`, `deliveryRepNo`, `deliveryRepDate`, `receiveBy`, `dateReceive`, `rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`) VALUES
(1, 117, '2019-01-19', 'e', 'Emily', 1, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 0),
(8, 124, '2019-01-19', 'Samsung Electro Mechanics', 'deza', 8, '2019-01-22', 'Emely S. Illano', '2019-01-22', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 21916),
(9, 125, '2019-01-19', 'Phcp inc', 'Allen', 9, '2019-01-22', 'Emely S. Illano', '2019-01-22', 9, 'Monel', 'alloys', 'Production', 'cm', 662),
(10, 126, '2019-01-19', 'Phcp inc', 'Allen', 10, '2019-01-22', 'Emely S. Illano', '2019-01-22', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 831),
(11, 127, '2019-01-19', 'kedica', 'rainne', 11, '2019-01-22', 'Emely S. Illano', '2019-01-22', 11, 'Pewter', 'Alloys', 'Production', 'cm', 450);

-- --------------------------------------------------------

--
-- Table structure for table `vw_releasing`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_releasing` AS select `r`.`releasingID` AS `releasingID`,`rs`.`reqSupNo` AS `reqSupNo`,`rs`.`reqBy` AS `reqBy`,`rs`.`dept` AS `dept`,`rs`.`remarks` AS `remarks`,`rs`.`dateRequest` AS `dateRequest`,`rm`.`rawmaterialID` AS `rawmaterialID`,`rm`.`rawmaterialName` AS `rawmaterialName`,`rm`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`rs`.`qty` AS `qty`,`r`.`releaseBy` AS `releaseBy`,`r`.`deptEmp` AS `deptEmp`,`r`.`dateReleased` AS `dateReleased` from ((((`inventorypetromine`.`tbl_releasing` `r` join `inventorypetromine`.`tbl_mainreqsupplies` `rs` on((`r`.`reqSupNo` = `rs`.`reqSupNo`))) join `inventorypetromine`.`tbl_rawmaterial` `rm` on((`rs`.`rawmaterialID` = `rm`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`rm`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`rm`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_releasing`
--

INSERT INTO `vw_releasing` (`releasingID`, `reqSupNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`, `releaseBy`, `deptEmp`, `dateReleased`) VALUES
(1, 1, 'ASDS', 'ASDSA', 'ASDASD', '2018-09-09', 9, 'Monel', 'alloys', 'Production', 'cm', 12, 'Mae D. Lopez', 'Warehouse Factory', '2018-10-16'),
(4, 1, 'ASDS', 'ASDSA', 'ASDASD', '2018-09-09', 9, 'Monel', 'alloys', 'Production', 'cm', 12, 'Drexler E. Veydal', 'HR department', '2018-12-10'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(35, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, '', '', '2019-01-09'),
(38, 25, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Grace P. Mativo', 'HR department', '2019-01-09'),
(41, 24, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 'Grace Mativo P.', 'Office Department', '2019-01-10'),
(86, 1, 'ASDS', 'ASDSA', 'ASDASD', '2018-09-09', 9, 'Monel', 'alloys', 'Production', 'cm', 12, '', '', '2019-01-17'),
(156, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(156, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(156, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(156, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(157, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(157, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(157, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(157, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(158, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 11, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(158, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(160, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 11, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(160, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(161, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(161, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(161, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(161, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(162, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(162, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(162, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(162, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(163, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(163, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(163, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(163, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(164, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(164, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(164, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(164, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(165, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(165, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(165, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(165, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(169, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(169, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(169, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(169, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(170, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 11, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(170, 101, 'Hannah P. Mativo', 'HR department', 'dasda', '2019-02-01', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(171, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(171, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(171, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(171, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(172, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(172, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(172, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(172, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(173, 100, 'Hannah P. Mativo', 'HR department', 'gh', '2019-02-01', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(173, 100, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-02', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(173, 100, 'Hannah P. Mativo', 'HR department', 'Products', '2019-02-02', 11, 'Pewter', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(173, 100, 'Hannah P. Mativo', 'HR department', 'de', '2019-02-03', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'asdad', '2019-02-07', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 11, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'asdas', '2019-02-07', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 11, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'asd', '2019-02-07', 9, 'Monel', 'alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'er', '2019-02-07', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 12, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'jkhjkh', '2019-02-07', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 7, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', 'asdasd', '2019-02-07', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 24, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', '3', '2019-02-09', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(174, 120, 'Hannah P. Mativo', 'HR department', '2', '2019-02-09', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(175, 121, 'Hannah P. Mativo', 'HR department', 'fer', '2019-02-09', 9, 'Monel', 'alloys', 'Production', 'cm', 3, 'Hannah P. Mativo', 'HR department', '2019-02-09'),
(176, 121, 'Hannah P. Mativo', 'HR department', 'fer', '2019-02-09', 9, 'Monel', 'alloys', 'Production', 'cm', 3, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(177, 124, 'Hannah P. Mativo', 'HR department', 'rekos', '2019-02-10', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 37, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(178, 126, 'Hannah P. Mativo', 'HR department', 'Godzilla Business', '2019-02-10', 9, 'Monel', 'alloys', 'Production', 'cm', 61, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(181, 0, 'Hannah P. Mativo', 'HR department', '1', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(182, 2, 'Grace P. Mativo', 'Office Department', '11', '2018-10-18', 11, 'Pewter', 'Alloys', 'Production', 'cm', 11, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(186, 23, 'Hannah P. Mativo', 'HR department', 'rer', '2019-02-13', 9, 'Monel', 'alloys', 'Production', 'cm', 810, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(186, 23, 'Hannah P. Mativo', 'HR department', 'FOODRAGS', '2019-02-15', 9, 'Monel', 'alloys', 'Production', 'cm', 65, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(186, 23, 'Hannah P. Mativo', 'HR department', 'WAREHOUSE', '2019-02-15', 11, 'Pewter', 'Alloys', 'Production', 'cm', 50, 'Hannah Mativo P.', 'HR department', '0000-00-00'),
(187, 23, 'Hannah P. Mativo', 'HR department', 'rer', '2019-02-13', 9, 'Monel', 'alloys', 'Production', 'cm', 810, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(187, 23, 'Hannah P. Mativo', 'HR department', 'FOODRAGS', '2019-02-15', 9, 'Monel', 'alloys', 'Production', 'cm', 65, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(187, 23, 'Hannah P. Mativo', 'HR department', 'WAREHOUSE', '2019-02-15', 11, 'Pewter', 'Alloys', 'Production', 'cm', 50, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(188, 23, 'Hannah P. Mativo', 'HR department', 'rer', '2019-02-13', 9, 'Monel', 'alloys', 'Production', 'cm', 810, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(188, 23, 'Hannah P. Mativo', 'HR department', 'FOODRAGS', '2019-02-15', 9, 'Monel', 'alloys', 'Production', 'cm', 65, 'Hannah P. Mativo', 'HR department', '0000-00-00'),
(188, 23, 'Hannah P. Mativo', 'HR department', 'WAREHOUSE', '2019-02-15', 11, 'Pewter', 'Alloys', 'Production', 'cm', 50, 'Hannah P. Mativo', 'HR department', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `vw_reqsuppliess`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_reqsuppliess` AS select `r`.`reqSupID` AS `reqSupID`,`r`.`reqSupNo` AS `reqSupNo`,`r`.`reqBy` AS `reqBy`,`r`.`dept` AS `dept`,`r`.`remarks` AS `remarks`,`r`.`dateRequest` AS `dateRequest`,`rm`.`rawmaterialID` AS `rawmaterialID`,`rm`.`rawmaterialName` AS `rawmaterialName`,`rm`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`r`.`qty` AS `qty`,`r`.`is_active` AS `is_active` from (((`inventorypetromine`.`tbl_reqsupplies` `r` join `inventorypetromine`.`tbl_rawmaterial` `rm` on((`r`.`rawmaterialID` = `rm`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`rm`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`rm`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_reqsuppliess`
--

INSERT INTO `vw_reqsuppliess` (`reqSupID`, `reqSupNo`, `reqBy`, `dept`, `remarks`, `dateRequest`, `rawmaterialID`, `rawmaterialName`, `desc`, `catDesc`, `unitDesc`, `qty`, `is_active`) VALUES
(6, 1, 'Hannah P. Mativo', 'HR department', 'febibgig', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 1, 1),
(8, 2, 'Hannah P. Mativo', 'HR department', 'hayup ka', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 5, 1),
(14, 6, 'Hannah P. Mativo', 'HR department', 'plastic', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 35, 1),
(15, 7, 'Hannah P. Mativo', 'HR department', 'gyu', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 15, 1),
(19, 11, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 5, 1),
(22, 13, 'Hannah P. Mativo', 'HR department', 'fr', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 4, 1),
(26, 16, 'Hannah P. Mativo', 'HR department', 'e', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 4, 1),
(27, 17, 'Hannah P. Mativo', 'HR department', '3', '2019-02-11', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 3, 1),
(34, 22, 'Hannah P. Mativo', 'HR department', 'STOCKROOM3', '2019-02-12', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 10, 1),
(37, 25, 'Hannah P. Mativo', 'HR department', 'WORKER', '2019-02-18', 8, 'Cobalt', 'Alloys', 'Production', 'cm', 2, 1),
(9, 3, 'Hannah P. Mativo', 'HR department', '2', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(10, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(11, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(12, 4, 'Hannah P. Mativo', 'HR department', 'hayup ka talaga!', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(13, 5, 'Hannah P. Mativo', 'HR department', 'ghhu', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 30, 1),
(16, 8, 'Hannah P. Mativo', 'HR department', 'ft', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 17, 1),
(17, 9, 'Hannah P. Mativo', 'HR department', 'fake', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 13, 1),
(21, 12, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(25, 15, 'Hannah P. Mativo', 'HR department', 'ff', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 1),
(28, 18, 'Hannah P. Mativo', 'HR department', '3', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 4, 1),
(29, 19, 'Hannah P. Mativo', 'HR department', 'ffg', '2019-02-11', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 1),
(31, 21, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-12', 9, 'Monel', 'alloys', 'Production', 'cm', 97, 1),
(35, 23, 'Hannah P. Mativo', 'HR department', 'DYNAMIC', '2019-02-17', 9, 'Monel', 'alloys', 'Production', 'cm', 2, 1),
(36, 24, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 'Monel', 'alloys', 'Production', 'cm', 5, 1),
(38, 26, 'Erick A. Golo', 'Accounting Department', 'PRODUCTION', '2019-02-18', 9, 'Monel', 'alloys', 'Production', 'cm', 1052, 1),
(18, 10, 'Hannah P. Mativo', 'HR department', '12', '2019-02-11', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 13, 1),
(20, 11, 'Hannah P. Mativo', 'HR department', 'rt', '2019-02-11', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 5, 1),
(24, 14, 'Hannah P. Mativo', 'HR department', '2', '2019-02-11', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 2, 1),
(30, 20, 'Hannah P. Mativo', 'HR department', 'g', '2019-02-11', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 15, 1),
(33, 22, 'Hannah P. Mativo', 'HR department', 'STOCKROOM3', '2019-02-12', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 25, 1),
(40, 28, 'Erick A. Golo', 'Accounting Department', 'PURCHASED', '2019-02-18', 10, 'Nimonic', 'Alloys', 'Production', 'cm', 1, 1),
(23, 13, 'Hannah P. Mativo', 'HR department', 'fr', '2019-02-11', 11, 'Pewter', 'Alloys', 'Production', 'cm', 10, 1),
(32, 21, 'Hannah P. Mativo', 'HR department', 'PRODUCTION', '2019-02-12', 11, 'Pewter', 'Alloys', 'Production', 'cm', 11, 1),
(39, 27, 'Erick A. Golo', 'Accounting Department', 'DF', '2019-02-18', 11, 'Pewter', 'Alloys', 'Production', 'cm', 451, 1);

-- --------------------------------------------------------

--
-- Table structure for table `vw_sales`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_sales` AS select `t`.`salesID` AS `salesID`,`t`.`itemID` AS `itemID`,`t`.`endProduct` AS `endProduct`,`t`.`description` AS `description`,`t`.`category` AS `category`,`t`.`unit` AS `unit`,`t`.`qty` AS `qty`,`t`.`untPrice` AS `untPrice`,`t`.`totalPrice` AS `totalPrice`,`t`.`vat` AS `vat`,`t`.`NoOfItems` AS `NoOfItems`,`t`.`sDate` AS `sDate`,`e`.`fname` AS `fname`,`e`.`lname` AS `lname`,`e`.`mi` AS `mi`,`c`.`clientName` AS `clientName`,`c`.`Company` AS `Company`,`c`.`Email` AS `Email`,`t`.`total` AS `total`,`t`.`grandTotal` AS `grandTotal`,`t`.`amountTendered` AS `amountTendered`,`t`.`change` AS `change`,`t`.`sTime` AS `sTime` from ((`inventorypetromine`.`tbl_maintransaction` `t` join `inventorypetromine`.`tbl_employee` `e` on((`t`.`empID` = `e`.`empID`))) join `inventorypetromine`.`tbl_client` `c` on((`t`.`clientID` = `c`.`clientID`)));

--
-- Dumping data for table `vw_sales`
--

INSERT INTO `vw_sales` (`salesID`, `itemID`, `endProduct`, `description`, `category`, `unit`, `qty`, `untPrice`, `totalPrice`, `vat`, `NoOfItems`, `sDate`, `fname`, `lname`, `mi`, `clientName`, `Company`, `Email`, `total`, `grandTotal`, `amountTendered`, `change`, `sTime`) VALUES
(11, 108, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 1, '20.00', '20.00', '3.00', 1, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'golo', 'Daedck Phils. Inc.', 'DeadckPI@yahoo.com', '20.00', '23.00', '30', '7.00', '03:47:12'),
(2, 101, 'Non-Ferrous Metals', 'Equipments', 'Warehouse', 'cm', 2, '45.00', '90.00', '13.50', 2, '2019-02-09', 'Hannah', 'Mativo', 'P.', 'Vidal', 'San Technology inc.', 'SanTecInc@yahoo.com', '90.00', '103.50', '120', '-16.50', '00:35:22'),
(7, 105, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 4, '20.00', '80.00', '12.00', 4, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Vidal', 'San Technology inc.', 'SanTecInc@yahoo.com', '80.00', '92.00', '100', '8.00', '03:27:45'),
(5, 104, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 4, '20.00', '80.00', '12.00', 7, '2019-02-10', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '740.00', '851.00', '1000', '149.00', '15:54:54'),
(6, 104, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 7, '2019-02-10', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '740.00', '851.00', '1000', '149.00', '15:54:54'),
(10, 107, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 2, '20.00', '40.00', '6.00', 2, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '40.00', '46.00', '20', '-26.00', '03:35:03'),
(12, 109, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 3, '20.00', '60.00', '9.00', 8, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '1,160.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(13, 109, 'Metal', 'Best Programming', 'Office', 'cm', 5, '220.00', '1100.00', '165.00', 8, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '1,160.00', '1,334.00', '1000', '-334.00', '03:49:57'),
(22, 115, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 1, '20.00', '20.00', '3.00', 51, '2019-02-14', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '11,020.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(23, 115, 'Metal', 'Best Programming', 'Office', 'cm', 50, '220.00', '11000.00', '1650.00', 51, '2019-02-14', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '11,020.00', '12,673.00', '15000', '2,327.00', '23:06:00'),
(25, 117, 'Ferrous-Non', 'Waste', 'Rotary', 'lbs', 8, '560.00', '4480.00', '672.00', 10, '2019-02-15', 'Hannah', 'Mativo', 'P.', 'Malone', 'Palaisdaan inc.', 'PalaisadaanInc@yahoo.com', '5,600.00', '6,272.00', '7000', '728.00', '20:02:27'),
(4, 103, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 3, '2019-02-09', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '660.00', '759.00', '1000', '241.00', '00:58:00'),
(8, 106, 'Ferrous Metals', 'Steels and Irons', 'Warehouse', 'cm', 3, '20.00', '60.00', '9.00', 6, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '720.00', '819.00', '500', '-319.00', '03:31:08'),
(9, 106, 'Metal', 'Best Programming', 'Office', 'cm', 3, '220.00', '660.00', '99.00', 6, '2019-02-11', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '720.00', '819.00', '500', '-319.00', '03:31:08'),
(18, 112, 'Non-Ferrous Metals', 'Equipments', 'Warehouse', 'cm', 1, '45.00', '45.00', '6.75', 1, '2019-02-13', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '45.00', '51.75', '100', '48.25', '03:24:05'),
(19, 113, 'Metal', 'Best Programming', 'Office', 'cm', 2, '220.00', '440.00', '66.00', 5, '2019-02-13', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '815.00', '937.25', '1000', '62.75', '03:31:58'),
(20, 113, 'Alloy', 'Scraps', 'ENGG', 'cm', 3, '125.00', '375.00', '56.25', 5, '2019-02-13', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '815.00', '937.25', '1000', '62.75', '03:31:58'),
(21, 114, 'Alloy', 'Scraps', 'ENGG', 'cm', 495, '125.00', '61875.00', '9281.25', 495, '2019-02-13', 'Hannah', 'Mativo', 'P.', 'Mativo', 'Ltd. Messiah Hardware Inc.', 'MessiahHardware@yahoo.com', '61,875.00', '71,156.25', '100000', '28,843.75', '03:33:56');

-- --------------------------------------------------------

--
-- Table structure for table `vw_temprawmaterialonhand`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventorypetromine`.`vw_temprawmaterialonhand` AS select `h`.`rawmaterialOnHandID` AS `rawmaterialOnHandID`,`h`.`transactionNo` AS `transactionNo`,`h`.`requestDate` AS `requestDate`,`h`.`comSupplier` AS `comSupplier`,`h`.`supplierName` AS `supplierName`,`h`.`deliveryRepNo` AS `deliveryRepNo`,`h`.`deliveryRepDate` AS `deliveryRepDate`,`h`.`receiveBy` AS `receiveBy`,`h`.`rawmaterialID` AS `rawmaterialID`,`r`.`rawmaterialName` AS `rawmaterialName`,`r`.`desc` AS `desc`,`c`.`catDesc` AS `catDesc`,`u`.`unitDesc` AS `unitDesc`,`h`.`qty` AS `qty` from (((`inventorypetromine`.`tbl_temprawmaterialonhand` `h` join `inventorypetromine`.`tbl_rawmaterial` `r` on((`h`.`rawmaterialID` = `r`.`rawmaterialID`))) join `inventorypetromine`.`tbl_category` `c` on((`r`.`catID` = `c`.`catID`))) join `inventorypetromine`.`tbl_unit` `u` on((`r`.`unitID` = `u`.`unitID`)));

--
-- Dumping data for table `vw_temprawmaterialonhand`
--


-- --------------------------------------------------------

--
-- Table structure for table `vw_transactionsales`
--
-- in use(#1356 - View 'inventorypetromine.vw_transactionsales' references invalid table(s) or column(s) or function(s) or definer/invoker of view lack rights to use them)

--
-- Dumping data for table `vw_transactionsales`
--
-- in use (#1356 - View 'inventorypetromine.vw_transactionsales' references invalid table(s) or column(s) or function(s) or definer/invoker of view lack rights to use them)

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_rawmaterialqty`
--
ALTER TABLE `tbl_rawmaterialqty`
  ADD CONSTRAINT `FK_tbl_rawmaterialqty` FOREIGN KEY (`rawmaterialqtyID`) REFERENCES `tbl_rawmaterialonhand` (`rawmaterialOnHandID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
