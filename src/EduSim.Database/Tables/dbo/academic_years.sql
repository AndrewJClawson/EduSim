CREATE TABLE IF NOT EXISTS academic_years
(
	pk_academic_year_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_account_id int(11) unsigned NOT NULL,

	start_date DATETIME,
	end_date DATETIME,

	PRIMARY KEY (pk_academic_year_id),
	CONSTRAINT academic_years_fk01 FOREIGN KEY (fk_account_id) REFERENCES accounts (pk_account_id)
	 
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;