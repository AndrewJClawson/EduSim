CREATE TABLE aspnetroles (
  Id varchar(128) NOT NULL,
  Name varchar(256) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE userclaims (
  Id int(11) NOT NULL AUTO_INCREMENT,
  UserId varchar(128) NOT NULL,
  ClaimType longtext,
  ClaimValue longtext,
  PRIMARY KEY (Id),
  UNIQUE KEY Id (Id),
  KEY UserId (UserId),
  CONSTRAINT ApplicationUser_Claims FOREIGN KEY (UserId) REFERENCES users (Id) ON DELETE CASCADE ON UPDATE NO ACTION
);