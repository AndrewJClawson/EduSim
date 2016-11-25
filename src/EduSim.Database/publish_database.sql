

/* Drop database */
source Scripts/delete_application_database.sql;

/* Create new database */
source Scripts/create_database.sql;

use edusim;
/* create and populate reference tables */
source Scripts/create_reference_tables.sql;
source Scripts/populate_reference_data.sql;

/* create application tables */
source Scripts/create_application_tables.sql;
source Scripts/initial_develop_data.sql;







