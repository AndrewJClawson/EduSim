CREATE TABLE IF NOT EXISTS schools
(
	pk_school_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_account_id int(11) unsigned NOT NULL,

	name varchar(100),
	address varchar(100),
	city varchar(100),
	state varchar(100),
	zip varchar(100),

	PRIMARY KEY (pk_school_id),
	KEY school_account (fk_account_id),
	CONSTRAINT school_account FOREIGN KEY (fk_account_id) REFERENCES accounts (pk_account_id)
	 
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;