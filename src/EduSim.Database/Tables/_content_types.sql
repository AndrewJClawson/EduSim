CREATE TABLE IF NOT EXISTS _content_types
(
	pk_content_type_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_content_type_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;