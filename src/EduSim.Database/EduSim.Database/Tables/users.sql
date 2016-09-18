CREATE TABLE IF NOT EXISTS 'users'
(
	pk_user_id int(11) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	fk_user_role int(11) unsigned NOT NULL,
	fk_account_id int(11) unsigned NOT NULL,

	fk_school_id int(11) unsigned NOT NULL,
	fk_campus_id int(11) unsigned NOT NULL,

	first_name varchar(100) DEFAULT NULL,
	last_name varchar(100) DEFAULT NULL,
	email varchar(100) DEFAULT NULL,

)
