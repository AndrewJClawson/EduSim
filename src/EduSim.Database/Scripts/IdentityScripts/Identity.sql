
DROP TABLE IF EXISTS users;

CREATE TABLE users (
  Id varchar(700) NOT NULL,
  Email varchar(256) DEFAULT NULL,
  EmailConfirmed tinyint(1) NOT NULL,
  PasswordHash longtext,
  SecurityStamp longtext,
  PhoneNumber longtext,
  PhoneNumberConfirmed tinyint(1) NOT NULL,
  TwoFactorEnabled tinyint(1) NOT NULL,
  LockoutEndDateUtc datetime DEFAULT NULL,
  LockoutEnabled tinyint(1) NOT NULL,
  AccessFailedCount int(11) NOT NULL,
  UserName varchar(256) NOT NULL,
  PRIMARY KEY (Id)
);





