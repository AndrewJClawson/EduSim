CREATE TABLE IF NOT EXISTS courses
(
	pk_course_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_subject_id int(11) unsigned NOT NULL,
	name varchar(100),
	description varchar(500),

	PRIMARY KEY (pk_course_id),

	CONSTRAINT courses_fk01 FOREIGN KEY (fk_course_category_id) REFERENCES course_categories (pk_school_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;