CREATE TABLE IF NOT EXISTS roles (
  pk_role_id varchar(128) NOT NULL,
  name varchar(256) NOT NULL,
  PRIMARY KEY (pk_role_id)
);

CREATE TABLE IF NOT EXISTS users (
  pk_user_id varchar(128) NOT NULL,
  email varchar(256) DEFAULT NULL,
  email_confirmed tinyint(1) NOT NULL,
  password_has longtext,
  secutiry_stamp longtext,
  phone_number longtext,
  phone_number_confirmed tinyint(1) NOT NULL,
  two_factor_enabled tinyint(1) NOT NULL,
  lockou_end_date_utc datetime DEFAULT NULL,
  lockout_enabled tinyint(1) NOT NULL,
  access_failed_count int(11) NOT NULL,
  username varchar(256) NOT NULL,
  PRIMARY KEY (pk_user_id)
);

CREATE TABLE IF NOT EXISTS user_claims (
  pk_user_claim_id int(11) NOT NULL AUTO_INCREMENT,
  fk_user_id varchar(128) NOT NULL,
  claim_type longtext,
  claim_value longtext,
  PRIMARY KEY (pk_user_claim_id),
  UNIQUE KEY Id (pk_user_claim_id),
  KEY UserId (fk_user_id),
  CONSTRAINT ApplicationUser_Claims FOREIGN KEY (fk_user_id) REFERENCES users (pk_user_id) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS user_logins (
  login_provider varchar(128) NOT NULL,
  provider_key varchar(128) NOT NULL,
  fk_user_id varchar(128) NOT NULL,
  PRIMARY KEY (login_provider,provider_key,fk_user_id),
  KEY ApplicationUser_Logins (fk_user_id),
  CONSTRAINT ApplicationUser_Logins FOREIGN KEY (fk_user_id) REFERENCES users (pk_user_id) ON DELETE CASCADE ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS user_roles (
  fk_user_id varchar(128) NOT NULL,
  fk_role_id varchar(128) NOT NULL,
  PRIMARY KEY (fk_user_id,fk_role_id),
  KEY IdentityRole_Users (fk_user_id),
  KEY IdentityRole_Roles (fk_role_id),
  CONSTRAINT IdentityRole_Users FOREIGN KEY (fk_user_id) REFERENCES users (pk_user_id) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT IdentityRole_Roles FOREIGN KEY (fk_role_id) REFERENCES roles (pk_role_id) ON DELETE CASCADE ON UPDATE NO ACTION

);
