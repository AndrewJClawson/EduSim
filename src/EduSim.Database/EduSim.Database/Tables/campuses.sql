CREATE TABLE IF NOT EXISTS campuses
(
	pk_campus_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_school_id int(11) unsigned NOT NULL,

	name varchar(100),
	address varchar(100),
	city varchar(100),
	state varchar(100),
	zip varchar(12),

	PRIMARY KEY (pk_campus_id),
	KEY campus_school (fk_school_id),

	CONSTRAINT campus_school FOREIGN KEY (fk_school_id) REFERENCES schools (pk_school_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;