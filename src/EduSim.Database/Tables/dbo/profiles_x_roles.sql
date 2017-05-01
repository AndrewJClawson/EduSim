#source ./Tables/data_lookup/_permissions.sql;

CREATE TABLE IF NOT EXISTS profiles_x_roles
(
	
	fk_profile_id int(11) unsigned NOT NULL,
	fk_role_id int(11) unsigned NOT NULL,

	CONSTRAINT profiles_x_roles_fk01 FOREIGN KEY (fk_profile_id) REFERENCES profiles (pk_profile_id) ON DELETE CASCADE ON UPDATE NO ACTION,
	CONSTRAINT profiles_x_roles_fk02 FOREIGN KEY (fk_role_id) REFERENCES _roles (pk_role_id) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;