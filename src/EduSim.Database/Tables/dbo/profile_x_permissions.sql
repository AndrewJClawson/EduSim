source ./Tables/data_lookup/_permissions.sql;

CREATE TABLE IF NOT EXISTS profile_x_permissions
(
	pk_profile_permission_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_profile_id int(11) unsigned NOT NULL,
	fk_permission_id int(11) unsigned NOT NULL,

	PRIMARY KEY (pk_profile_permission_id),
	CONSTRAINT profile FOREIGN KEY (fk_profile_id) REFERENCES profiles (pk_profile_id) ON DELETE CASCADE ON UPDATE NO ACTION,
	CONSTRAINT permission FOREIGN KEY (fk_permission_id) REFERENCES _permissions (pk_permission_id) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;