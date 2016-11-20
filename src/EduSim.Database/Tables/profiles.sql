CREATE TABLE IF NOT EXISTS profiles
(
	pk_profile_id int unsigned NOT NULL AUTO_INCREMENT,
	fk_user_id varchar(700) NOT NULL,
	fk_account_id int(11) unsigned NOT NULL,

	fk_school_id int(11) unsigned DEFAULT NULL,
	fk_campus_id int(11) unsigned DEFAULT NULL,

	first_name varchar(100) DEFAULT NULL,
	last_name varchar(100) DEFAULT NULL,

	PRIMARY KEY (pk_profile_id),
	KEY profile_user (fk_user_id),
	KEY profile_account (fk_account_id),
	KEY profile_school (fk_school_id),
	KEY profile_campus (fk_campus_id),

	CONSTRAINT profile_user FOREIGN KEY (fk_user_id) REFERENCES users (Id),
	CONSTRAINT profile_account FOREIGN KEY (fk_account_id) REFERENCES accounts (pk_account_id),
	CONSTRAINT profile_school FOREIGN KEY (fk_school_id) REFERENCES schools (pk_school_id),
	CONSTRAINT profile_campus FOREIGN KEY (fk_campus_id) REFERENCES campuses (pk_campus_id)

) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
