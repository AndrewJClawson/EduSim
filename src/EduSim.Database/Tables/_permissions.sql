CREATE TABLE IF NOT EXISTS _permissions
(
	pk_permission_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_content_type_id int(11) unsigned NOT NULL,
	fk_operation_id int(11) unsigned NOT NULL,
	name varchar(100) DEFAULT NULL,
	PRIMARY KEY (pk_permission_id),
	CONSTRAINT content_type FOREIGN KEY (fk_content_type_id) REFERENCES _content_types (pk_content_type_id) ON DELETE CASCADE ON UPDATE NO ACTION,
	CONSTRAINT operation FOREIGN KEY (fk_operation_id) REFERENCES _operations (pk_operation_id) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;