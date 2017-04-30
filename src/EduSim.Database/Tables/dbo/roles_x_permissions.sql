source ./Tables/data_lookup/_permissions.sql;

CREATE TABLE IF NOT EXISTS roles_x_permissions
(
	
	fk_role_id int(11) unsigned NOT NULL,
	fk_permission_id int(11) unsigned NOT NULL,

	CONSTRAINT role FOREIGN KEY (fk_role_id) REFERENCES _roles (pk_role_id) ON DELETE CASCADE ON UPDATE NO ACTION,
	CONSTRAINT permission FOREIGN KEY (fk_permission_id) REFERENCES _permissions (pk_permission_id) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;