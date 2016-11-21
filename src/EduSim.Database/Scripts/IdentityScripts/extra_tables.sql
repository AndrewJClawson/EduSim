CREATE TABLE IF NOT EXISTS aspnetroles (
  Id varchar(128) NOT NULL,
  Name varchar(256) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS aspnetuserclaims (
  Id int(11) NOT NULL AUTO_INCREMENT,
  UserId varchar(128) NOT NULL,
  ClaimType longtext,
  ClaimValue longtext,
  PRIMARY KEY (Id),
  UNIQUE KEY Id (Id),
  KEY UserId (UserId),
  CONSTRAINT ApplicationUser_Claims FOREIGN KEY (UserId) REFERENCES users (Id) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS aspnetuserlogins (
  LoginProvider varchar(128) NOT NULL,
  ProviderKey varchar(128) NOT NULL,
  UserId varchar(700) NOT NULL,
  PRIMARY KEY (LoginProvider,ProviderKey,UserId),
  KEY ApplicationUser_Logins (UserId),
  CONSTRAINT ApplicationUser_Logins FOREIGN KEY (UserId) REFERENCES users (Id) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS aspnetuserroles (
  UserId varchar(700) NOT NULL,
  RoleId varchar(128) NOT NULL,
  PRIMARY KEY (UserId,RoleId),
  KEY IdentityRole_Users (RoleId),
  CONSTRAINT IdentityRole_Users FOREIGN KEY (UserId) REFERENCES users (Id) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT IdentityRole_Roles FOREIGN KEY (RoleId) REFERENCES aspnetroles (Id) ON DELETE CASCADE ON UPDATE NO ACTION
);
