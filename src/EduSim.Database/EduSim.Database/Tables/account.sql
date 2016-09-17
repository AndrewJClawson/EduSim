CREATE TABLE `Accounts` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `ManagerID` int(11) unsigned DEFAULT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Type` varchar(20) DEFAULT NULL,
  `CreationDate` date DEFAULT NULL,
  `CloseDate` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Manager` (`ManagerID`),
  CONSTRAINT `Manager` FOREIGN KEY (`ManagerID`) REFERENCES `USERS` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
