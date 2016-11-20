CREATE TABLE aspnetroles (
  Id varchar(128) NOT NULL,
  Name varchar(256) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE aspnetuserclaims (
  Id int(11) NOT NULL AUTO_INCREMENT,
  UserId varchar(128) NOT NULL,
  ClaimType longtext,
  ClaimValue longtext,
  PRIMARY KEY (Id),
  UNIQUE KEY Id (Id),
  KEY UserId (UserId),

);

CREATE TABLE aspnetuserlogins (
  LoginProvider varchar(128) NOT NULL,
  ProviderKey varchar(128) NOT NULL,
  UserId varchar(700) NOT NULL,
  PRIMARY KEY (LoginProvider,ProviderKey,UserId),
  KEY ApplicationUser_Logins (UserId),

);

CREATE TABLE aspnetuserroles (
  UserId varchar(700) NOT NULL,
  RoleId varchar(128) NOT NULL,
  PRIMARY KEY (UserId,RoleId),
  KEY IdentityRole_Users (RoleId),

);
