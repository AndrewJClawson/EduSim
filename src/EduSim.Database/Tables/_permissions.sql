CREATE TABLE IF NOT EXISTS _permissions
(
	pk_permission_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_content_type_operation_id int(11) unsigned NOT NULL,
	name varchar(100) DEFAULT NULL,
	PRIMARY KEY (pk_permission_id),
	CONSTRAINT content_type_operation FOREIGN KEY (fk_content_type_operation_id) REFERENCES _content_types_operations (pk_content_type_operations_id) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;