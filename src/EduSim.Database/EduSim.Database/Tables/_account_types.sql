CREATE TABLE IF NOT EXISTS _account_types
(
	pk_account_type_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_account_type_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
