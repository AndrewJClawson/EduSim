# ************************************************************
# Sequel Pro SQL dump
# Version 4096
#
# http://www.sequelpro.com/
# http://code.google.com/p/sequel-pro/
#
# Host: 127.0.0.1 (MySQL 5.6.23)
# Database: edusim
# Generation Time: 2016-11-25 07:37:54 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table _account_types
# ------------------------------------------------------------

DROP TABLE IF EXISTS `_account_types`;

CREATE TABLE `_account_types` (
  `pk_account_type_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pk_account_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `_account_types` WRITE;
/*!40000 ALTER TABLE `_account_types` DISABLE KEYS */;

INSERT INTO `_account_types` (`pk_account_type_id`, `name`)
VALUES
	(1,'District'),
	(2,'School'),
	(3,'Homeschool');

/*!40000 ALTER TABLE `_account_types` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table _content_types
# ------------------------------------------------------------

DROP TABLE IF EXISTS `_content_types`;

CREATE TABLE `_content_types` (
  `pk_content_type_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pk_content_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `_content_types` WRITE;
/*!40000 ALTER TABLE `_content_types` DISABLE KEYS */;

INSERT INTO `_content_types` (`pk_content_type_id`, `name`)
VALUES
	(1,'Account'),
	(2,'User'),
	(3,'Profile');

/*!40000 ALTER TABLE `_content_types` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table _operations
# ------------------------------------------------------------

DROP TABLE IF EXISTS `_operations`;

CREATE TABLE `_operations` (
  `pk_operation_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pk_operation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `_operations` WRITE;
/*!40000 ALTER TABLE `_operations` DISABLE KEYS */;

INSERT INTO `_operations` (`pk_operation_id`, `name`)
VALUES
	(1,'Create'),
	(2,'View'),
	(3,'Edit'),
	(4,'Delete');

/*!40000 ALTER TABLE `_operations` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table _roles
# ------------------------------------------------------------

DROP TABLE IF EXISTS `_roles`;

CREATE TABLE `_roles` (
  `pk_role_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pk_role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `_roles` WRITE;
/*!40000 ALTER TABLE `_roles` DISABLE KEYS */;

INSERT INTO `_roles` (`pk_role_id`, `name`)
VALUES
	(1,'System Admin'),
	(2,'Account Admin'),
	(3,'School Admin'),
	(4,'Instructor');

/*!40000 ALTER TABLE `_roles` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table accounts
# ------------------------------------------------------------

DROP TABLE IF EXISTS `accounts`;

CREATE TABLE `accounts` (
  `pk_account_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fk_account_type_id` int(11) unsigned NOT NULL,
  `account_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`pk_account_id`),
  KEY `account_type` (`fk_account_type_id`),
  CONSTRAINT `account_type` FOREIGN KEY (`fk_account_type_id`) REFERENCES `_account_types` (`pk_account_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;

INSERT INTO `accounts` (`pk_account_id`, `fk_account_type_id`, `account_name`)
VALUES
	(1,1,'EduSim Test Account');

/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table campuses
# ------------------------------------------------------------

DROP TABLE IF EXISTS `campuses`;

CREATE TABLE `campuses` (
  `pk_campus_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fk_school_id` int(11) unsigned NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `zip` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`pk_campus_id`),
  KEY `campus_school` (`fk_school_id`),
  CONSTRAINT `campus_school` FOREIGN KEY (`fk_school_id`) REFERENCES `schools` (`pk_school_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `campuses` WRITE;
/*!40000 ALTER TABLE `campuses` DISABLE KEYS */;

INSERT INTO `campuses` (`pk_campus_id`, `fk_school_id`, `name`, `address`, `city`, `state`, `zip`)
VALUES
	(1,1,'Main Campus','123 EduSim Way','Thornton','CO','80229');

/*!40000 ALTER TABLE `campuses` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table profiles
# ------------------------------------------------------------

DROP TABLE IF EXISTS `profiles`;

CREATE TABLE `profiles` (
  `pk_profile_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fk_user_id` varchar(700) NOT NULL,
  `fk_account_id` int(11) unsigned NOT NULL,
  `fk_school_id` int(11) unsigned DEFAULT NULL,
  `fk_campus_id` int(11) unsigned DEFAULT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`pk_profile_id`),
  KEY `profile_user` (`fk_user_id`),
  KEY `profile_account` (`fk_account_id`),
  KEY `profile_school` (`fk_school_id`),
  KEY `profile_campus` (`fk_campus_id`),
  CONSTRAINT `profile_account` FOREIGN KEY (`fk_account_id`) REFERENCES `accounts` (`pk_account_id`),
  CONSTRAINT `profile_campus` FOREIGN KEY (`fk_campus_id`) REFERENCES `campuses` (`pk_campus_id`),
  CONSTRAINT `profile_school` FOREIGN KEY (`fk_school_id`) REFERENCES `schools` (`pk_school_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `profiles` WRITE;
/*!40000 ALTER TABLE `profiles` DISABLE KEYS */;

INSERT INTO `profiles` (`pk_profile_id`, `fk_user_id`, `fk_account_id`, `fk_school_id`, `fk_campus_id`, `first_name`, `last_name`)
VALUES
	(4,'e1e6f670-1bf0-44cc-a34e-7d7f443567dc',1,NULL,NULL,'Andrew','Clawson');

/*!40000 ALTER TABLE `profiles` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table schools
# ------------------------------------------------------------

DROP TABLE IF EXISTS `schools`;

CREATE TABLE `schools` (
  `pk_school_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fk_account_id` int(11) unsigned NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `zip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`pk_school_id`),
  KEY `school_account` (`fk_account_id`),
  CONSTRAINT `school_account` FOREIGN KEY (`fk_account_id`) REFERENCES `accounts` (`pk_account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

LOCK TABLES `schools` WRITE;
/*!40000 ALTER TABLE `schools` DISABLE KEYS */;

INSERT INTO `schools` (`pk_school_id`, `fk_account_id`, `name`, `address`, `city`, `state`, `zip`)
VALUES
	(1,1,'EduSim High School','123 EduSim Way','Thornton','CO','80229');

/*!40000 ALTER TABLE `schools` ENABLE KEYS */;
UNLOCK TABLES;



/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
