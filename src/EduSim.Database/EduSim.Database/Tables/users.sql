CREATE TABLE IF NOT EXISTS users
(
	pk_user_id int(11) unsigned NOT NULL AUTO_INCREMENT,

	fk_account_id int(11) unsigned NOT NULL,

	fk_school_id int(11) unsigned DEFAULT NULL,
	fk_campus_id int(11) unsigned DEFAULT NULL,

	first_name varchar(100) DEFAULT NULL,
	last_name varchar(100) DEFAULT NULL,
	email varchar(100) NOT NULL,
	password varchar(100) NOT NULL,

	is_admin char(1) DEFAULT NULL,
	is_instructor char(1) DEFAULT NULL,
	is_volunteer char(1) DEFAULT NULL,

	PRIMARY KEY (pk_user_id),
	KEY user_account (fk_account_id),
	KEY user_school (fk_school_id),
	KEY user_campus (fk_campus_id),

	CONSTRAINT user_account FOREIGN KEY (fk_account_id) REFERENCES accounts (pk_account_id),
	CONSTRAINT user_school FOREIGN KEY (fk_school_id) REFERENCES schools (pk_school_id),
	CONSTRAINT user_campus FOREIGN KEY (fk_campus_id) REFERENCES campuses (pk_campus_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
