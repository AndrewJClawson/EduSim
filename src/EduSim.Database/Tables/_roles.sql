﻿CREATE TABLE IF NOT EXISTS _roles
(
	pk_account_type_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(256) DEFAULT NULL,
	
	PRIMARY KEY (pk_account_type_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;