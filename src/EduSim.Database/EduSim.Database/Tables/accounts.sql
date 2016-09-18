CREATE TABLE IF NOT EXISTS accounts
(
	pk_account_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_account_type_id int(11) unsigned NOT NULL,

	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_account_id),
	KEY account_type (fk_account_type_id),
	CONSTRAINT account_type FOREIGN KEY (fk_account_type_id) REFERENCES edusim._account_types(pk_account_type_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;